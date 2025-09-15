using CustomerSupportSystem.livechat;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLiveCall_Click(object sender, EventArgs e)
        {
            livechatt Chat = new livechatt();
            Chat.Show();
            //panelmain.Controls.Clear();

            //livechat.livechatt liveCallsPage = new livechat.livechatt();
            //liveCallsPage.TopLevel = false;
            //liveCallsPage.FormBorderStyle = FormBorderStyle.None;
            //liveCallsPage.Dock = DockStyle.Fill;

            //panelmain.Controls.Add(liveCallsPage);
            //liveCallsPage.Show();

        }

        
        private void btnLivechat_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Live Chat page will open here.");
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            using (FormTickets ticketsForm = new FormTickets())
            {
                ticketsForm.ShowDialog();
            }
        }
        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(40, 60, 80);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            FormSetting settingsForm = new FormSetting();
            settingsForm.ShowDialog(); 
        }
    }
}

