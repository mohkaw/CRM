namespace CRM
{
    partial class AdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InsertUser = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.uType = new System.Windows.Forms.ComboBox();
            this.sName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteUser = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ManageCases = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.caseSearch = new System.Windows.Forms.TextBox();
            this.caseView = new System.Windows.Forms.DataGridView();
            this.InsertCase = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.caseFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.caseOwner = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.caseRef = new System.Windows.Forms.TextBox();
            this.caseDesc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.InsertUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DeleteUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.ManageCases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseView)).BeginInit();
            this.InsertCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InsertUser);
            this.tabControl1.Controls.Add(this.DeleteUser);
            this.tabControl1.Controls.Add(this.ManageCases);
            this.tabControl1.Controls.Add(this.InsertCase);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 499);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // InsertUser
            // 
            this.InsertUser.BackColor = System.Drawing.SystemColors.Control;
            this.InsertUser.Controls.Add(this.groupBox2);
            this.InsertUser.Location = new System.Drawing.Point(4, 25);
            this.InsertUser.Name = "InsertUser";
            this.InsertUser.Padding = new System.Windows.Forms.Padding(3);
            this.InsertUser.Size = new System.Drawing.Size(1072, 470);
            this.InsertUser.TabIndex = 0;
            this.InsertUser.Text = "Insert User";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.phone);
            this.groupBox2.Controls.Add(this.uType);
            this.groupBox2.Controls.Add(this.sName);
            this.groupBox2.Controls.Add(this.fName);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.pass);
            this.groupBox2.Controls.Add(this.uname);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 416);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inserting a user to user table";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(155, 251);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(246, 22);
            this.phone.TabIndex = 13;
            // 
            // uType
            // 
            this.uType.FormattingEnabled = true;
            this.uType.Items.AddRange(new object[] {
            "admin",
            "client"});
            this.uType.Location = new System.Drawing.Point(155, 211);
            this.uType.Name = "uType";
            this.uType.Size = new System.Drawing.Size(158, 24);
            this.uType.TabIndex = 12;
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(155, 180);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(246, 22);
            this.sName.TabIndex = 11;
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(155, 147);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(246, 22);
            this.fName.TabIndex = 10;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(155, 114);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(246, 22);
            this.email.TabIndex = 9;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(155, 79);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(246, 22);
            this.pass.TabIndex = 8;
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(155, 45);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(246, 22);
            this.uname.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone Number:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "User Type:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Surname:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:*";
            // 
            // DeleteUser
            // 
            this.DeleteUser.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteUser.Controls.Add(this.button6);
            this.DeleteUser.Controls.Add(this.userGridView);
            this.DeleteUser.Controls.Add(this.searchBox);
            this.DeleteUser.Controls.Add(this.label8);
            this.DeleteUser.Location = new System.Drawing.Point(4, 25);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteUser.Size = new System.Drawing.Size(1072, 470);
            this.DeleteUser.TabIndex = 1;
            this.DeleteUser.Text = "Delete User";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 427);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(267, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Delete Selected User";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // userGridView
            // 
            this.userGridView.AllowUserToResizeRows = false;
            this.userGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.userGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.GridColor = System.Drawing.SystemColors.Control;
            this.userGridView.Location = new System.Drawing.Point(9, 87);
            this.userGridView.Name = "userGridView";
            this.userGridView.ReadOnly = true;
            this.userGridView.RowHeadersVisible = false;
            this.userGridView.RowHeadersWidth = 51;
            this.userGridView.RowTemplate.Height = 24;
            this.userGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGridView.Size = new System.Drawing.Size(1015, 316);
            this.userGridView.TabIndex = 13;
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.Location = new System.Drawing.Point(9, 46);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(267, 22);
            this.searchBox.TabIndex = 12;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Select a user to delete ";
            // 
            // ManageCases
            // 
            this.ManageCases.BackColor = System.Drawing.SystemColors.Control;
            this.ManageCases.Controls.Add(this.button3);
            this.ManageCases.Controls.Add(this.button2);
            this.ManageCases.Controls.Add(this.label9);
            this.ManageCases.Controls.Add(this.caseSearch);
            this.ManageCases.Controls.Add(this.caseView);
            this.ManageCases.Location = new System.Drawing.Point(4, 25);
            this.ManageCases.Name = "ManageCases";
            this.ManageCases.Size = new System.Drawing.Size(1072, 470);
            this.ManageCases.TabIndex = 2;
            this.ManageCases.Text = "Manage Cases";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(795, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete Selected Case";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(795, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Open Selected Case Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Search case by Ref.";
            // 
            // caseSearch
            // 
            this.caseSearch.Location = new System.Drawing.Point(6, 57);
            this.caseSearch.Name = "caseSearch";
            this.caseSearch.Size = new System.Drawing.Size(292, 22);
            this.caseSearch.TabIndex = 1;
            this.caseSearch.TextChanged += new System.EventHandler(this.caseSearch_TextChanged);
            // 
            // caseView
            // 
            this.caseView.AllowUserToResizeRows = false;
            this.caseView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.caseView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.caseView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caseView.GridColor = System.Drawing.SystemColors.Control;
            this.caseView.Location = new System.Drawing.Point(6, 85);
            this.caseView.Name = "caseView";
            this.caseView.ReadOnly = true;
            this.caseView.RowHeadersVisible = false;
            this.caseView.RowHeadersWidth = 51;
            this.caseView.RowTemplate.Height = 24;
            this.caseView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.caseView.Size = new System.Drawing.Size(783, 318);
            this.caseView.TabIndex = 0;
            // 
            // InsertCase
            // 
            this.InsertCase.BackColor = System.Drawing.SystemColors.Control;
            this.InsertCase.Controls.Add(this.label15);
            this.InsertCase.Controls.Add(this.label14);
            this.InsertCase.Controls.Add(this.label13);
            this.InsertCase.Controls.Add(this.caseDesc);
            this.InsertCase.Controls.Add(this.button5);
            this.InsertCase.Controls.Add(this.button4);
            this.InsertCase.Controls.Add(this.caseFile);
            this.InsertCase.Controls.Add(this.label12);
            this.InsertCase.Controls.Add(this.caseOwner);
            this.InsertCase.Controls.Add(this.label11);
            this.InsertCase.Controls.Add(this.label10);
            this.InsertCase.Controls.Add(this.caseRef);
            this.InsertCase.Location = new System.Drawing.Point(4, 25);
            this.InsertCase.Name = "InsertCase";
            this.InsertCase.Size = new System.Drawing.Size(1072, 470);
            this.InsertCase.TabIndex = 3;
            this.InsertCase.Text = "Insert New Case";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 31);
            this.button5.TabIndex = 7;
            this.button5.Text = "Insert Case";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // caseFile
            // 
            this.caseFile.Location = new System.Drawing.Point(7, 174);
            this.caseFile.Name = "caseFile";
            this.caseFile.Size = new System.Drawing.Size(365, 22);
            this.caseFile.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Case File: ";
            // 
            // caseOwner
            // 
            this.caseOwner.FormattingEnabled = true;
            this.caseOwner.Location = new System.Drawing.Point(7, 115);
            this.caseOwner.Name = "caseOwner";
            this.caseOwner.Size = new System.Drawing.Size(365, 24);
            this.caseOwner.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Case Owners:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Case Reference: ";
            // 
            // caseRef
            // 
            this.caseRef.Location = new System.Drawing.Point(7, 57);
            this.caseRef.Name = "caseRef";
            this.caseRef.Size = new System.Drawing.Size(365, 22);
            this.caseRef.TabIndex = 0;
            // 
            // caseDesc
            // 
            this.caseDesc.Location = new System.Drawing.Point(7, 265);
            this.caseDesc.Multiline = true;
            this.caseDesc.Name = "caseDesc";
            this.caseDesc.Size = new System.Drawing.Size(365, 122);
            this.caseDesc.TabIndex = 8;
            this.caseDesc.TextChanged += new System.EventHandler(this.caseDesc_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Description ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(127, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "out of Max 300 Characters: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(93, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 17);
            this.label15.TabIndex = 11;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.tabControl1.ResumeLayout(false);
            this.InsertUser.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DeleteUser.ResumeLayout(false);
            this.DeleteUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ManageCases.ResumeLayout(false);
            this.ManageCases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseView)).EndInit();
            this.InsertCase.ResumeLayout(false);
            this.InsertCase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InsertUser;
        private System.Windows.Forms.TabPage DeleteUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox uType;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.TabPage ManageCases;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox caseSearch;
        private System.Windows.Forms.DataGridView caseView;
        private System.Windows.Forms.TabPage InsertCase;
        private System.Windows.Forms.ComboBox caseOwner;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox caseRef;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox caseFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox caseDesc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}