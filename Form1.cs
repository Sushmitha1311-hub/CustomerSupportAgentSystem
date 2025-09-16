
﻿using ChatDashboard;
﻿using CustomerSupportSystem.livechat;
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

           


        }

        
        private void btnLivechat_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();

            Chat chatPage = new Chat();
            chatPage.TopLevel = false;
            chatPage.FormBorderStyle = FormBorderStyle.None;
            chatPage.Dock = DockStyle.Fill;

            panelmain.Controls.Add(chatPage);
            chatPage.Show();


        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();

            FormTickets ticketPage = new FormTickets();
            ticketPage.TopLevel = false;
            ticketPage.FormBorderStyle = FormBorderStyle.None;
            ticketPage.Dock = DockStyle.Fill;

            panelmain.Controls.Add(ticketPage);
            ticketPage.Show();

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

            panelmain.Controls.Clear();

            FormSetting settingsPage = new FormSetting();
            settingsPage.TopLevel = false;
            settingsPage.FormBorderStyle = FormBorderStyle.None;
            settingsPage.Dock = DockStyle.Fill;

            panelmain.Controls.Add(settingsPage);
            settingsPage.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            Form1 dashboardPage = new Form1();
            dashboardPage.TopLevel = false;
            dashboardPage.FormBorderStyle = FormBorderStyle.None;
            dashboardPage.Dock = DockStyle.Fill;
            panelmain.Controls.Add(dashboardPage);
            dashboardPage.Show();
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}


