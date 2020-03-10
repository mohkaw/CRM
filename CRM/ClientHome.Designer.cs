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
            this.label1 = new System.Windows.Forms.Label();
            this.caseRefBox = new System.Windows.Forms.TextBox();
            this.caseView = new System.Windows.Forms.DataGridView();
            this.Evidence = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.FileView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Cases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cases);
            this.tabControl1.Controls.Add(this.Evidence);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1213, 669);
            this.tabControl1.TabIndex = 0;
            // 
            // Cases
            // 
            this.Cases.BackColor = System.Drawing.SystemColors.Control;
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
            this.caseView.Location = new System.Drawing.Point(9, 62);
            this.caseView.Name = "caseView";
            this.caseView.ReadOnly = true;
            this.caseView.RowHeadersVisible = false;
            this.caseView.RowHeadersWidth = 51;
            this.caseView.RowTemplate.Height = 24;
            this.caseView.Size = new System.Drawing.Size(184, 572);
            this.caseView.TabIndex = 0;
            // 
            // Evidence
            // 
            this.Evidence.BackColor = System.Drawing.SystemColors.Control;
            this.Evidence.Location = new System.Drawing.Point(4, 25);
            this.Evidence.Name = "Evidence";
            this.Evidence.Padding = new System.Windows.Forms.Padding(3);
            this.Evidence.Size = new System.Drawing.Size(1205, 640);
            this.Evidence.TabIndex = 1;
            this.Evidence.Text = "Evidence";
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
            // FileBox
            // 
            this.FileBox.Location = new System.Drawing.Point(199, 34);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(184, 22);
            this.FileBox.TabIndex = 4;
            // 
            // FileView
            // 
            this.FileView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.FileView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileView.Location = new System.Drawing.Point(199, 62);
            this.FileView.Name = "FileView";
            this.FileView.ReadOnly = true;
            this.FileView.RowHeadersWidth = 51;
            this.FileView.RowTemplate.Height = 24;
            this.FileView.Size = new System.Drawing.Size(184, 572);
            this.FileView.TabIndex = 5;
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
            ((System.ComponentModel.ISupportInitialize)(this.caseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileView)).EndInit();
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
    }
}