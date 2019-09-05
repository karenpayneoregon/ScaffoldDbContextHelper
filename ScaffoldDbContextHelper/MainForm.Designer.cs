using FormControlLibrary;

namespace ScaffoldDbContextHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DatabaseListBox = new System.Windows.Forms.ListBox();
            this.TablesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ForceCheckBox = new System.Windows.Forms.CheckBox();
            this.DataAnnotationsCheckBox = new System.Windows.Forms.CheckBox();
            this.VerboseCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScriptTextBox = new System.Windows.Forms.TextBox();
            this.UseDatabaseNamesCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SolutionFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProviderComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServerNameTextBox = new CueTextBox();
            this.ContextNameTextBox = new CueTextBox();
            this.ContextFolderTextBox = new CueTextBox();
            this.ModelFolderTextBox = new CueTextBox();
            this.StartupProjectTextBox = new CueTextBox();
            this.ListBoxSearchTextBox = new CueTextBox();
            this.ServerButton = new System.Windows.Forms.Button();
            this.SolutionButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CopyToClipboardButton = new System.Windows.Forms.Button();
            this.TableNamesButton = new System.Windows.Forms.Button();
            this.GetDatabaseNamesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.TableNamesButton);
            this.panel1.Controls.Add(this.GetDatabaseNamesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 49);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(561, 13);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(211, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DatabaseListBox
            // 
            this.DatabaseListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.DatabaseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseListBox.FormattingEnabled = true;
            this.DatabaseListBox.ItemHeight = 15;
            this.DatabaseListBox.Location = new System.Drawing.Point(0, 0);
            this.DatabaseListBox.Name = "DatabaseListBox";
            this.DatabaseListBox.Size = new System.Drawing.Size(215, 429);
            this.DatabaseListBox.TabIndex = 1;
            this.DatabaseListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DatabaseListBox_MouseDoubleClick);
            // 
            // TablesCheckedListBox
            // 
            this.TablesCheckedListBox.CheckOnClick = true;
            this.TablesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.TablesCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablesCheckedListBox.FormattingEnabled = true;
            this.TablesCheckedListBox.Location = new System.Drawing.Point(231, 0);
            this.TablesCheckedListBox.Name = "TablesCheckedListBox";
            this.TablesCheckedListBox.Size = new System.Drawing.Size(175, 429);
            this.TablesCheckedListBox.TabIndex = 2;
            // 
            // ForceCheckBox
            // 
            this.ForceCheckBox.AutoSize = true;
            this.ForceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceCheckBox.ForeColor = System.Drawing.Color.White;
            this.ForceCheckBox.Location = new System.Drawing.Point(424, 37);
            this.ForceCheckBox.Name = "ForceCheckBox";
            this.ForceCheckBox.Size = new System.Drawing.Size(66, 20);
            this.ForceCheckBox.TabIndex = 3;
            this.ForceCheckBox.Text = "-Force";
            this.ForceCheckBox.UseVisualStyleBackColor = true;
            // 
            // DataAnnotationsCheckBox
            // 
            this.DataAnnotationsCheckBox.AutoSize = true;
            this.DataAnnotationsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAnnotationsCheckBox.ForeColor = System.Drawing.Color.White;
            this.DataAnnotationsCheckBox.Location = new System.Drawing.Point(424, 60);
            this.DataAnnotationsCheckBox.Name = "DataAnnotationsCheckBox";
            this.DataAnnotationsCheckBox.Size = new System.Drawing.Size(130, 20);
            this.DataAnnotationsCheckBox.TabIndex = 4;
            this.DataAnnotationsCheckBox.Text = "-DataAnnotations";
            this.DataAnnotationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // VerboseCheckBox
            // 
            this.VerboseCheckBox.AutoSize = true;
            this.VerboseCheckBox.Checked = true;
            this.VerboseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VerboseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerboseCheckBox.ForeColor = System.Drawing.Color.White;
            this.VerboseCheckBox.Location = new System.Drawing.Point(424, 83);
            this.VerboseCheckBox.Name = "VerboseCheckBox";
            this.VerboseCheckBox.Size = new System.Drawing.Size(83, 20);
            this.VerboseCheckBox.TabIndex = 5;
            this.VerboseCheckBox.Text = "-Verbose";
            this.VerboseCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(620, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model Folder (optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(620, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Context folder (optional)";
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Location = new System.Drawing.Point(10, 479);
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Size = new System.Drawing.Size(714, 20);
            this.ScriptTextBox.TabIndex = 8;
            // 
            // UseDatabaseNamesCheckBox
            // 
            this.UseDatabaseNamesCheckBox.AutoSize = true;
            this.UseDatabaseNamesCheckBox.Checked = true;
            this.UseDatabaseNamesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseDatabaseNamesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDatabaseNamesCheckBox.ForeColor = System.Drawing.Color.White;
            this.UseDatabaseNamesCheckBox.Location = new System.Drawing.Point(424, 109);
            this.UseDatabaseNamesCheckBox.Name = "UseDatabaseNamesCheckBox";
            this.UseDatabaseNamesCheckBox.Size = new System.Drawing.Size(160, 20);
            this.UseDatabaseNamesCheckBox.TabIndex = 10;
            this.UseDatabaseNamesCheckBox.Text = "-UseDatabaseNames";
            this.UseDatabaseNamesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(620, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Startup project (optional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(620, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Context name (optional)";
            // 
            // SolutionFileDialog1
            // 
            this.SolutionFileDialog1.Filter = "Visual Studio Solution|*.sln";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DatabaseListBox);
            this.panel2.Controls.Add(this.TablesCheckedListBox);
            this.panel2.Location = new System.Drawing.Point(12, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 429);
            this.panel2.TabIndex = 19;
            // 
            // ProviderComboBox
            // 
            this.ProviderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProviderComboBox.FormattingEnabled = true;
            this.ProviderComboBox.Location = new System.Drawing.Point(424, 171);
            this.ProviderComboBox.Name = "ProviderComboBox";
            this.ProviderComboBox.Size = new System.Drawing.Size(190, 21);
            this.ProviderComboBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(620, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Database Provider";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(620, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Server name";
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.CueBannerText = "Server name";
            this.ServerNameTextBox.Location = new System.Drawing.Point(424, 145);
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.ServerNameTextBox.TabIndex = 22;
            // 
            // ContextNameTextBox
            // 
            this.ContextNameTextBox.CueBannerText = "Folder for DbContext";
            this.ContextNameTextBox.Location = new System.Drawing.Point(424, 279);
            this.ContextNameTextBox.Name = "ContextNameTextBox";
            this.ContextNameTextBox.Size = new System.Drawing.Size(190, 20);
            this.ContextNameTextBox.TabIndex = 16;
            this.ContextNameTextBox.Text = "Context name";
            // 
            // ContextFolderTextBox
            // 
            this.ContextFolderTextBox.CueBannerText = "Folder for DbContext";
            this.ContextFolderTextBox.Location = new System.Drawing.Point(424, 253);
            this.ContextFolderTextBox.Name = "ContextFolderTextBox";
            this.ContextFolderTextBox.Size = new System.Drawing.Size(190, 20);
            this.ContextFolderTextBox.TabIndex = 15;
            this.ContextFolderTextBox.Text = "Context";
            // 
            // ModelFolderTextBox
            // 
            this.ModelFolderTextBox.CueBannerText = "Folder for models";
            this.ModelFolderTextBox.Location = new System.Drawing.Point(424, 224);
            this.ModelFolderTextBox.Name = "ModelFolderTextBox";
            this.ModelFolderTextBox.Size = new System.Drawing.Size(190, 20);
            this.ModelFolderTextBox.TabIndex = 14;
            this.ModelFolderTextBox.Text = "Models";
            // 
            // StartupProjectTextBox
            // 
            this.StartupProjectTextBox.CueBannerText = "Name of existing project";
            this.StartupProjectTextBox.Location = new System.Drawing.Point(424, 198);
            this.StartupProjectTextBox.Name = "StartupProjectTextBox";
            this.StartupProjectTextBox.Size = new System.Drawing.Size(171, 20);
            this.StartupProjectTextBox.TabIndex = 13;
            // 
            // ListBoxSearchTextBox
            // 
            this.ListBoxSearchTextBox.CueBannerText = "Enter database name";
            this.ListBoxSearchTextBox.Location = new System.Drawing.Point(12, 7);
            this.ListBoxSearchTextBox.Name = "ListBoxSearchTextBox";
            this.ListBoxSearchTextBox.Size = new System.Drawing.Size(215, 20);
            this.ListBoxSearchTextBox.TabIndex = 0;
            // 
            // ServerButton
            // 
            this.ServerButton.FlatAppearance.BorderSize = 0;
            this.ServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServerButton.Image = global::ScaffoldDbContextHelper.Properties.Resources.OpenfileDialog_16x;
            this.ServerButton.Location = new System.Drawing.Point(590, 145);
            this.ServerButton.Name = "ServerButton";
            this.ServerButton.Size = new System.Drawing.Size(26, 23);
            this.ServerButton.TabIndex = 24;
            this.ServerButton.UseVisualStyleBackColor = true;
            this.ServerButton.Click += new System.EventHandler(this.ServerButton_Click);
            // 
            // SolutionButton
            // 
            this.SolutionButton.FlatAppearance.BorderSize = 0;
            this.SolutionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SolutionButton.Image = global::ScaffoldDbContextHelper.Properties.Resources.OpenfileDialog_16x;
            this.SolutionButton.Location = new System.Drawing.Point(590, 196);
            this.SolutionButton.Name = "SolutionButton";
            this.SolutionButton.Size = new System.Drawing.Size(26, 23);
            this.SolutionButton.TabIndex = 18;
            this.SolutionButton.UseVisualStyleBackColor = true;
            this.SolutionButton.Click += new System.EventHandler(this.SolutionButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Image = global::ScaffoldDbContextHelper.Properties.Resources.GenerateMethod_16x;
            this.GenerateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenerateButton.Location = new System.Drawing.Point(425, 314);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(189, 23);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.Image = global::ScaffoldDbContextHelper.Properties.Resources.Copy_16x;
            this.CopyToClipboardButton.Location = new System.Drawing.Point(730, 476);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(37, 23);
            this.CopyToClipboardButton.TabIndex = 9;
            this.CopyToClipboardButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // TableNamesButton
            // 
            this.TableNamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNamesButton.Image = global::ScaffoldDbContextHelper.Properties.Resources.Table_16x;
            this.TableNamesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableNamesButton.Location = new System.Drawing.Point(243, 13);
            this.TableNamesButton.Name = "TableNamesButton";
            this.TableNamesButton.Size = new System.Drawing.Size(211, 23);
            this.TableNamesButton.TabIndex = 1;
            this.TableNamesButton.Text = "Get Table names";
            this.TableNamesButton.UseVisualStyleBackColor = true;
            this.TableNamesButton.Click += new System.EventHandler(this.TableNamesButton_Click);
            // 
            // GetDatabaseNamesButton
            // 
            this.GetDatabaseNamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDatabaseNamesButton.Image = global::ScaffoldDbContextHelper.Properties.Resources.Refresh_16x;
            this.GetDatabaseNamesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GetDatabaseNamesButton.Location = new System.Drawing.Point(10, 14);
            this.GetDatabaseNamesButton.Name = "GetDatabaseNamesButton";
            this.GetDatabaseNamesButton.Size = new System.Drawing.Size(211, 23);
            this.GetDatabaseNamesButton.TabIndex = 0;
            this.GetDatabaseNamesButton.Text = "Refresh Databases names";
            this.GetDatabaseNamesButton.UseVisualStyleBackColor = true;
            this.GetDatabaseNamesButton.Click += new System.EventHandler(this.GetDatabaseNamesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(790, 560);
            this.Controls.Add(this.ServerButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ServerNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProviderComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SolutionButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ContextNameTextBox);
            this.Controls.Add(this.ContextFolderTextBox);
            this.Controls.Add(this.ModelFolderTextBox);
            this.Controls.Add(this.StartupProjectTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UseDatabaseNamesCheckBox);
            this.Controls.Add(this.ListBoxSearchTextBox);
            this.Controls.Add(this.CopyToClipboardButton);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerboseCheckBox);
            this.Controls.Add(this.DataAnnotationsCheckBox);
            this.Controls.Add(this.ForceCheckBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql-Server - Entity Framework Core Scaffold-DbContext helper - Windows Forms";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox DatabaseListBox;
        private System.Windows.Forms.Button GetDatabaseNamesButton;
        private System.Windows.Forms.Button TableNamesButton;
        private System.Windows.Forms.CheckedListBox TablesCheckedListBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox ForceCheckBox;
        private System.Windows.Forms.CheckBox DataAnnotationsCheckBox;
        private System.Windows.Forms.CheckBox VerboseCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ScriptTextBox;
        private System.Windows.Forms.Button CopyToClipboardButton;
        private CueTextBox ListBoxSearchTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox UseDatabaseNamesCheckBox;
        private System.Windows.Forms.Label label3;
        private CueTextBox StartupProjectTextBox;
        private CueTextBox ModelFolderTextBox;
        private CueTextBox ContextFolderTextBox;
        private CueTextBox ContextNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SolutionButton;
        private System.Windows.Forms.OpenFileDialog SolutionFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ProviderComboBox;
        private System.Windows.Forms.Label label5;
        private CueTextBox ServerNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ServerButton;
    }
}

