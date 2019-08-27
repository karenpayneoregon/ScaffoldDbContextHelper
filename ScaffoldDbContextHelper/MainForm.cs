using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScaffoldDbContextHelper.Classes;
using static ScaffoldDbContextHelper.Classes.KarenDialogs;

namespace ScaffoldDbContextHelper
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Change to match your server e.g.
        /// localdb, sqlexpress etc.
        /// </summary>
        private string ServerName = "KARENS-PC";
        public MainForm()
        {
            InitializeComponent();
            Shown += Form1_Shown;
            ListBoxSearchTextBox.TextChanged += ListBoxSearchTextBox_TextChanged;

            // default for Karen Payne
            if (Environment.UserName == "Karens")
            {
                StartupProjectTextBox.Text = "NorthWind.Data";
            }

            /*
             * The alternate is to set the following as an argument
             * to arguments for Tools item for the app $(SolutionDir)
             */
            SolutionFileDialog1.InitialDirectory = AppDomain.CurrentDomain
                .BaseDirectory.CurrentSolutionFolder();

        }

        /// <summary>
        /// Find text/database starting on second character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = ListBoxSearchTextBox.Text;
            for (var index = 0; index <= DatabaseListBox.Items.Count - 1; index++)
            {
                if (!DatabaseListBox.Items[index].ToString().ToLower().Contains(searchText)) continue;

                DatabaseListBox.SetSelected(index, true);

                break;

            }
        }
        /// <summary>
        /// Get databases from ServerName form level variable above
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            var ops = new DatabaseInformation(ServerName);

            var result = ops.DatabaseNames();

            if (ops.IsSuccessFul)
            {
                DatabaseListBox.DataSource = result;
            }
            else
            {
                MessageBox.Show($"Error: {ops.LastExceptionMessage}");
            }
        }
        private void GetDatabaseNamesButton_Click(object sender, EventArgs e)
        {
            var ops = new DatabaseInformation(ServerName);
            var result = ops.DatabaseNames();

            if (ops.IsSuccessFul)
            {
                DatabaseListBox.DataSource = result;
            }
            else
            {
                MessageBox.Show($"Error: {ops.LastExceptionMessage}");
            }
        }
        private void TableNamesButton_Click(object sender, EventArgs e)
        {
            GetTablesForSelectedDatabase();
        }
        /// <summary>
        /// Populate CheckedListBox with table names from the selected database
        /// </summary>
        private void GetTablesForSelectedDatabase()
        {
            if (DatabaseListBox.DataSource == null) return;

            var ops = new DatabaseInformation(ServerName);

            ContextNameTextBox.Text = $"{DatabaseListBox.Text}Context";

            var tableNames = ops.TableNames(DatabaseListBox.Text);

            if (ops.IsSuccessFul == false)
            {
                MessageBox.Show($"Error getting tables\n{ops.LastExceptionMessage}");
                return;
            }

            TablesCheckedListBox.DataSource = tableNames;

            for (var index = 0; index < TablesCheckedListBox.Items.Count; index++)
            {
                TablesCheckedListBox.SetItemCheckState(index, CheckState.Checked);
            }
        }
        private void DatabaseListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GetTablesForSelectedDatabase();
        }
        /// <summary>
        /// Create Scaffold script
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (DatabaseListBox.DataSource == null) return;
            if (TablesCheckedListBox.DataSource == null) return;

            if (TablesCheckedListBox.CheckedItems.Count <= 0) return;
            var items = string.Join("", TablesCheckedListBox
                    .CheckedItems
                    .Cast<string>()
                    .Select(tb => $"\"{tb}\",").ToArray())
                .TrimEnd(',');

            var script = "";
            
            if (string.IsNullOrWhiteSpace(FolderTextBox.Text))
            {
                script = $"Scaffold-DbContext \"Server={ServerName}; " +
                         $"Database={DatabaseListBox.Text};" +
                          "Trusted_Connection=True;\" -Provider Microsoft.EntityFrameworkCore.SqlServer" ;
            }
            else
            {
                var folderName = "";
                folderName = FolderTextBox.Text.Contains(" ") ? $"\"{FolderTextBox.Text}\"" : FolderTextBox.Text;

                script = $"Scaffold-DbContext \"Server={ServerName};Database={DatabaseListBox.Text};" +
                         $"Trusted_Connection=True;\" -Provider Microsoft.EntityFrameworkCore.SqlServer " +
                         $"-OutputDir {folderName}";
            }

            if (!string.IsNullOrWhiteSpace(ContextNameTextBox.Text))
            {
                script += $" -Context {ContextNameTextBox.Text} ";
            }

            if (VerboseCheckBox.Checked)
            {
                script = script + " -v";
            }

            if (ForceCheckBox.Checked)
            {
                script += " -f ";
            }

            if (DataAnnotationsCheckBox.Checked)
            {
                script += " -DataAnnotations ";
            }

            if (UseDatabaseNamesCheckBox.Checked)
            {
                script += " -UseDatabaseNames ";
            }

            if (!string.IsNullOrWhiteSpace(StartupProjectTextBox.Text))
            {
                script += $" -startupproject {StartupProjectTextBox.Text}";
            }

            if (!string.IsNullOrWhiteSpace(ContextFolderTextBox.Text))
            {
                script += $" -ContextDir {ContextFolderTextBox.Text}";
            }
           
            script += " -t "; // parameter for adding tables to the script
            script += items;

            ScriptTextBox.Text = script;

        }
        /// <summary>
        /// Copy Scaffold script to windows clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ScriptTextBox.Text)) return;

            if (Question("Copy command to Windows Clipboard?"))
            {
                Clipboard.SetText(ScriptTextBox.Text);
            }

        }
        /// <summary>
        /// Get base project names for a selected solution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SolutionButton_Click(object sender, EventArgs e)
        {
            if (SolutionFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var ops = new SolutionHelper();
                var results = ops.ProjectNames(SolutionFileDialog1.FileName);

                if (ops.IsSuccessFul)
                {
                    var f = new ProjectNamesForm(results);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        StartupProjectTextBox.Text = f.ProjectName;
                    }
                }
                else
                {
                    MessageBox.Show(ops.LastExceptionMessage);
                }

            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
