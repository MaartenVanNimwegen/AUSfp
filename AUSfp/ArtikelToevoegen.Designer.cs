
namespace AUSfp
{
    partial class ArtikelToevoegen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtikelToevoegen));
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.PictureBox();
            this.ImageName = new System.Windows.Forms.Label();
            this.beschrijvingTextbox = new System.Windows.Forms.TextBox();
            this.CategorieDropdown = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddItemBtn = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddItemBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTextbox
            // 
            this.titleTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.titleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.titleTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.titleTextbox.Location = new System.Drawing.Point(27, 195);
            this.titleTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(268, 26);
            this.titleTextbox.TabIndex = 49;
            this.titleTextbox.TabStop = false;
            this.titleTextbox.Text = "Titel...";
            this.titleTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleTextbox.Enter += new System.EventHandler(this.titleTextbox_Enter);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Location = new System.Drawing.Point(88, 8);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(143, 135);
            this.AddBtn.TabIndex = 51;
            this.AddBtn.TabStop = false;
            // 
            // ImageName
            // 
            this.ImageName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImageName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ImageName.Location = new System.Drawing.Point(9, 151);
            this.ImageName.Name = "ImageName";
            this.ImageName.Size = new System.Drawing.Size(323, 22);
            this.ImageName.TabIndex = 53;
            this.ImageName.Text = "Selecteer een plaatje";
            this.ImageName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // beschrijvingTextbox
            // 
            this.beschrijvingTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.beschrijvingTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.beschrijvingTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beschrijvingTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.beschrijvingTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.beschrijvingTextbox.Location = new System.Drawing.Point(27, 225);
            this.beschrijvingTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.beschrijvingTextbox.Multiline = true;
            this.beschrijvingTextbox.Name = "beschrijvingTextbox";
            this.beschrijvingTextbox.Size = new System.Drawing.Size(268, 115);
            this.beschrijvingTextbox.TabIndex = 54;
            this.beschrijvingTextbox.TabStop = false;
            this.beschrijvingTextbox.Text = "Beschrijving...";
            this.beschrijvingTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.beschrijvingTextbox.Enter += new System.EventHandler(this.beschrijvingTextbox_Enter);
            // 
            // CategorieDropdown
            // 
            this.CategorieDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CategorieDropdown.FormattingEnabled = true;
            this.CategorieDropdown.Items.AddRange(new object[] {
            "Drones"});
            this.CategorieDropdown.Location = new System.Drawing.Point(27, 366);
            this.CategorieDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.CategorieDropdown.Name = "CategorieDropdown";
            this.CategorieDropdown.Size = new System.Drawing.Size(268, 24);
            this.CategorieDropdown.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel2.Location = new System.Drawing.Point(339, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 389);
            this.panel2.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel1.Location = new System.Drawing.Point(18, 184);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 2);
            this.panel1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(23, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 22);
            this.label1.TabIndex = 58;
            this.label1.Text = "Categorie:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddItemBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddItemBtn.BackgroundImage")));
            this.AddItemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemBtn.Location = new System.Drawing.Point(432, 352);
            this.AddItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(55, 49);
            this.AddItemBtn.TabIndex = 63;
            this.AddItemBtn.TabStop = false;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Location = new System.Drawing.Point(493, 352);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(63, 55);
            this.CancelBtn.TabIndex = 64;
            this.CancelBtn.TabStop = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ArtikelToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 415);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CategorieDropdown);
            this.Controls.Add(this.beschrijvingTextbox);
            this.Controls.Add(this.ImageName);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.titleTextbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArtikelToevoegen";
            this.Text = "ArtikelToevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddItemBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.PictureBox AddBtn;
        private System.Windows.Forms.Label ImageName;
        private System.Windows.Forms.TextBox beschrijvingTextbox;
        private System.Windows.Forms.ComboBox CategorieDropdown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AddItemBtn;
        private System.Windows.Forms.PictureBox CancelBtn;
    }
}