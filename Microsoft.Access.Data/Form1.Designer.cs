namespace Microsoft.Access.Data
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.CustomerNameStartsWithTextBox = new System.Windows.Forms.TextBox();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerIdentifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryIdentifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Controls.Add(this.CustomerNameStartsWithTextBox);
            this.panel1.Controls.Add(this.CountryComboBox);
            this.panel1.Controls.Add(this.CurrentButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 116);
            this.panel1.TabIndex = 0;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Image = global::Microsoft.Access.Data.Properties.Resources.Search_16x;
            this.ExecuteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExecuteButton.Location = new System.Drawing.Point(175, 53);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ExecuteButton.Size = new System.Drawing.Size(138, 51);
            this.ExecuteButton.TabIndex = 3;
            this.ExecuteButton.Text = "Find";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // CustomerNameStartsWithTextBox
            // 
            this.CustomerNameStartsWithTextBox.Location = new System.Drawing.Point(12, 84);
            this.CustomerNameStartsWithTextBox.Name = "CustomerNameStartsWithTextBox";
            this.CustomerNameStartsWithTextBox.Size = new System.Drawing.Size(157, 20);
            this.CustomerNameStartsWithTextBox.TabIndex = 2;
            this.CustomerNameStartsWithTextBox.Text = "La";
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Location = new System.Drawing.Point(12, 53);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(157, 21);
            this.CountryComboBox.TabIndex = 1;
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(12, 12);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(136, 23);
            this.CurrentButton.TabIndex = 0;
            this.CurrentButton.Text = "Current details";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerIdentifierColumn,
            this.CustomerNameColumn,
            this.CountryIdentifierColumn,
            this.CountryColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 334);
            this.dataGridView1.TabIndex = 1;
            // 
            // CustomerIdentifierColumn
            // 
            this.CustomerIdentifierColumn.DataPropertyName = "CustomerIdentifier";
            this.CustomerIdentifierColumn.HeaderText = "ID";
            this.CustomerIdentifierColumn.Name = "CustomerIdentifierColumn";
            this.CustomerIdentifierColumn.Visible = false;
            // 
            // CustomerNameColumn
            // 
            this.CustomerNameColumn.DataPropertyName = "CustomerName";
            this.CustomerNameColumn.HeaderText = "Customer";
            this.CustomerNameColumn.Name = "CustomerNameColumn";
            // 
            // CountryIdentifierColumn
            // 
            this.CountryIdentifierColumn.DataPropertyName = "CountryIdentifier";
            this.CountryIdentifierColumn.HeaderText = "CountryId";
            this.CountryIdentifierColumn.Name = "CountryIdentifierColumn";
            this.CountryIdentifierColumn.Visible = false;
            // 
            // CountryColumn
            // 
            this.CountryColumn.DataPropertyName = "Country";
            this.CountryColumn.HeaderText = "Country";
            this.CountryColumn.Name = "CountryColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EF Core - MS-Access";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerIdentifierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryIdentifierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryColumn;
        private System.Windows.Forms.Button CurrentButton;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox CustomerNameStartsWithTextBox;
    }
}

