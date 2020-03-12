namespace CRM
{
    partial class ClientHome
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
            this.Cases = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.FileView = new System.Windows.Forms.DataGridView();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.caseRefBox = new System.Windows.Forms.TextBox();
            this.caseView = new System.Windows.Forms.DataGridView();
            this.Evidence = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.evidenceFile = new System.Windows.Forms.TextBox();
            this.caseRefCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.taskView = new System.Windows.Forms.DataGridView();
            this.taskSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.taskDesc = new System.Windows.Forms.TextBox();
            this.taskCase = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Cases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseView)).BeginInit();
            this.Evidence.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cases);
            this.tabControl1.Controls.Add(this.Evidence);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1213, 669);
            this.tabControl1.TabIndex = 0;
            // 
            // Cases
            // 
            this.Cases.BackColor = System.Drawing.SystemColors.Control;
            this.Cases.Controls.Add(this.button3);
            this.Cases.Controls.Add(this.FileView);
            this.Cases.Controls.Add(this.FileBox);
            this.Cases.Controls.Add(this.label2);
            this.Cases.Controls.Add(this.label1);
            this.Cases.Controls.Add(this.caseRefBox);
            this.Cases.Controls.Add(this.caseView);
            this.Cases.Location = new System.Drawing.Point(4, 25);
            this.Cases.Name = "Cases";
            this.Cases.Padding = new System.Windows.Forms.Padding(3);
            this.Cases.Size = new System.Drawing.Size(1205, 640);
            this.Cases.TabIndex = 0;
            this.Cases.Text = "Cases";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "Open Selected File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FileView
            // 
            this.FileView.AllowUserToAddRows = false;
            this.FileView.AllowUserToDeleteRows = false;
            this.FileView.AllowUserToResizeRows = false;
            this.FileView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.FileView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileView.GridColor = System.Drawing.SystemColors.Control;
            this.FileView.Location = new System.Drawing.Point(199, 62);
            this.FileView.Name = "FileView";
            this.FileView.ReadOnly = true;
            this.FileView.RowHeadersVisible = false;
            this.FileView.RowHeadersWidth = 51;
            this.FileView.RowTemplate.Height = 24;
            this.FileView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileView.Size = new System.Drawing.Size(949, 514);
            this.FileView.TabIndex = 5;
            // 
            // FileBox
            // 
            this.FileBox.Location = new System.Drawing.Point(199, 34);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(184, 22);
            this.FileBox.TabIndex = 4;
            this.FileBox.TextChanged += new System.EventHandler(this.FileBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Files:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Case By Reference: ";
            // 
            // caseRefBox
            // 
            this.caseRefBox.Location = new System.Drawing.Point(9, 34);
            this.caseRefBox.Name = "caseRefBox";
            this.caseRefBox.Size = new System.Drawing.Size(184, 22);
            this.caseRefBox.TabIndex = 1;
            this.caseRefBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // caseView
            // 
            this.caseView.AllowUserToAddRows = false;
            this.caseView.AllowUserToDeleteRows = false;
            this.caseView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.caseView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.caseView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.caseView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caseView.GridColor = System.Drawing.SystemColors.Control;
            this.caseView.Location = new System.Drawing.Point(9, 62);
            this.caseView.Name = "caseView";
            this.caseView.ReadOnly = true;
            this.caseView.RowHeadersVisible = false;
            this.caseView.RowHeadersWidth = 51;
            this.caseView.RowTemplate.Height = 24;
            this.caseView.Size = new System.Drawing.Size(184, 572);
            this.caseView.TabIndex = 0;
            this.caseView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.caseView_CellClick);
            // 
            // Evidence
            // 
            this.Evidence.BackColor = System.Drawing.SystemColors.Control;
            this.Evidence.Controls.Add(this.label5);
            this.Evidence.Controls.Add(this.label4);
            this.Evidence.Controls.Add(this.description);
            this.Evidence.Controls.Add(this.button2);
            this.Evidence.Controls.Add(this.button1);
            this.Evidence.Controls.Add(this.evidenceFile);
            this.Evidence.Controls.Add(this.caseRefCombo);
            this.Evidence.Controls.Add(this.label3);
            this.Evidence.Location = new System.Drawing.Point(4, 25);
            this.Evidence.Name = "Evidence";
            this.Evidence.Padding = new System.Windows.Forms.Padding(3);
            this.Evidence.Size = new System.Drawing.Size(1205, 640);
            this.Evidence.TabIndex = 1;
            this.Evidence.Text = " Add Evidence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Choose File To Upload:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(9, 163);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(402, 116);
            this.description.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // evidenceFile
            // 
            this.evidenceFile.Location = new System.Drawing.Point(9, 106);
            this.evidenceFile.Name = "evidenceFile";
            this.evidenceFile.Size = new System.Drawing.Size(402, 22);
            this.evidenceFile.TabIndex = 2;
            // 
            // caseRefCombo
            // 
            this.caseRefCombo.FormattingEnabled = true;
            this.caseRefCombo.Location = new System.Drawing.Point(9, 45);
            this.caseRefCombo.Name = "caseRefCombo";
            this.caseRefCombo.Size = new System.Drawing.Size(238, 24);
            this.caseRefCombo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Case Reference:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.taskView);
            this.tabPage1.Controls.Add(this.taskSearch);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1205, 640);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "View Tasks";
            // 
            // taskView
            // 
            this.taskView.AllowUserToDeleteRows = false;
            this.taskView.AllowUserToResizeRows = false;
            this.taskView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taskView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.taskView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskView.GridColor = System.Drawing.SystemColors.Control;
            this.taskView.Location = new System.Drawing.Point(6, 75);
            this.taskView.Name = "taskView";
            this.taskView.ReadOnly = true;
            this.taskView.RowHeadersVisible = false;
            this.taskView.RowHeadersWidth = 51;
            this.taskView.RowTemplate.Height = 24;
            this.taskView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskView.Size = new System.Drawing.Size(1183, 531);
            this.taskView.TabIndex = 2;
            // 
            // taskSearch
            // 
            this.taskSearch.Location = new System.Drawing.Point(6, 47);
            this.taskSearch.Name = "taskSearch";
            this.taskSearch.Size = new System.Drawing.Size(235, 22);
            this.taskSearch.TabIndex = 1;
            this.taskSearch.TextChanged += new System.EventHandler(this.taskSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search by Case Reference:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.taskDesc);
            this.tabPage2.Controls.Add(this.taskCase);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1205, 640);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Rquest a Task ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "Request Task";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Task Description:";
            // 
            // taskDesc
            // 
            this.taskDesc.Location = new System.Drawing.Point(6, 114);
            this.taskDesc.Multiline = true;
            this.taskDesc.Name = "taskDesc";
            this.taskDesc.Size = new System.Drawing.Size(490, 160);
            this.taskDesc.TabIndex = 2;
            // 
            // taskCase
            // 
            this.taskCase.FormattingEnabled = true;
            this.taskCase.Location = new System.Drawing.Point(6, 50);
            this.taskCase.Name = "taskCase";
            this.taskCase.Size = new System.Drawing.Size(230, 24);
            this.taskCase.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Case Referance:";
            // 
            // ClientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 688);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClientHome";
            this.Text = "ClientHome";
            this.tabControl1.ResumeLayout(false);
            this.Cases.ResumeLayout(false);
            this.Cases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseView)).EndInit();
            this.Evidence.ResumeLayout(false);
            this.Evidence.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Cases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caseRefBox;
        private System.Windows.Forms.DataGridView caseView;
        private System.Windows.Forms.TabPage Evidence;
        private System.Windows.Forms.DataGridView FileView;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox evidenceFile;
        private System.Windows.Forms.ComboBox caseRefCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView taskView;
        private System.Windows.Forms.TextBox taskSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox taskDesc;
        private System.Windows.Forms.ComboBox taskCase;
        private System.Windows.Forms.Label label7;
    }
}