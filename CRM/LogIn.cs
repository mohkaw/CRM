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
using System.Security.Cryptography;

namespace CRM
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string user = userName.Text;
            MD5 md5Hash = MD5.Create();
            string source = passWord.Text;
            string pass = GetMd5HashWithMySecurityAlgo(md5Hash, source);
            try
            {
                string connStr = File.ReadAllText("connector.txt");
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string check = "SELECT * FROM users WHERE (uName='" + user + "') AND(password='" + pass + "')";
                MySqlCommand checking = new MySqlCommand(check, conn); 
                MySqlDataReader read = checking.ExecuteReader();
                if(read.Read())
                {
                    Variables.loggedUser.UserName = user;
                    Variables.loggedUser.UserID = int.Parse(read[0].ToString());
                    if (read[6].Equals("admin"))
                    {
                        this.Hide();
                        Form f1 = new AdminHome();
                        f1.ShowDialog();
                        this.Close();

                    }
                    else if(read[6].Equals("client"))
                    {
                        this.Hide();
                        Form f1 = new ClientHome();
                        f1.ShowDialog();
                        this.Close();
                    }
                    


                }
                else
                {
                    MessageBox.Show("The username password combination is wrong\nPlease try Again");
                    userName.Text = string.Empty;
                    passWord.Text = string.Empty;
                }
            }
            catch (Exception ioe)
            {
                MessageBox.Show(ioe.ToString());
            }
        }
        static string GetMd5HashWithMySecurityAlgo(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();

        }
    }
}
