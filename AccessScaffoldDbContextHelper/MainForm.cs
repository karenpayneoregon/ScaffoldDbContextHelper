using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessScaffoldDbContextHelper.Classes;
using AccessScaffoldDbContextHelper.Forms;
using CommonLibrary;
using static FormControlLibrary.KarenDialogs;

namespace AccessScaffoldDbContextHelper
{
    public partial class MainForm : Form
    {
        private ScaffoldBuilder _scaffoldBuilder = new ScaffoldBuilder("");
        public MainForm()
        {
            InitializeComponent();
            Shown += MainForm_Shown;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            DatabaseOpenFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            if (DatabaseOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                DatabaseNameTextBox.Text = DatabaseOpenFileDialog.FileName;
                var accessOps = new AccessDatabaseInformation();
                TablesCheckedListBox.DataSource = accessOps.TableNames(DatabaseOpenFileDialog.FileName);
                for (var index = 0; index < TablesCheckedListBox.Items.Count; index++)
                {
                    TablesCheckedListBox.SetItemCheckState(index, CheckState.Checked);
                }
            }
        }
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

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (TablesCheckedListBox.DataSource == null || TablesCheckedListBox.CheckedItems.Count <= 0 || string.IsNullOrWhiteSpace(StartupProjectTextBox.Text))
            {
                MessageBox.Show("Requires a database, one or more tables along with a startup folder!");
                return;
            }

            ScriptTextBox.Text = "";
            var configuration = new AccessScaffoldConfigurationItem
            {                     
                DatabaseName = DatabaseNameTextBox.Text,
                TableNames = TablesCheckedListBox.CheckedItems.Cast<string>(),
                ContextName = ContextNameTextBox.Text,
                ContextDirectory = ContextFolderTextBox.Text,
                FolderName = ModelFolderTextBox.Text,
                StartupProject = StartupProjectTextBox.Text,
                Provider = new DatabaseProvider() { Name = "MS-Access", Type = "EntityFrameworkCore.Jet" },
                Switches =
                {
                    Force = VerboseCheckBox.Checked,
                    Verbose = VerboseCheckBox.Checked,
                    UseDataAnnotations = DataAnnotationsCheckBox.Checked
                }
            };

            _scaffoldBuilder.DatabaseName = DatabaseNameTextBox.Text;
            ScriptTextBox.Text = _scaffoldBuilder.Generate(configuration);
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ScriptTextBox.Text)) return;

            if (Question("Copy command to Windows Clipboard?"))
            {
                Clipboard.SetText(ScriptTextBox.Text);
            }
        }
    }
}
