
namespace Kalıtımm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstsekiller = new System.Windows.Forms.ListBox();
            this.lblDetay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstsekiller
            // 
            this.lstsekiller.FormattingEnabled = true;
            this.lstsekiller.ItemHeight = 15;
            this.lstsekiller.Location = new System.Drawing.Point(26, 29);
            this.lstsekiller.Name = "lstsekiller";
            this.lstsekiller.Size = new System.Drawing.Size(240, 349);
            this.lstsekiller.TabIndex = 0;
            this.lstsekiller.SelectedIndexChanged += new System.EventHandler(this.lstsekiller_SelectedIndexChanged);
            // 
            // lblDetay
            // 
            this.lblDetay.AutoSize = true;
            this.lblDetay.Location = new System.Drawing.Point(292, 29);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(50, 15);
            this.lblDetay.TabIndex = 1;
            this.lblDetay.Text = "lblDetay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDetay);
            this.Controls.Add(this.lstsekiller);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstsekiller;
        private System.Windows.Forms.Label lblDetay;
    }
}

