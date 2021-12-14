
namespace AUSfp
{
    partial class ArtikelVerwijderen
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
            this.verwijderenNee = new System.Windows.Forms.Button();
            this.verwijderenJa = new System.Windows.Forms.Button();
            this.verwijderenLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verwijderenNee
            // 
            this.verwijderenNee.Location = new System.Drawing.Point(113, 319);
            this.verwijderenNee.Name = "verwijderenNee";
            this.verwijderenNee.Size = new System.Drawing.Size(81, 36);
            this.verwijderenNee.TabIndex = 0;
            this.verwijderenNee.Text = "Nee";
            this.verwijderenNee.UseVisualStyleBackColor = true;
            this.verwijderenNee.Click += new System.EventHandler(this.verwijderenNee_Click);
            // 
            // verwijderenJa
            // 
            this.verwijderenJa.Location = new System.Drawing.Point(200, 319);
            this.verwijderenJa.Name = "verwijderenJa";
            this.verwijderenJa.Size = new System.Drawing.Size(81, 36);
            this.verwijderenJa.TabIndex = 1;
            this.verwijderenJa.Text = "Ja";
            this.verwijderenJa.UseVisualStyleBackColor = true;
            this.verwijderenJa.Click += new System.EventHandler(this.verwijderenJa_Click);
            // 
            // verwijderenLable
            // 
            this.verwijderenLable.AutoSize = true;
            this.verwijderenLable.Location = new System.Drawing.Point(68, 202);
            this.verwijderenLable.Name = "verwijderenLable";
            this.verwijderenLable.Size = new System.Drawing.Size(302, 17);
            this.verwijderenLable.TabIndex = 2;
            this.verwijderenLable.Text = "Weet je zeker dat je dit artikel wilt verwijderen?";
            // 
            // ArtikelVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.verwijderenLable);
            this.Controls.Add(this.verwijderenJa);
            this.Controls.Add(this.verwijderenNee);
            this.Name = "ArtikelVerwijderen";
            this.Text = "ArtikelVerwijderen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verwijderenNee;
        private System.Windows.Forms.Button verwijderenJa;
        private System.Windows.Forms.Label verwijderenLable;
    }
}