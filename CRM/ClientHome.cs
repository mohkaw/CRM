using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CRM
{
    public partial class ClientHome : Form
    {
        public ClientHome()
        {
            InitializeComponent();
            this.Text = "Logged In as " + Variables.loggedUser.UserName;
            initializeCaseView();
            initilizeCaseRefs();
            initializeTaskView();
            taskView.Columns["caseRef"].Width = 150;
            taskView.Columns["status"].Width = 100;
        }

        private void initializeCaseView()
        {
            string connStr = File.ReadAllText("connector.txt");
            int uId = Variables.loggedUser.UserID;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string check = "SELECT * FROM caseowners WHERE userId ='" + uId + "'";
                // MySqlCommand checking = new MySqlCommand(check, conn);
                MySqlDataAdapter tbldata = new MySqlDataAdapter(check, conn);
                DataTable tbl = new DataTable();
                tbldata.Fill(tbl);
                tbl.Columns.Remove("userId");
                tbl.Columns.Remove("userName");
                //MySqlDataReader read = checking.ExecuteReader();
                caseView.DataSource = tbl;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void initializeTaskView()
        {
            string connStr = File.ReadAllText("connector.txt");
            int uId = Variables.loggedUser.UserID;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                
                conn.Open();
                string check = "SELECT * FROM task WHERE userId ='" + uId + "'";
                // MySqlCommand checking = new MySqlCommand(check, conn);
                MySqlDataAdapter tbldata = new MySqlDataAdapter(check, conn);
                DataTable tbl = new DataTable();
                tbldata.Fill(tbl);
                
                tbl.Columns.Remove("taskId");
                tbl.Columns.Remove("userId");

                
                taskView.DataSource = tbl;
                taskView.Columns["caseRef"].Width = 0;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            

        }
        private void initilizeCaseRefs()
        {
            string connStr = File.ReadAllText("connector.txt");
            int uuId = Variables.loggedUser.UserID;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string check = "SELECT * FROM caseowners WHERE userId ='" + uuId +"'";
                MySqlCommand checking = new MySqlCommand(check, conn);
                MySqlDataReader reader = checking.ExecuteReader();
                while (reader.Read())
                {
                    string caseRef = reader[0].ToString();
                    caseRefCombo.Items.Add(caseRef);
                    taskCase.Items.Add(caseRef);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            caseRefCombo.SelectedIndex = 0;
            taskCase.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string connStr = File.ReadAllText("connector.txt");
            string caseRef = caseRefBox.Text;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string check = "SELECT * FROM caseowners WHERE caseRef LIKE'%" + caseRef + "%'";
                
                MySqlDataAdapter tbldata = new MySqlDataAdapter(check, conn);
                DataTable tbl = new DataTable();
                tbldata.Fill(tbl);
                tbl.Columns.Remove("userId");
                tbl.Columns.Remove("userName");

                caseView.DataSource = tbl;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        String clickedCaseRef = null;

        private void caseView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string cr = caseView.CurrentCell.Value.ToString();
            clickedCaseRef = cr;
            string connStr = File.ReadAllText("connector.txt");
            //string caseRef = caseRefBox.Text;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string check = "SELECT * FROM evidence WHERE caseRef ='" + cr + "'";

                MySqlDataAdapter tbldata = new MySqlDataAdapter(check, conn);
                DataTable tbl = new DataTable();
                tbldata.Fill(tbl);
                tbl.Columns.Remove("evidenceId");
                tbl.Columns.Remove("caseRef");
                

                FileView.DataSource = tbl;
                FileView.Columns["file"].DisplayIndex = 0;
                FileView.Columns[1].Width = 150;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = fileDialog.FileName;
                evidenceFile.Text = filename;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string caseref = caseRefCombo.SelectedItem.ToString();
            string desc = description.Text;
            string s = evidenceFile.Text;
            string filen = Path.GetFileName(s);
            string dirctory = Path.GetDirectoryName(s);
            string caseDir = @"d:\cases\"+ caseref+@"\" ;
            string destination = Path.Combine(caseDir, filen);
            if (!System.IO.Directory.Exists(caseDir))
            {
                MessageBox.Show(caseDir+"\nThe selected directory does not exist\nPlease contact the Admin!");
               
            }
            else
            {
                File.Copy(s, destination);
                string connStr = File.ReadAllText("connector.txt");
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    conn.Open();
                    string sql = "SET GLOBAL sql_mode ='NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION,NO_BACKSLASH_ESCAPES';" + "INSERT INTO evidence ( caseRef, description, file) VALUES ( '" + caseref + "','" + desc + "','" + destination + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Data inserted successfully" + caseDir);
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            description.Text = null;
            evidenceFile.Text = null;


        }

        private void FileBox_TextChanged(object sender, EventArgs e)
        {
            string dd = FileBox.Text;
            //MessageBox.Show(dd);
            string connStr = File.ReadAllText("connector.txt");
            //string caseRef = caseRefBox.Text;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string check = "SELECT * FROM evidence WHERE caseRef ='" + clickedCaseRef + "' AND  file LIKE'%" + dd + "%'";

                MySqlDataAdapter tbldata = new MySqlDataAdapter(check, conn);
                DataTable tbl = new DataTable();
                tbldata.Fill(tbl);
                tbl.Columns.Remove("evidenceId");
                tbl.Columns.Remove("caseRef");
                FileView.Columns["file"].DisplayIndex = 0;
                FileView.Columns[1].Width = 150;
                FileView.DataSource = tbl;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fileName = FileView.SelectedCells[1].Value.ToString();
            System.Diagnostics.Process.Start(fileName);
           
        }

        private void taskSearch_TextChanged(object sender, EventArgs e)
        {
            string reff = taskSearch.Text;
            string connStr = File.ReadAllText("connector.txt");
            int uId = Variables.loggedUser.UserID;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string check = "SELECT * FROM task WHERE userId ='" + uId + "' AND caseRef LIKE '%"+reff+"%'";
                // MySqlCommand checking = new MySqlCommand(check, conn);
                MySqlDataAdapter tbldata = new MySqlDataAdapter(check, conn);
                DataTable tbl = new DataTable();
                tbldata.Fill(tbl);
                tbl.Columns.Remove("taskId");
                tbl.Columns.Remove("userId");
               
                taskView.DataSource = tbl;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            int uId = Variables.loggedUser.UserID;
            string casereference = taskCase.Text;
            string taskdesc = taskDesc.Text;
            
            string connStr = File.ReadAllText("connector.txt");
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                
               
                    MySqlConnection con = new MySqlConnection(connStr);
                    con.Open();
                    string sql = "INSERT INTO task ( userId, caseRef, taskDescription, status) VALUES ( '" + uId + "','" + casereference + "','" + taskdesc + "',+'pending')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Data inserted successfully");
                    }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            taskCase.SelectedIndex = 0;
            taskDesc.Text = null;
        }

        private void taskDesc_TextChanged(object sender, EventArgs e)
        {
            string d = taskDesc.Text;
            int x = d.Length;
            label9.Text =x.ToString() ;
        }
    }
}
