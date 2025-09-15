namespace CustomerSupportSystem.Tarun
{
    partial class LoginForm
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labLogin = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLeft.Controls.Add(this.pictureLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(347, 534);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::CustomerSupportSystem.Properties.Resources.customer_1688401;
            this.pictureLogo.Location = new System.Drawing.Point(49, 23);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(200, 200);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.labLogin.Location = new System.Drawing.Point(482, 23);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(112, 48);
            this.labLogin.TabIndex = 1;
            this.labLogin.Text = "Login";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmail.Location = new System.Drawing.Point(400, 127);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(136, 32);
            this.labEmail.TabIndex = 2;
            this.labEmail.Text = "Your email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(406, 176);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 38);
            this.txtEmail.TabIndex = 3;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(400, 236);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(183, 32);
            this.labPassword.TabIndex = 4;
            this.labPassword.Text = "Your password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(406, 287);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(298, 38);
            this.txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(515, 419);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 50);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 534);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labLogin);
            this.Controls.Add(this.panelLeft);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}