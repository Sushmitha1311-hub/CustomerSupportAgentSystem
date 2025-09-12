namespace ChatDashboard
{
    partial class Chat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxChats;
        private System.Windows.Forms.FlowLayoutPanel flowChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Panel panelCustomerInfo;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerEmail;
        private System.Windows.Forms.Label labelCustomerPhone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.listBoxChats = new System.Windows.Forms.ListBox();
            this.flowChat = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.panelCustomerInfo = new System.Windows.Forms.Panel();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCustomerEmail = new System.Windows.Forms.Label();
            this.labelCustomerPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxChats
            // 
            this.listBoxChats.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxChats.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxChats.FormattingEnabled = true;
            this.listBoxChats.ItemHeight = 20;
            this.listBoxChats.Location = new System.Drawing.Point(12, 42);
            this.listBoxChats.Name = "listBoxChats";
            this.listBoxChats.Size = new System.Drawing.Size(150, 304);
            this.listBoxChats.TabIndex = 0;
            this.listBoxChats.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxChats_DrawItem);
            this.listBoxChats.SelectedIndexChanged += new System.EventHandler(this.listBoxChats_SelectedIndexChanged);
            // 
            // flowChat
            // 
            this.flowChat.AutoScroll = true;
            this.flowChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowChat.Location = new System.Drawing.Point(574, 139);
            this.flowChat.Name = "flowChat";
            this.flowChat.Size = new System.Drawing.Size(206, 307);
            this.flowChat.TabIndex = 1;
            this.flowChat.WrapContents = false;
            this.flowChat.Paint += new System.Windows.Forms.PaintEventHandler(this.flowChat_Paint);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 360);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(451, 40);
            this.txtMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(469, 360);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 40);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(469, 406);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(90, 40);
            this.btnAttach.TabIndex = 4;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 16;
            this.listBoxHistory.Location = new System.Drawing.Point(168, 47);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(400, 308);
            this.listBoxHistory.TabIndex = 5;
            // 
            // panelCustomerInfo
            // 
            this.panelCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(193)))));
            this.panelCustomerInfo.Controls.Add(this.pictureBoxCustomer);
            this.panelCustomerInfo.Controls.Add(this.labelCustomerName);
            this.panelCustomerInfo.Controls.Add(this.labelCustomerEmail);
            this.panelCustomerInfo.Controls.Add(this.labelCustomerPhone);
            this.panelCustomerInfo.Location = new System.Drawing.Point(574, 53);
            this.panelCustomerInfo.Name = "panelCustomerInfo";
            this.panelCustomerInfo.Size = new System.Drawing.Size(206, 80);
            this.panelCustomerInfo.TabIndex = 6;
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.Image = null; // or assign a default image from resources explicitly
            this.pictureBoxCustomer.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCustomer.TabIndex = 0;
            this.pictureBoxCustomer.TabStop = false;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelCustomerName.Location = new System.Drawing.Point(60, 5);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(57, 23);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Name";
            // 
            // labelCustomerEmail
            // 
            this.labelCustomerEmail.AutoSize = true;
            this.labelCustomerEmail.Location = new System.Drawing.Point(61, 28);
            this.labelCustomerEmail.Name = "labelCustomerEmail";
            this.labelCustomerEmail.Size = new System.Drawing.Size(41, 16);
            this.labelCustomerEmail.TabIndex = 2;
            this.labelCustomerEmail.Text = "Email";
            // 
            // labelCustomerPhone
            // 
            this.labelCustomerPhone.AutoSize = true;
            this.labelCustomerPhone.Location = new System.Drawing.Point(60, 48);
            this.labelCustomerPhone.Name = "labelCustomerPhone";
            this.labelCustomerPhone.Size = new System.Drawing.Size(46, 16);
            this.labelCustomerPhone.TabIndex = 3;
            this.labelCustomerPhone.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(604, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer Info";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(791, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.panelCustomerInfo);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.flowChat);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.listBoxChats);
            this.Name = "Form1";
            this.Text = "Chat Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCustomerInfo.ResumeLayout(false);
            this.panelCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
