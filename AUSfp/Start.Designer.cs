
namespace AUSfp
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.RocLogo = new System.Windows.Forms.PictureBox();
            this.LoginBtn = new System.Windows.Forms.PictureBox();
            this.LogoutBtn = new System.Windows.Forms.PictureBox();
            this.ManageStockBtn = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RocLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageStockBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(677, 41);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(277, 22);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Welkom, Jesper Minks";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel1.Location = new System.Drawing.Point(21, 99);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 2);
            this.panel1.TabIndex = 2;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SearchBar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SearchBar.Location = new System.Drawing.Point(216, 32);
            this.SearchBar.Multiline = true;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(444, 45);
            this.SearchBar.TabIndex = 6;
            this.SearchBar.TabStop = false;
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SearchIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchIcon.BackgroundImage")));
            this.SearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIcon.Location = new System.Drawing.Point(625, 41);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(35, 31);
            this.SearchIcon.TabIndex = 34;
            this.SearchIcon.TabStop = false;
            this.SearchIcon.Click += new System.EventHandler(this.SearchIcon_Click);
            // 
            // RocLogo
            // 
            this.RocLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RocLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RocLogo.BackgroundImage")));
            this.RocLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RocLogo.Location = new System.Drawing.Point(21, 32);
            this.RocLogo.Name = "RocLogo";
            this.RocLogo.Size = new System.Drawing.Size(148, 45);
            this.RocLogo.TabIndex = 36;
            this.RocLogo.TabStop = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Location = new System.Drawing.Point(1050, 26);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(65, 51);
            this.LoginBtn.TabIndex = 37;
            this.LoginBtn.TabStop = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LogoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.BackgroundImage")));
            this.LogoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Location = new System.Drawing.Point(1123, 26);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(65, 51);
            this.LogoutBtn.TabIndex = 38;
            this.LogoutBtn.TabStop = false;
            // 
            // ManageStockBtn
            // 
            this.ManageStockBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManageStockBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManageStockBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManageStockBtn.BackgroundImage")));
            this.ManageStockBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManageStockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageStockBtn.Location = new System.Drawing.Point(961, 26);
            this.ManageStockBtn.Name = "ManageStockBtn";
            this.ManageStockBtn.Size = new System.Drawing.Size(65, 51);
            this.ManageStockBtn.TabIndex = 39;
            this.ManageStockBtn.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 128);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(375, 499);
            this.dataGridView1.TabIndex = 40;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1247, 647);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ManageStockBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.RocLogo);
            this.Controls.Add(this.SearchIcon);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Start";
            this.Text = "AUSfp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RocLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageStockBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.PictureBox RocLogo;
        private System.Windows.Forms.PictureBox LoginBtn;
        private System.Windows.Forms.PictureBox LogoutBtn;
        private System.Windows.Forms.PictureBox ManageStockBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

