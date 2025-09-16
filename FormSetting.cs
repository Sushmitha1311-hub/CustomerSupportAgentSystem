using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSupportSystem
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            
            InitializeComponent();
            LoadData();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            cmbTheme.Items.Clear();
            cmbTheme.Items.Add("Light");
            cmbTheme.Items.Add("Dark");
            cmbTheme.Items.Add("System Default");

            
            cmbFontSize.Items.Clear();
            cmbFontSize.Items.Add("Small");
            cmbFontSize.Items.Add("Medium");
            cmbFontSize.Items.Add("Large");
            cmbFontSize.Items.Add("Extra Large");

            cmbTheme.SelectedIndex = 0;
            cmbFontSize.SelectedIndex = 1;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
          
            Properties.Settings.Default.NotifyCalls = chkIncomingCalls.Checked;
            Properties.Settings.Default.NotifyChats = chkNewChats.Checked;
            Properties.Settings.Default.NotifyTickets = chkNewTickets.Checked;

            Properties.Settings.Default.Save();

            MessageBox.Show("Settings saved successfully!");
        }
        private void LoadData()
        {
            cmbTheme.Items.Add("dark");
            cmbTheme.Items.Add("light");
            cmbTheme.Items.Add("system");
            cmbFontSize.Items.Add("small");
            cmbFontSize.Items.Add("medium");
            cmbFontSize.Items.Add("large");

        }

        private void cmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormSetting_Load(object sender, EventArgs e)
        {

        }
    }
}


