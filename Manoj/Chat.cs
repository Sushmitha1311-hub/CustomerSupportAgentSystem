using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ChatDashboard
{
    public partial class Chat : Form
    {
        private Dictionary<string, List<ChatInfo>> chatHistory = new Dictionary<string, List<ChatInfo>>();
        private string selectedChat = "";

        public Chat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sample customers
            listBoxChats.Items.Add("John Doe");
            listBoxChats.Items.Add("Jane Smith");

            labelCustomerName.Text = "Select a chat";
            labelCustomerEmail.Text = "";
            labelCustomerPhone.Text = "";

            pictureBoxCustomer.Image = GeneratePlaceholderImage(50, Color.LightGray);
            pictureBoxCustomer.SizeMode = PictureBoxSizeMode.Zoom;

            // Button colors
            btnSend.BackColor = Color.FromArgb(135, 206, 250);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.ForeColor = Color.White;

            btnAttach.BackColor = Color.FromArgb(255, 182, 193);
            btnAttach.FlatStyle = FlatStyle.Flat;
            btnAttach.FlatAppearance.BorderSize = 0;
            btnAttach.ForeColor = Color.White;

            listBoxChats.DrawMode = DrawMode.OwnerDrawFixed;
        }

        private void listBoxChats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxChats.SelectedItem == null) return;

            selectedChat = listBoxChats.SelectedItem.ToString();

            // Highlight selected customer
            listBoxChats.Invalidate();

            // Update customer info
            labelCustomerName.Text = selectedChat;
            labelCustomerEmail.Text = selectedChat.Replace(" ", "").ToLower() + "@example.com";
            labelCustomerPhone.Text = "+1-555-1234";
            pictureBoxCustomer.Image = GeneratePlaceholderImage(50, Color.LightBlue);

            // Clear previous chat panel
            flowChat.Controls.Clear();

            if (!chatHistory.ContainsKey(selectedChat))
                chatHistory[selectedChat] = new List<ChatInfo>();

            foreach (ChatInfo chat in chatHistory[selectedChat])
                AddMessageBubble(chat);

            // Scroll to last message
            if (flowChat.Controls.Count > 0)
                flowChat.ScrollControlIntoView(flowChat.Controls[flowChat.Controls.Count - 1]);

            // Update right-hand history
            listBoxHistory.Items.Clear();
            foreach (ChatInfo chat in chatHistory[selectedChat])
                listBoxHistory.Items.Add(chat.Timestamp.ToString("MMM dd HH:mm") + " - " + chat.Message);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text) || selectedChat == "") return;

            ChatInfo chat = new ChatInfo("Me", txtMessage.Text, DateTime.Now, true);
            chatHistory[selectedChat].Add(chat);

            AddMessageBubble(chat);
            listBoxHistory.Items.Add(chat.Timestamp.ToString("MMM dd HH:mm") + " - " + chat.Message);
            txtMessage.Clear();

            flowChat.ScrollControlIntoView(flowChat.Controls[flowChat.Controls.Count - 1]);
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (selectedChat == "") return;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.png;*.gif";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Image attachment = Image.FromFile(dlg.FileName);
                ChatInfo chat = new ChatInfo("Me", "[Attachment]", DateTime.Now, true, attachment);
                chatHistory[selectedChat].Add(chat);

                AddMessageBubble(chat);
                listBoxHistory.Items.Add(chat.Timestamp.ToString("MMM dd HH:mm") + " - " + chat.Message);

                flowChat.ScrollControlIntoView(flowChat.Controls[flowChat.Controls.Count - 1]);
            }
        }

        private void AddMessageBubble(ChatInfo chat)
        {
            Panel panel = new Panel();
            panel.AutoSize = true;
            panel.Padding = new Padding(10);
            panel.Margin = new Padding(5);
            panel.MaximumSize = new Size(flowChat.Width - 20, 0);

            // Bubble color & rounded corners
            panel.BackColor = chat.IsSelf ? Color.FromArgb(135, 206, 250) : Color.FromArgb(220, 220, 220);
            panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 15, 15));

            if (chat.Attachment != null)
            {
                PictureBox pic = new PictureBox();
                pic.Image = chat.Attachment;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Width = 150;
                pic.Height = 100;
                panel.Controls.Add(pic);
            }

            Label lblMessage = new Label();
            lblMessage.Text = chat.Message;
            lblMessage.AutoSize = true;
            lblMessage.MaximumSize = new Size(flowChat.Width - 30, 0);
            lblMessage.Font = new Font("Segoe UI", 10);
            lblMessage.ForeColor = Color.Black;
            lblMessage.Padding = new Padding(3);
            panel.Controls.Add(lblMessage);

            Label lblTime = new Label();
            lblTime.Text = chat.Timestamp.ToString("HH:mm");
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 8, FontStyle.Italic);
            lblTime.ForeColor = Color.DarkGray;
            panel.Controls.Add(lblTime);

            FlowLayoutPanel wrapper = new FlowLayoutPanel();
            wrapper.Dock = DockStyle.Top;
            wrapper.AutoSize = true;
            wrapper.FlowDirection = chat.IsSelf ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
            wrapper.Controls.Add(panel);

            flowChat.Controls.Add(wrapper);
        }

        private void listBoxChats_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index < 0) return;

            string name = listBoxChats.Items[e.Index].ToString();
            Brush brush = new SolidBrush(Color.Black);

            // Highlight selected
            if (listBoxChats.SelectedIndex == e.Index)
                brush = new SolidBrush(Color.DarkBlue);

            e.Graphics.DrawString(name, e.Font, brush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private Image GeneratePlaceholderImage(int size, Color color)
        {
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillEllipse(brush, 0, 0, size - 1, size - 1);
                }
            }
            return bmp;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void flowChat_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
