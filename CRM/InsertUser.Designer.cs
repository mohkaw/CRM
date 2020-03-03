namespace CRM
{
    partial class InsertUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.uType);
            this.groupBox1.Controls.Add(this.sName);
            this.groupBox1.Controls.Add(this.fName);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.uname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 416);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserting a user to user table";
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
            // InsertUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 440);
            this.Controls.Add(this.groupBox1);
            this.Name = "InsertUser";
            this.Text = "InsertUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}