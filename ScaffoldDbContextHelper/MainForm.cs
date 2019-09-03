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
        /// Change server name to your server name.
        /// </summary>
        private readonly ScaffoldBuilder _scaffoldBuilder = new ScaffoldBuilder(".\\SQLEXPRESS"); 

        public MainForm()
        {
            InitializeComponent();

            Shown += Form1_Shown;

            ListBoxSearchTextBox.TextChanged += ListBoxSearchTextBox_TextChanged;

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
            var ops = new DatabaseInformation(_scaffoldBuilder.ServerName);

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
            var ops = new DatabaseInformation(_scaffoldBuilder.ServerName);
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

            var ops = new DatabaseInformation(_scaffoldBuilder.ServerName);

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

            if (DatabaseListBox.DataSource == null || TablesCheckedListBox.DataSource == null || TablesCheckedListBox.CheckedItems.Count <= 0 || string.IsNullOrWhiteSpace(StartupProjectTextBox.Text))
            {
                MessageBox.Show("Requires a database, one or more tables along with a startup folder!");
                return;
            } 

            ScriptTextBox.Text = "";

            var configuration = new ScaffoldConfigurationItem
            {
                DatabaseName = DatabaseListBox.Text,
                TableNames = TablesCheckedListBox.CheckedItems.Cast<string>(),
                ContextName = ContextNameTextBox.Text,
                ContextDirectory = ContextFolderTextBox.Text,
                FolderName = FolderTextBox.Text,
                StartupProject = StartupProjectTextBox.Text,
                Switches =
                {
                    Force = VerboseCheckBox.Checked,
                    Verbose = VerboseCheckBox.Checked,
                    UseDataAnnotations = DataAnnotationsCheckBox.Checked
                }
            };

            ScriptTextBox.Text = _scaffoldBuilder.Generate(configuration);

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

