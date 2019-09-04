using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScaffoldDbContextHelper.Forms
{
    public partial class ProjectNamesForm : Form
    {
        /*
         * Project names from Open dialog from sending form
         */
        private readonly List<string> _projectNames;

        public ProjectNamesForm()
        {
            InitializeComponent();
        }

        public ProjectNamesForm(List<string> projectNames)
        {
            InitializeComponent();

            _projectNames = projectNames;

            Shown += ProjectNamesForm_Shown;
            listBox1.DoubleClick += ListBox1_DoubleClick;
        }

        private void ProjectNamesForm_Shown(object sender, EventArgs e)
        {
            listBox1.DataSource = _projectNames;
        }

        private string _projectName;
        public string ProjectName => _projectName;

        private void SelectButton_Click(object sender, EventArgs e)
        {
            _projectName = listBox1.Text;
            DialogResult = DialogResult.OK;
        }
        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            _projectName = listBox1.Text;
            DialogResult = DialogResult.OK;
        }

    }
}
