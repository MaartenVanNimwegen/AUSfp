
namespace AUSfp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginBg = new System.Windows.Forms.PictureBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBg)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBg
            // 
            this.LoginBg.Image = ((System.Drawing.Image)(resources.GetObject("LoginBg.Image")));
            this.LoginBg.InitialImage = ((System.Drawing.Image)(resources.GetObject("LoginBg.InitialImage")));
            this.LoginBg.Location = new System.Drawing.Point(-15, -49);
            this.LoginBg.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBg.Name = "LoginBg";
            this.LoginBg.Size = new System.Drawing.Size(555, 604);
            this.LoginBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginBg.TabIndex = 0;
            this.LoginBg.TabStop = false;
            // 
            // usernameInput
            // 
            this.usernameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(614, 218);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(2);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(160, 24);
            this.usernameInput.TabIndex = 2;
            this.usernameInput.Text = "Gebruikersnaam";
            this.usernameInput.Click += new System.EventHandler(this.usernameInput_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login:";
            // 
            // passwordInput
            // 
            this.passwordInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(614, 246);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(2);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(160, 24);
            this.passwordInput.TabIndex = 5;
            this.passwordInput.Text = "Wachtwoord";
            this.passwordInput.Enter += new System.EventHandler(this.passwordInput_Enter);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(614, 275);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(83, 34);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 495);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.LoginBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.LoginBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginBg;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button loginBtn;
    }
}