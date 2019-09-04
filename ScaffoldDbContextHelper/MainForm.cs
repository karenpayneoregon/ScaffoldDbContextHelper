using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary;
using Newtonsoft.Json;
using ScaffoldDbContextHelper.Classes;
using ScaffoldDbContextHelper.Forms;
using static ScaffoldDbContextHelper.Classes.KarenDialogs;

namespace ScaffoldDbContextHelper
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Change server name to your server name.
        /// </summary>
        private ScaffoldBuilder _scaffoldBuilder = new ScaffoldBuilder(".\\SQLEXPRESS");
        private string _applicationSettingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppSettings.json");

        public MainForm()
        {
            InitializeComponent();
            Shown += Form1_Shown;

            ListBoxSearchTextBox.TextChanged += ListBoxSearchTextBox_TextChanged;
            SolutionFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.CurrentSolutionFolder();
            ServerNameTextBox.Text = _scaffoldBuilder.ServerName;

            ReadApplicationSettingsFile();
        }
        /// <summary>
        /// Read setting from application setting json file (decided not to do StartupProject)
        /// </summary>
        private void ReadApplicationSettingsFile()
        {
            using (var file = File.OpenText(_applicationSettingsFile))
            {
                var serializer = new JsonSerializer();
                var applicationSettings = (ApplicationSettings)serializer.Deserialize(file, typeof(ApplicationSettings));

                if (!string.IsNullOrWhiteSpace(applicationSettings.LastServerName))
                {
                    ServerNameTextBox.Text = applicationSettings.LastServerName;
                }

                var dataProvider = new DatabaseProviders();
                ProviderComboBox.DataSource = dataProvider.List;

                if (!string.IsNullOrWhiteSpace(applicationSettings.DataProvider))
                {
                    if (ProviderComboBox.DataSource != null)
                    {
                        var index = ProviderComboBox.FindString(applicationSettings.DataProvider);
                        if (index > -1)
                        {
                            ProviderComboBox.SelectedIndex = index;
                        }
                    }
                }
                _scaffoldBuilder = new ScaffoldBuilder(applicationSettings.LastServerName);

            }
        }
        /// <summary>
        /// Update application json file
        /// </summary>
        private void SaveApplicationSettings()
        {
            
            var applicationSettings = new ApplicationSettings()
            {
                LastServerName = ServerNameTextBox.Text,
                StartupProject = StartupProjectTextBox.Text
            };

            ProviderComboBox.Invoke(new Action(() => applicationSettings.DataProvider = ProviderComboBox.Text));

            using (var file = File.CreateText(_applicationSettingsFile))
            {
                var serializer = new JsonSerializer { Formatting = Formatting.Indented };
                serializer.Serialize(file, applicationSettings);
            }
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
        private void Form1_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_scaffoldBuilder.ServerName))
            {
                var ops = new SqlServerDatabaseInformation(_scaffoldBuilder.ServerName);

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

        }
        private void GetDatabaseNamesButton_Click(object sender, EventArgs e)
        {
            if (ProviderComboBox.DataSource == null)
            {
                var dataProvider = new DatabaseProviders();
                ProviderComboBox.DataSource = dataProvider.List;
            }

            if (!string.IsNullOrWhiteSpace(ServerNameTextBox.Text))
            {
                _scaffoldBuilder.ServerName = ServerNameTextBox.Text;
            }

            var ops = new SqlServerDatabaseInformation(_scaffoldBuilder.ServerName);
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
        private void GetTablesForSelectedDatabase()
        {
            if (DatabaseListBox.DataSource == null) return;

            if (!string.IsNullOrWhiteSpace(ServerNameTextBox.Text))
            {
                _scaffoldBuilder.ServerName = ServerNameTextBox.Text;
            }

            var ops = new SqlServerDatabaseInformation(_scaffoldBuilder.ServerName);

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
            var configuration = new SqlServerScaffoldConfigurationItem
            {
                DatabaseName = DatabaseListBox.Text,
                Provider = (DatabaseProvider)ProviderComboBox.SelectedItem,
                TableNames = TablesCheckedListBox.CheckedItems.Cast<string>(),
                ContextName = ContextNameTextBox.Text,
                ContextDirectory = ContextFolderTextBox.Text,
                FolderName = ModelFolderTextBox.Text,
                StartupProject = StartupProjectTextBox.Text,
                Switches =
                {
                    Force = VerboseCheckBox.Checked,
                    Verbose = VerboseCheckBox.Checked,
                    UseDataAnnotations = DataAnnotationsCheckBox.Checked
                }
            };

            if (!string.IsNullOrWhiteSpace(ServerNameTextBox.Text))
            {
                _scaffoldBuilder.ServerName = ServerNameTextBox.Text;
            }

            ScriptTextBox.Text = _scaffoldBuilder.Generate(configuration);
            SaveApplicationSettings();
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
        private async void ServerButton_Click(object sender, EventArgs e)
        {
            var ops = new SqlServerUtilities();
            var serverDataTable = await ops.SqlServerInstances().ConfigureAwait(false);
            var serverNameList = serverDataTable.AsEnumerable()
                .Where(row => !string.IsNullOrWhiteSpace(row.Field<string>("InstanceName")))
                .Select(row => row.Field<string>("InstanceName")).ToList();

            var serverForm = new ServersForm(serverNameList);
            if (serverForm.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(serverForm.ServerName))
                {
                    return;
                }

                ServerNameTextBox.Invoke(serverForm.ServerName == "SQLEXPRESS"
                    ? new Action(() => ServerNameTextBox.Text = $@".\{serverForm.ServerName}")
                    : new Action(() => ServerNameTextBox.Text = $"{serverForm.ServerName}"));
                SaveApplicationSettings();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

