
namespace AUSfp
{
    partial class Inleveren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inleveren));
            this.CancelBtn = new System.Windows.Forms.PictureBox();
            this.inleverUitleenIcon = new System.Windows.Forms.PictureBox();
            this.Note = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inleverUitleenIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Location = new System.Drawing.Point(299, 151);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(87, 82);
            this.CancelBtn.TabIndex = 68;
            this.CancelBtn.TabStop = false;
            // 
            // inleverUitleenIcon
            // 
            this.inleverUitleenIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inleverUitleenIcon.BackColor = System.Drawing.SystemColors.Control;
            this.inleverUitleenIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inleverUitleenIcon.BackgroundImage")));
            this.inleverUitleenIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inleverUitleenIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inleverUitleenIcon.Location = new System.Drawing.Point(174, 151);
            this.inleverUitleenIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inleverUitleenIcon.Name = "inleverUitleenIcon";
            this.inleverUitleenIcon.Size = new System.Drawing.Size(92, 93);
            this.inleverUitleenIcon.TabIndex = 67;
            this.inleverUitleenIcon.TabStop = false;
            // 
            // Note
            // 
            this.Note.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Note.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Note.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Note.Location = new System.Drawing.Point(94, 44);
            this.Note.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(411, 36);
            this.Note.TabIndex = 66;
            this.Note.TabStop = false;
            this.Note.Text = "Notitie...";
            this.Note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Inleveren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 272);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.inleverUitleenIcon);
            this.Controls.Add(this.Note);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inleveren";
            this.Text = "Inleveren";
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inleverUitleenIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CancelBtn;
        private System.Windows.Forms.PictureBox inleverUitleenIcon;
        private System.Windows.Forms.TextBox Note;
    }
}