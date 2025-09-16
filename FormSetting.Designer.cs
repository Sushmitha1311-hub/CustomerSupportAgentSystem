namespace CustomerSupportSystem
{
    partial class FormSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSettings = new System.Windows.Forms.Label();
            this.grpProfilesetting = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.Notify = new System.Windows.Forms.GroupBox();
            this.chkNewTickets = new System.Windows.Forms.CheckBox();
            this.chkNewChats = new System.Windows.Forms.CheckBox();
            this.chkIncomingCalls = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFontSize = new System.Windows.Forms.ComboBox();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpProfilesetting.SuspendLayout();
            this.Notify.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(294, 18);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(99, 28);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "Settings";
            // 
            // grpProfilesetting
            // 
            this.grpProfilesetting.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpProfilesetting.Controls.Add(this.txtPassword);
            this.grpProfilesetting.Controls.Add(this.txtEmail);
            this.grpProfilesetting.Controls.Add(this.txtName);
            this.grpProfilesetting.Controls.Add(this.lblPassword);
            this.grpProfilesetting.Controls.Add(this.lblemail);
            this.grpProfilesetting.Controls.Add(this.lblName);
            this.grpProfilesetting.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProfilesetting.Location = new System.Drawing.Point(13, 58);
            this.grpProfilesetting.Name = "grpProfilesetting";
            this.grpProfilesetting.Size = new System.Drawing.Size(227, 149);
            this.grpProfilesetting.TabIndex = 1;
            this.grpProfilesetting.TabStop = false;
            this.grpProfilesetting.Text = "Profile Setting";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 114);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(123, 24);
            this.txtPassword.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 24);
            this.txtEmail.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 24);
            this.txtName.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(7, 77);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(49, 19);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // Notify
            // 
            this.Notify.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Notify.Controls.Add(this.chkNewTickets);
            this.Notify.Controls.Add(this.chkNewChats);
            this.Notify.Controls.Add(this.chkIncomingCalls);
            this.Notify.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notify.Location = new System.Drawing.Point(13, 257);
            this.Notify.Name = "Notify";
            this.Notify.Size = new System.Drawing.Size(226, 189);
            this.Notify.TabIndex = 2;
            this.Notify.TabStop = false;
            this.Notify.Text = "Notification";
            // 
            // chkNewTickets
            // 
            this.chkNewTickets.AutoSize = true;
            this.chkNewTickets.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewTickets.Location = new System.Drawing.Point(19, 119);
            this.chkNewTickets.Name = "chkNewTickets";
            this.chkNewTickets.Size = new System.Drawing.Size(102, 23);
            this.chkNewTickets.TabIndex = 5;
            this.chkNewTickets.Text = "New Ticket";
            this.chkNewTickets.UseVisualStyleBackColor = true;
            // 
            // chkNewChats
            // 
            this.chkNewChats.AutoSize = true;
            this.chkNewChats.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewChats.Location = new System.Drawing.Point(19, 80);
            this.chkNewChats.Name = "chkNewChats";
            this.chkNewChats.Size = new System.Drawing.Size(92, 23);
            this.chkNewChats.TabIndex = 4;
            this.chkNewChats.Text = "New Chat";
            this.chkNewChats.UseVisualStyleBackColor = true;
            // 
            // chkIncomingCalls
            // 
            this.chkIncomingCalls.AutoSize = true;
            this.chkIncomingCalls.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncomingCalls.Location = new System.Drawing.Point(19, 42);
            this.chkIncomingCalls.Name = "chkIncomingCalls";
            this.chkIncomingCalls.Size = new System.Drawing.Size(119, 23);
            this.chkIncomingCalls.TabIndex = 3;
            this.chkIncomingCalls.Text = "Incoming Call";
            this.chkIncomingCalls.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbFontSize);
            this.groupBox1.Controls.Add(this.cmbTheme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apperance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Font";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Theme";
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFontSize.FormattingEnabled = true;
            this.cmbFontSize.Location = new System.Drawing.Point(94, 108);
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(121, 27);
            this.cmbFontSize.TabIndex = 5;
            this.cmbFontSize.Text = "Select Font";
            this.cmbFontSize.SelectedIndexChanged += new System.EventHandler(this.cmbFontSize_SelectedIndexChanged);
            // 
            // cmbTheme
            // 
            this.cmbTheme.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Location = new System.Drawing.Point(99, 55);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(121, 27);
            this.cmbTheme.TabIndex = 4;
            this.cmbTheme.Text = "Select Theme";
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(330, 578);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(129, 35);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(485, 578);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 749);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Notify);
            this.Controls.Add(this.grpProfilesetting);
            this.Controls.Add(this.lblSettings);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.grpProfilesetting.ResumeLayout(false);
            this.grpProfilesetting.PerformLayout();
            this.Notify.ResumeLayout(false);
            this.Notify.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.GroupBox grpProfilesetting;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox Notify;
        private System.Windows.Forms.CheckBox chkNewTickets;
        private System.Windows.Forms.CheckBox chkNewChats;
        private System.Windows.Forms.CheckBox chkIncomingCalls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFontSize;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnCancel;
    }
}