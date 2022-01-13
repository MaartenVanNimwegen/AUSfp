
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
            this.StudentName = new System.Windows.Forms.TextBox();
            this.TurnInDateTime = new System.Windows.Forms.DateTimePicker();
            this.ImageName = new System.Windows.Forms.Label();
            this.inleverUitleenIcon = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.StudentId.Location = new System.Drawing.Point(44, 36);
            this.StudentId.Margin = new System.Windows.Forms.Padding(2);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(224, 21);
            this.StudentId.TabIndex = 50;
            this.StudentId.TabStop = false;
            this.StudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StudentId.Enter += new System.EventHandler(this.StudentId_Enter);
            // 
            // StudentName
            // 
            this.StudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.StudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.StudentName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StudentName.Location = new System.Drawing.Point(44, 83);
            this.StudentName.Margin = new System.Windows.Forms.Padding(2);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(224, 21);
            this.StudentName.TabIndex = 51;
            this.StudentName.TabStop = false;
            this.StudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StudentName.Enter += new System.EventHandler(this.StudentName_Enter);
            // 
            // TurnInDateTime
            // 
            this.TurnInDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TurnInDateTime.CustomFormat = "yyyy-MM-dd";
            this.TurnInDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TurnInDateTime.Location = new System.Drawing.Point(43, 125);
            this.TurnInDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.TurnInDateTime.Name = "TurnInDateTime";
            this.TurnInDateTime.Size = new System.Drawing.Size(226, 20);
            this.TurnInDateTime.TabIndex = 52;
            // 
            // ImageName
            // 
            this.ImageName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImageName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ImageName.Location = new System.Drawing.Point(34, 106);
            this.ImageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImageName.Name = "ImageName";
            this.ImageName.Size = new System.Drawing.Size(242, 18);
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
            this.inleverUitleenIcon.Location = new System.Drawing.Point(82, 174);
            this.inleverUitleenIcon.Margin = new System.Windows.Forms.Padding(2);
            this.inleverUitleenIcon.Name = "inleverUitleenIcon";
            this.inleverUitleenIcon.Size = new System.Drawing.Size(50, 50);
            this.inleverUitleenIcon.TabIndex = 55;
            this.inleverUitleenIcon.TabStop = false;
            this.inleverUitleenIcon.Click += new System.EventHandler(this.inleverUitleenIcon_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Location = new System.Drawing.Point(150, 174);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(47, 44);
            this.CancelBtn.TabIndex = 65;
            this.CancelBtn.TabStop = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Student naam...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(34, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Student nr...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Uitlenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.inleverUitleenIcon);
            this.Controls.Add(this.ImageName);
            this.Controls.Add(this.TurnInDateTime);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.StudentId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Uitlenen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uitlenen";
            ((System.ComponentModel.ISupportInitialize)(this.inleverUitleenIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.DateTimePicker TurnInDateTime;
        private System.Windows.Forms.Label ImageName;
        private System.Windows.Forms.PictureBox inleverUitleenIcon;
        private System.Windows.Forms.PictureBox CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}