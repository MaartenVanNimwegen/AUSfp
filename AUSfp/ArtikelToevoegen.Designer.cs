
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
            this.Title = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.PictureBox();
            this.ImageName = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.CtaegorieDropdown = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Notes = new System.Windows.Forms.TextBox();
            this.ItemNumber = new System.Windows.Forms.TextBox();
            this.AddItemBtn = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddItemBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Title.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Title.Location = new System.Drawing.Point(37, 293);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(368, 42);
            this.Title.TabIndex = 49;
            this.Title.TabStop = false;
            this.Title.Text = "Titel...";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Location = new System.Drawing.Point(121, 12);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(196, 202);
            this.AddBtn.TabIndex = 51;
            this.AddBtn.TabStop = false;
            // 
            // ImageName
            // 
            this.ImageName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImageName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ImageName.Location = new System.Drawing.Point(13, 226);
            this.ImageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageName.Name = "ImageName";
            this.ImageName.Size = new System.Drawing.Size(444, 33);
            this.ImageName.TabIndex = 53;
            this.ImageName.Text = "Selecteer een plaatje";
            this.ImageName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Description.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Description.Location = new System.Drawing.Point(37, 366);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(368, 214);
            this.Description.TabIndex = 54;
            this.Description.TabStop = false;
            this.Description.Text = "Beschrijving...";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CtaegorieDropdown
            // 
            this.CtaegorieDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtaegorieDropdown.FormattingEnabled = true;
            this.CtaegorieDropdown.Items.AddRange(new object[] {
            "Categorie..."});
            this.CtaegorieDropdown.Location = new System.Drawing.Point(495, 63);
            this.CtaegorieDropdown.Name = "CtaegorieDropdown";
            this.CtaegorieDropdown.Size = new System.Drawing.Size(367, 32);
            this.CtaegorieDropdown.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel2.Location = new System.Drawing.Point(466, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 583);
            this.panel2.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel1.Location = new System.Drawing.Point(25, 276);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 3);
            this.panel1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(477, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 33);
            this.label1.TabIndex = 58;
            this.label1.Text = "Categorie:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(477, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 33);
            this.label2.TabIndex = 60;
            this.label2.Text = "Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Beschikbaar",
            "Niet beschikbaar"});
            this.comboBox1.Location = new System.Drawing.Point(495, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(367, 32);
            this.comboBox1.TabIndex = 59;
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Notes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Notes.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Notes.Location = new System.Drawing.Point(494, 299);
            this.Notes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(368, 214);
            this.Notes.TabIndex = 61;
            this.Notes.TabStop = false;
            this.Notes.Text = "Notities...";
            this.Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemNumber
            // 
            this.ItemNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ItemNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ItemNumber.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ItemNumber.Location = new System.Drawing.Point(494, 226);
            this.ItemNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemNumber.Multiline = true;
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.Size = new System.Drawing.Size(368, 42);
            this.ItemNumber.TabIndex = 62;
            this.ItemNumber.TabStop = false;
            this.ItemNumber.Text = "Artikel nr...";
            this.ItemNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddItemBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddItemBtn.BackgroundImage")));
            this.AddItemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemBtn.Location = new System.Drawing.Point(594, 528);
            this.AddItemBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(76, 73);
            this.AddItemBtn.TabIndex = 63;
            this.AddItemBtn.TabStop = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Location = new System.Drawing.Point(678, 528);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(86, 82);
            this.CancelBtn.TabIndex = 64;
            this.CancelBtn.TabStop = false;
            // 
            // ArtikelToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 622);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.ItemNumber);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CtaegorieDropdown);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ImageName);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Title);
            this.Name = "ArtikelToevoegen";
            this.Text = "ArtikelToevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddItemBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.PictureBox AddBtn;
        private System.Windows.Forms.Label ImageName;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.ComboBox CtaegorieDropdown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.TextBox ItemNumber;
        private System.Windows.Forms.PictureBox AddItemBtn;
        private System.Windows.Forms.PictureBox CancelBtn;
    }
}