
namespace AUSfp
{
    partial class Uitlenen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uitlenen));
            this.StudentId = new System.Windows.Forms.TextBox();
            this.ItemId = new System.Windows.Forms.TextBox();
            this.TurnInDateTime = new System.Windows.Forms.DateTimePicker();
            this.ImageName = new System.Windows.Forms.Label();
            this.inleverUitleenIcon = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.inleverUitleenIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentId
            // 
            this.StudentId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.StudentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.StudentId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StudentId.Location = new System.Drawing.Point(80, 50);
            this.StudentId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(411, 36);
            this.StudentId.TabIndex = 50;
            this.StudentId.TabStop = false;
            this.StudentId.Text = "Student nr...";
            this.StudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StudentId.TextChanged += new System.EventHandler(this.StudentId_TextChanged);
            // 
            // ItemId
            // 
            this.ItemId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ItemId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ItemId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ItemId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ItemId.Location = new System.Drawing.Point(80, 114);
            this.ItemId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemId.Name = "ItemId";
            this.ItemId.Size = new System.Drawing.Size(411, 36);
            this.ItemId.TabIndex = 51;
            this.ItemId.TabStop = false;
            this.ItemId.Text = "Student naam...";
            this.ItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TurnInDateTime
            // 
            this.TurnInDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TurnInDateTime.Location = new System.Drawing.Point(79, 231);
            this.TurnInDateTime.Name = "TurnInDateTime";
            this.TurnInDateTime.Size = new System.Drawing.Size(411, 29);
            this.TurnInDateTime.TabIndex = 52;
            // 
            // ImageName
            // 
            this.ImageName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImageName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ImageName.Location = new System.Drawing.Point(62, 195);
            this.ImageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageName.Name = "ImageName";
            this.ImageName.Size = new System.Drawing.Size(444, 33);
            this.ImageName.TabIndex = 54;
            this.ImageName.Text = "Inleverdatum:";
            this.ImageName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inleverUitleenIcon
            // 
            this.inleverUitleenIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inleverUitleenIcon.BackColor = System.Drawing.SystemColors.Control;
            this.inleverUitleenIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inleverUitleenIcon.BackgroundImage")));
            this.inleverUitleenIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inleverUitleenIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inleverUitleenIcon.Location = new System.Drawing.Point(150, 322);
            this.inleverUitleenIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inleverUitleenIcon.Name = "inleverUitleenIcon";
            this.inleverUitleenIcon.Size = new System.Drawing.Size(92, 93);
            this.inleverUitleenIcon.TabIndex = 55;
            this.inleverUitleenIcon.TabStop = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Location = new System.Drawing.Point(275, 322);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(87, 82);
            this.CancelBtn.TabIndex = 65;
            this.CancelBtn.TabStop = false;
            // 
            // Uitlenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 452);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.inleverUitleenIcon);
            this.Controls.Add(this.ImageName);
            this.Controls.Add(this.TurnInDateTime);
            this.Controls.Add(this.ItemId);
            this.Controls.Add(this.StudentId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uitlenen";
            this.Text = "Uitlenen";
            ((System.ComponentModel.ISupportInitialize)(this.inleverUitleenIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.TextBox ItemId;
        private System.Windows.Forms.DateTimePicker TurnInDateTime;
        private System.Windows.Forms.Label ImageName;
        private System.Windows.Forms.PictureBox inleverUitleenIcon;
        private System.Windows.Forms.PictureBox CancelBtn;
    }
}