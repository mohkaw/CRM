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
    public partial class InsertUser : Form
    {
        public InsertUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = uname.Text;
            MD5 md5Hash = MD5.Create();
            string source = pass.Text;
            string passWord = GetMd5HashWithMySecurityAlgo(md5Hash, source);
            string emailAddress = email.Text;
            string firstName = fName.Text;
            string lastName = sName.Text;
            string type = uType.SelectedItem.ToString();
            string phoneNumber = phone.Text;
            string connStr = File.ReadAllText("connector.txt");
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string check = "SELECT * FROM users WHERE (uName='" + userName + "') OR(email='" + emailAddress + "')";
                MySqlCommand checking = new MySqlCommand(check, conn);
                MySqlDataReader read = checking.ExecuteReader();
                string message = "";
                if (read.Read())
                {
                    if (read[1].Equals(userName))
                    {
                        message = "The user name is already used please change it\n";
                    }
                    if (read[3].Equals(emailAddress))
                    {
                        message += "The email address you entered is already associated with another account";
                    }
                    MessageBox.Show(message);
                    conn.Close();
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(connStr);
                    con.Open();
                    string sql = "INSERT INTO users ( uName, password, email, firstName, surName, userType, phoneNumber) VALUES ( '" + userName + "','" + passWord + "','" + emailAddress + "','" + firstName + "','" + lastName + "','" + type + "','" + phoneNumber + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Data inserted successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
