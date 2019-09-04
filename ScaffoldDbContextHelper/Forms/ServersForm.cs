using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaffoldDbContextHelper.Forms
{
    public partial class ServersForm : Form
    {
        private List<string> _serverNameList;
        private string _serverName;
        public string ServerName => _serverName;

        public ServersForm()
        {
            InitializeComponent();
        }

        public ServersForm(List<string> pServers)
        {
            InitializeComponent();
            _serverNameList = pServers;

            Shown += ServersForm_Shown;
            listBox1.DoubleClick += ListBox1_DoubleClick;
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            _serverName = listBox1.Text;
            DialogResult = DialogResult.OK;
        }

        private void ServersForm_Shown(object sender, EventArgs e)
        {
            listBox1.DataSource = _serverNameList;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >0)
            {
                _serverName = listBox1.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Abort;
            }
            ;
        }
    }
}
