﻿using System;
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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            InitializeUserGridView();
            InitializeCseGridView();
        }
        private void InitializeUserGridView()
        {
            string connStr = File.ReadAllText("connector.txt");
            string userName = searchBox.Text;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string check = "SELECT * FROM users WHERE uName LIKE'%" + userName + "%'";
                // MySqlCommand checking = new MySqlCommand(check, conn);
                MySqlDataAdapter tbldata = new MySqlDataAdapter(check, conn);
                DataTable tbl = new DataTable();
                tbldata.Fill(tbl);
                tbl.Columns.Remove("password");
                //MySqlDataReader read = checking.ExecuteReader();
                userGridView.DataSource = tbl;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        private void InitializeCseGridView()
        {
            string connStr = File.ReadAllText("connector.txt");
            string caseRef = searchBox.Text;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                //string check = "SELECT * FROM cases WHERE caseRef LIKE'%" + caseRef + "%'";
                string check = "SELECT * FROM cases";
                // MySqlCommand checking = new MySqlCommand(check, conn);
                MySqlDataAdapter tbldata = new MySqlDataAdapter(check, conn);
                DataTable tbl = new DataTable();
                tbldata.Fill(tbl);
                //tbl.Columns.Remove("caseId");
                //MySqlDataReader read = checking.ExecuteReader();
                caseView.DataSource = tbl;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            /*List<string> autoComplete = new List<string>();
            autoComplete.Clear();*/
            string connStr = File.ReadAllText("connector.txt");
            string userName = searchBox.Text;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string check = "SELECT * FROM users WHERE uName LIKE'%" + userName + "%'";
                // MySqlCommand checking = new MySqlCommand(check, conn);
                MySqlDataAdapter tbldata = new MySqlDataAdapter(check, conn);
                DataTable tbl = new DataTable();
                tbldata.Fill(tbl);
                tbl.Columns.Remove("password");
                //MySqlDataReader read = checking.ExecuteReader();
                userGridView.DataSource = tbl;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {

            string dd = userGridView[0, userGridView.CurrentRow.Index].Value.ToString();
            int id = int.Parse(dd);
            if (MessageBox.Show("Are you sure??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connStr = File.ReadAllText("connector.txt");
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM users WHERE uID ='" + id + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("User Deleted Successfully!");
                    }
                    InitializeUserGridView();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void caseSearch_TextChanged(object sender, EventArgs e)
        {
            string connStr = File.ReadAllText("connector.txt");
            string casRef = caseSearch.Text;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string check = "SELECT * FROM cases WHERE caseRef LIKE'%" + casRef + "%'";
                // MySqlCommand checking = new MySqlCommand(check, conn);
                MySqlDataAdapter tbldata = new MySqlDataAdapter(check, conn);
                DataTable tbl = new DataTable();
                tbldata.Fill(tbl);
                //MySqlDataReader read = checking.ExecuteReader();
                caseView.DataSource = tbl;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dd = caseView[0, caseView.CurrentRow.Index].Value.ToString();
            int id = int.Parse(dd);
            if (MessageBox.Show("Are you sure??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connStr = File.ReadAllText("connector.txt");
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM cases WHERE 	caceId ='" + id + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Case Deleted Successfully!");
                    }
                    InitializeCseGridView();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
