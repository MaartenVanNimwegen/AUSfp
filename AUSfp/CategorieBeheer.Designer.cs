
namespace AUSfp
{
    partial class CategorieBeheer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorieBeheer));
            this.CtaegorieDropdown = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.PictureBox();
            this.AddBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // CtaegorieDropdown
            // 
            this.CtaegorieDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtaegorieDropdown.FormattingEnabled = true;
            this.CtaegorieDropdown.Items.AddRange(new object[] {
            "Categorie..."});
            this.CtaegorieDropdown.Location = new System.Drawing.Point(440, 46);
            this.CtaegorieDropdown.Name = "CtaegorieDropdown";
            this.CtaegorieDropdown.Size = new System.Drawing.Size(339, 32);
            this.CtaegorieDropdown.TabIndex = 45;
            this.CtaegorieDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel1.Location = new System.Drawing.Point(397, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 253);
            this.panel1.TabIndex = 46;
            // 
            // CategoryName
            // 
            this.CategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CategoryName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CategoryName.Location = new System.Drawing.Point(24, 46);
            this.CategoryName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CategoryName.Multiline = true;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(348, 42);
            this.CategoryName.TabIndex = 48;
            this.CategoryName.TabStop = false;
            this.CategoryName.Text = "Categorie naam...";
            this.CategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Location = new System.Drawing.Point(565, 151);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(121, 114);
            this.DeleteBtn.TabIndex = 49;
            this.DeleteBtn.TabStop = false;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Location = new System.Drawing.Point(126, 151);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(116, 114);
            this.AddBtn.TabIndex = 50;
            this.AddBtn.TabStop = false;
            // 
            // CategorieBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 289);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CtaegorieDropdown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategorieBeheer";
            this.Text = "Categorie Beheer";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CtaegorieDropdown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.PictureBox DeleteBtn;
        private System.Windows.Forms.PictureBox AddBtn;
    }
}