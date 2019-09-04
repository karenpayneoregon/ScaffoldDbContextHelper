namespace AccessScaffoldDbContextHelper
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
            this.TablesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SolutionFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SolutionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ScriptTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UseDatabaseNamesCheckBox = new System.Windows.Forms.CheckBox();
            this.VerboseCheckBox = new System.Windows.Forms.CheckBox();
            this.DataAnnotationsCheckBox = new System.Windows.Forms.CheckBox();
            this.ForceCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DatabaseNameTextBox = new AccessScaffoldDbContextHelper.Classes.CueTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StartupProjectTextBox = new AccessScaffoldDbContextHelper.Classes.CueTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DatabaseButton = new System.Windows.Forms.Button();
            this.TableNamesButton = new System.Windows.Forms.Button();
            this.GetDatabaseNamesButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CopyToClipboardButton = new System.Windows.Forms.Button();
            this.ModelFolderTextBox = new AccessScaffoldDbContextHelper.Classes.CueTextBox();
            this.ContextFolderTextBox = new AccessScaffoldDbContextHelper.Classes.CueTextBox();
            this.ContextNameTextBox = new AccessScaffoldDbContextHelper.Classes.CueTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablesCheckedListBox
            // 
            this.TablesCheckedListBox.CheckOnClick = true;
            this.TablesCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablesCheckedListBox.FormattingEnabled = true;
            this.TablesCheckedListBox.Location = new System.Drawing.Point(10, 29);
            this.TablesCheckedListBox.Name = "TablesCheckedListBox";
            this.TablesCheckedListBox.Size = new System.Drawing.Size(175, 420);
            this.TablesCheckedListBox.TabIndex = 2;
            // 
            // SolutionFileDialog1
            // 
            this.SolutionFileDialog1.Filter = "Visual Studio Solution|*.sln";
            // 
            // SolutionButton
            // 
            this.SolutionButton.FlatAppearance.BorderSize = 0;
            this.SolutionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SolutionButton.Location = new System.Drawing.Point(385, 176);
            this.SolutionButton.Name = "SolutionButton";
            this.SolutionButton.Size = new System.Drawing.Size(26, 23);
            this.SolutionButton.TabIndex = 37;
            this.SolutionButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(418, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Context name (optional)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.TableNamesButton);
            this.panel1.Controls.Add(this.GetDatabaseNamesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 49);
            this.panel1.TabIndex = 25;
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
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Location = new System.Drawing.Point(10, 476);
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Size = new System.Drawing.Size(714, 20);
            this.ScriptTextBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(418, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Context folder (optional)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(418, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Model Folder (optional)";
            // 
            // UseDatabaseNamesCheckBox
            // 
            this.UseDatabaseNamesCheckBox.AutoSize = true;
            this.UseDatabaseNamesCheckBox.Checked = true;
            this.UseDatabaseNamesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseDatabaseNamesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDatabaseNamesCheckBox.ForeColor = System.Drawing.Color.White;
            this.UseDatabaseNamesCheckBox.Location = new System.Drawing.Point(220, 110);
            this.UseDatabaseNamesCheckBox.Name = "UseDatabaseNamesCheckBox";
            this.UseDatabaseNamesCheckBox.Size = new System.Drawing.Size(160, 20);
            this.UseDatabaseNamesCheckBox.TabIndex = 43;
            this.UseDatabaseNamesCheckBox.Text = "-UseDatabaseNames";
            this.UseDatabaseNamesCheckBox.UseVisualStyleBackColor = true;
            // 
            // VerboseCheckBox
            // 
            this.VerboseCheckBox.AutoSize = true;
            this.VerboseCheckBox.Checked = true;
            this.VerboseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VerboseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerboseCheckBox.ForeColor = System.Drawing.Color.White;
            this.VerboseCheckBox.Location = new System.Drawing.Point(220, 84);
            this.VerboseCheckBox.Name = "VerboseCheckBox";
            this.VerboseCheckBox.Size = new System.Drawing.Size(83, 20);
            this.VerboseCheckBox.TabIndex = 42;
            this.VerboseCheckBox.Text = "-Verbose";
            this.VerboseCheckBox.UseVisualStyleBackColor = true;
            // 
            // DataAnnotationsCheckBox
            // 
            this.DataAnnotationsCheckBox.AutoSize = true;
            this.DataAnnotationsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAnnotationsCheckBox.ForeColor = System.Drawing.Color.White;
            this.DataAnnotationsCheckBox.Location = new System.Drawing.Point(220, 61);
            this.DataAnnotationsCheckBox.Name = "DataAnnotationsCheckBox";
            this.DataAnnotationsCheckBox.Size = new System.Drawing.Size(130, 20);
            this.DataAnnotationsCheckBox.TabIndex = 41;
            this.DataAnnotationsCheckBox.Text = "-DataAnnotations";
            this.DataAnnotationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ForceCheckBox
            // 
            this.ForceCheckBox.AutoSize = true;
            this.ForceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceCheckBox.ForeColor = System.Drawing.Color.White;
            this.ForceCheckBox.Location = new System.Drawing.Point(220, 38);
            this.ForceCheckBox.Name = "ForceCheckBox";
            this.ForceCheckBox.Size = new System.Drawing.Size(66, 20);
            this.ForceCheckBox.TabIndex = 40;
            this.ForceCheckBox.Text = "-Force";
            this.ForceCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(418, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Database name";
            // 
            // DatabaseNameTextBox
            // 
            this.DatabaseNameTextBox.CueBannerText = "Enter database name";
            this.DatabaseNameTextBox.Location = new System.Drawing.Point(220, 150);
            this.DatabaseNameTextBox.Name = "DatabaseNameTextBox";
            this.DatabaseNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.DatabaseNameTextBox.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(418, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Startup project (optional)";
            // 
            // StartupProjectTextBox
            // 
            this.StartupProjectTextBox.CueBannerText = "Name of existing project";
            this.StartupProjectTextBox.Location = new System.Drawing.Point(219, 179);
            this.StartupProjectTextBox.Name = "StartupProjectTextBox";
            this.StartupProjectTextBox.Size = new System.Drawing.Size(171, 20);
            this.StartupProjectTextBox.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AccessScaffoldDbContextHelper.Properties.Resources.OpenfileDialog_16x;
            this.button1.Location = new System.Drawing.Point(386, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.FlatAppearance.BorderSize = 0;
            this.DatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatabaseButton.Image = global::AccessScaffoldDbContextHelper.Properties.Resources.OpenfileDialog_16x;
            this.DatabaseButton.Location = new System.Drawing.Point(387, 147);
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Size = new System.Drawing.Size(26, 23);
            this.DatabaseButton.TabIndex = 45;
            this.DatabaseButton.UseVisualStyleBackColor = true;
            // 
            // TableNamesButton
            // 
            this.TableNamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNamesButton.Image = global::AccessScaffoldDbContextHelper.Properties.Resources.Table_16x;
            this.TableNamesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableNamesButton.Location = new System.Drawing.Point(243, 13);
            this.TableNamesButton.Name = "TableNamesButton";
            this.TableNamesButton.Size = new System.Drawing.Size(211, 23);
            this.TableNamesButton.TabIndex = 1;
            this.TableNamesButton.Text = "Get Table names";
            this.TableNamesButton.UseVisualStyleBackColor = true;
            // 
            // GetDatabaseNamesButton
            // 
            this.GetDatabaseNamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDatabaseNamesButton.Image = global::AccessScaffoldDbContextHelper.Properties.Resources.Refresh_16x;
            this.GetDatabaseNamesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GetDatabaseNamesButton.Location = new System.Drawing.Point(10, 14);
            this.GetDatabaseNamesButton.Name = "GetDatabaseNamesButton";
            this.GetDatabaseNamesButton.Size = new System.Drawing.Size(211, 23);
            this.GetDatabaseNamesButton.TabIndex = 0;
            this.GetDatabaseNamesButton.Text = "Refresh Databases names";
            this.GetDatabaseNamesButton.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Image = global::AccessScaffoldDbContextHelper.Properties.Resources.GenerateMethod_16x;
            this.GenerateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenerateButton.Location = new System.Drawing.Point(220, 309);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(189, 23);
            this.GenerateButton.TabIndex = 26;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.Image = global::AccessScaffoldDbContextHelper.Properties.Resources.Copy_16x;
            this.CopyToClipboardButton.Location = new System.Drawing.Point(730, 473);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(37, 23);
            this.CopyToClipboardButton.TabIndex = 32;
            this.CopyToClipboardButton.UseVisualStyleBackColor = true;
            // 
            // ModelFolderTextBox
            // 
            this.ModelFolderTextBox.CueBannerText = "Model folder";
            this.ModelFolderTextBox.Location = new System.Drawing.Point(220, 208);
            this.ModelFolderTextBox.Name = "ModelFolderTextBox";
            this.ModelFolderTextBox.Size = new System.Drawing.Size(189, 20);
            this.ModelFolderTextBox.TabIndex = 51;
            // 
            // ContextFolderTextBox
            // 
            this.ContextFolderTextBox.CueBannerText = "Context folder name";
            this.ContextFolderTextBox.Location = new System.Drawing.Point(219, 234);
            this.ContextFolderTextBox.Name = "ContextFolderTextBox";
            this.ContextFolderTextBox.Size = new System.Drawing.Size(189, 20);
            this.ContextFolderTextBox.TabIndex = 52;
            // 
            // ContextNameTextBox
            // 
            this.ContextNameTextBox.CueBannerText = "Context name";
            this.ContextNameTextBox.Location = new System.Drawing.Point(220, 260);
            this.ContextNameTextBox.Name = "ContextNameTextBox";
            this.ContextNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.ContextNameTextBox.TabIndex = 53;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(799, 560);
            this.Controls.Add(this.TablesCheckedListBox);
            this.Controls.Add(this.ContextNameTextBox);
            this.Controls.Add(this.ContextFolderTextBox);
            this.Controls.Add(this.ModelFolderTextBox);
            this.Controls.Add(this.StartupProjectTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatabaseNameTextBox);
            this.Controls.Add(this.DatabaseButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UseDatabaseNamesCheckBox);
            this.Controls.Add(this.VerboseCheckBox);
            this.Controls.Add(this.DataAnnotationsCheckBox);
            this.Controls.Add(this.ForceCheckBox);
            this.Controls.Add(this.SolutionButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CopyToClipboardButton);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MS-Access - Entity Framework Core Scaffold-DbContext helper - Windows Forms";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox TablesCheckedListBox;
        private System.Windows.Forms.OpenFileDialog SolutionFileDialog1;
        private System.Windows.Forms.Button SolutionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TableNamesButton;
        private System.Windows.Forms.Button GetDatabaseNamesButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button CopyToClipboardButton;
        private System.Windows.Forms.TextBox ScriptTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox UseDatabaseNamesCheckBox;
        private System.Windows.Forms.CheckBox VerboseCheckBox;
        private System.Windows.Forms.CheckBox DataAnnotationsCheckBox;
        private System.Windows.Forms.CheckBox ForceCheckBox;
        private System.Windows.Forms.Button DatabaseButton;
        private System.Windows.Forms.Label label6;
        private Classes.CueTextBox DatabaseNameTextBox;
        private System.Windows.Forms.Label label3;
        private Classes.CueTextBox StartupProjectTextBox;
        private System.Windows.Forms.Button button1;
        private Classes.CueTextBox ModelFolderTextBox;
        private Classes.CueTextBox ContextFolderTextBox;
        private Classes.CueTextBox ContextNameTextBox;
    }
}

