
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
            this.beschrijvingTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddItemBtn = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.PictureBox();
            this.ImgurlTextbox = new System.Windows.Forms.TextBox();
            this.ImgUrlLable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CategorieTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddItemBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTextbox
            // 
            this.titleTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.titleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.titleTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.titleTextbox.Location = new System.Drawing.Point(20, 158);
            this.titleTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(201, 21);
            this.titleTextbox.TabIndex = 49;
            this.titleTextbox.TabStop = false;
            this.titleTextbox.Text = "Titel...";
            this.titleTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleTextbox.Enter += new System.EventHandler(this.titleTextbox_Enter);
            // 
            // beschrijvingTextbox
            // 
            this.beschrijvingTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.beschrijvingTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.beschrijvingTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beschrijvingTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.beschrijvingTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.beschrijvingTextbox.Location = new System.Drawing.Point(20, 183);
            this.beschrijvingTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.beschrijvingTextbox.Multiline = true;
            this.beschrijvingTextbox.Name = "beschrijvingTextbox";
            this.beschrijvingTextbox.Size = new System.Drawing.Size(201, 93);
            this.beschrijvingTextbox.TabIndex = 54;
            this.beschrijvingTextbox.TabStop = false;
            this.beschrijvingTextbox.Text = "Beschrijving...";
            this.beschrijvingTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.beschrijvingTextbox.Enter += new System.EventHandler(this.beschrijvingTextbox_Enter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel2.Location = new System.Drawing.Point(236, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 316);
            this.panel2.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel1.Location = new System.Drawing.Point(11, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 2);
            this.panel1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(17, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
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
            this.AddItemBtn.Location = new System.Drawing.Point(324, 286);
            this.AddItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(41, 40);
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
            this.CancelBtn.Location = new System.Drawing.Point(370, 286);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(47, 45);
            this.CancelBtn.TabIndex = 64;
            this.CancelBtn.TabStop = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ImgurlTextbox
            // 
            this.ImgurlTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ImgurlTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImgurlTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgurlTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ImgurlTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ImgurlTextbox.Location = new System.Drawing.Point(20, 92);
            this.ImgurlTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.ImgurlTextbox.Name = "ImgurlTextbox";
            this.ImgurlTextbox.Size = new System.Drawing.Size(201, 21);
            this.ImgurlTextbox.TabIndex = 65;
            this.ImgurlTextbox.TabStop = false;
            this.ImgurlTextbox.Text = "Url";
            this.ImgurlTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImgurlTextbox.Enter += new System.EventHandler(this.ImgurlTextbox_Enter);
            // 
            // ImgUrlLable
            // 
            this.ImgUrlLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImgUrlLable.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgUrlLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ImgUrlLable.Location = new System.Drawing.Point(17, 72);
            this.ImgUrlLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImgUrlLable.Name = "ImgUrlLable";
            this.ImgUrlLable.Size = new System.Drawing.Size(204, 18);
            this.ImgUrlLable.TabIndex = 66;
            this.ImgUrlLable.Text = "Vul hier de url van de foto in:";
            this.ImgUrlLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(265, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // CategorieTextbox
            // 
            this.CategorieTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CategorieTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategorieTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorieTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CategorieTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CategorieTextbox.Location = new System.Drawing.Point(20, 298);
            this.CategorieTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CategorieTextbox.Name = "CategorieTextbox";
            this.CategorieTextbox.Size = new System.Drawing.Size(201, 21);
            this.CategorieTextbox.TabIndex = 68;
            this.CategorieTextbox.TabStop = false;
            this.CategorieTextbox.Text = "Categorie...";
            this.CategorieTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CategorieTextbox.Enter += new System.EventHandler(this.CategorieTextbox_Enter);
            // 
            // ArtikelToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 337);
            this.Controls.Add(this.CategorieTextbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ImgUrlLable);
            this.Controls.Add(this.ImgurlTextbox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.beschrijvingTextbox);
            this.Controls.Add(this.titleTextbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArtikelToevoegen";
            this.Text = "ArtikelToevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.AddItemBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.TextBox beschrijvingTextbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AddItemBtn;
        private System.Windows.Forms.PictureBox CancelBtn;
        private System.Windows.Forms.TextBox ImgurlTextbox;
        private System.Windows.Forms.Label ImgUrlLable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CategorieTextbox;
    }
}