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
    }
}
