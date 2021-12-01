
namespace Cs.App
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSilahlar = new System.Windows.Forms.ComboBox();
            this.lblDetay = new System.Windows.Forms.Label();
            this.gbAtesliSilah = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnYenidenDoldur = new System.Windows.Forms.Button();
            this.btnAtesEt = new System.Windows.Forms.Button();
            this.gbYakinSaldiri = new System.Windows.Forms.GroupBox();
            this.btnSaldir = new System.Windows.Forms.Button();
            this.gbFirlatilan = new System.Windows.Forms.GroupBox();
            this.btnFirlat = new System.Windows.Forms.Button();
            this.panelSilah = new System.Windows.Forms.Panel();
            this.gbAtesliSilah.SuspendLayout();
            this.gbYakinSaldiri.SuspendLayout();
            this.gbFirlatilan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silah Seçiniz";
            // 
            // cmbSilahlar
            // 
            this.cmbSilahlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSilahlar.FormattingEnabled = true;
            this.cmbSilahlar.Location = new System.Drawing.Point(148, 23);
            this.cmbSilahlar.Name = "cmbSilahlar";
            this.cmbSilahlar.Size = new System.Drawing.Size(121, 23);
            this.cmbSilahlar.TabIndex = 1;
            this.cmbSilahlar.SelectedIndexChanged += new System.EventHandler(this.cmbSilahlar_SelectedIndexChanged);
            // 
            // lblDetay
            // 
            this.lblDetay.AutoSize = true;
            this.lblDetay.Location = new System.Drawing.Point(28, 89);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(50, 15);
            this.lblDetay.TabIndex = 2;
            this.lblDetay.Text = "Detaylar";
            // 
            // gbAtesliSilah
            // 
            this.gbAtesliSilah.Controls.Add(this.lblDurum);
            this.gbAtesliSilah.Controls.Add(this.btnYenidenDoldur);
            this.gbAtesliSilah.Controls.Add(this.btnAtesEt);
            this.gbAtesliSilah.Location = new System.Drawing.Point(28, 193);
            this.gbAtesliSilah.Name = "gbAtesliSilah";
            this.gbAtesliSilah.Size = new System.Drawing.Size(322, 109);
            this.gbAtesliSilah.TabIndex = 3;
            this.gbAtesliSilah.TabStop = false;
            this.gbAtesliSilah.Text = "Silah Kontrol";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(213, 40);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(44, 15);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "Durum";
            // 
            // btnYenidenDoldur
            // 
            this.btnYenidenDoldur.Location = new System.Drawing.Point(107, 22);
            this.btnYenidenDoldur.Name = "btnYenidenDoldur";
            this.btnYenidenDoldur.Size = new System.Drawing.Size(71, 71);
            this.btnYenidenDoldur.TabIndex = 1;
            this.btnYenidenDoldur.Text = "Yeniden Doldur";
            this.btnYenidenDoldur.UseVisualStyleBackColor = true;
            this.btnYenidenDoldur.Click += new System.EventHandler(this.btnYenidenDoldur_Click);
            // 
            // btnAtesEt
            // 
            this.btnAtesEt.Location = new System.Drawing.Point(19, 23);
            this.btnAtesEt.Name = "btnAtesEt";
            this.btnAtesEt.Size = new System.Drawing.Size(69, 71);
            this.btnAtesEt.TabIndex = 0;
            this.btnAtesEt.Text = "Ateş Et";
            this.btnAtesEt.UseVisualStyleBackColor = true;
            this.btnAtesEt.Click += new System.EventHandler(this.btnAtesEt_Click);
            this.btnAtesEt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseDown);
            this.btnAtesEt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseUp);
            // 
            // gbYakinSaldiri
            // 
            this.gbYakinSaldiri.Controls.Add(this.btnSaldir);
            this.gbYakinSaldiri.Location = new System.Drawing.Point(28, 317);
            this.gbYakinSaldiri.Name = "gbYakinSaldiri";
            this.gbYakinSaldiri.Size = new System.Drawing.Size(322, 110);
            this.gbYakinSaldiri.TabIndex = 4;
            this.gbYakinSaldiri.TabStop = false;
            this.gbYakinSaldiri.Text = "Yakın Saldırı Kontrol";
            // 
            // btnSaldir
            // 
            this.btnSaldir.Location = new System.Drawing.Point(19, 23);
            this.btnSaldir.Name = "btnSaldir";
            this.btnSaldir.Size = new System.Drawing.Size(69, 71);
            this.btnSaldir.TabIndex = 2;
            this.btnSaldir.Text = "Saldır";
            this.btnSaldir.UseVisualStyleBackColor = true;
            this.btnSaldir.Click += new System.EventHandler(this.btnSaldir_Click);
            // 
            // gbFirlatilan
            // 
            this.gbFirlatilan.Controls.Add(this.btnFirlat);
            this.gbFirlatilan.Location = new System.Drawing.Point(407, 317);
            this.gbFirlatilan.Name = "gbFirlatilan";
            this.gbFirlatilan.Size = new System.Drawing.Size(298, 110);
            this.gbFirlatilan.TabIndex = 4;
            this.gbFirlatilan.TabStop = false;
            this.gbFirlatilan.Text = "Fırlatılan Silah Kontrol";
            // 
            // btnFirlat
            // 
            this.btnFirlat.Location = new System.Drawing.Point(6, 22);
            this.btnFirlat.Name = "btnFirlat";
            this.btnFirlat.Size = new System.Drawing.Size(69, 71);
            this.btnFirlat.TabIndex = 1;
            this.btnFirlat.Text = "Fırlat";
            this.btnFirlat.UseVisualStyleBackColor = true;
            this.btnFirlat.Click += new System.EventHandler(this.btnFirlat_Click);
            // 
            // panelSilah
            // 
            this.panelSilah.Location = new System.Drawing.Point(407, 42);
            this.panelSilah.Name = "panelSilah";
            this.panelSilah.Size = new System.Drawing.Size(298, 244);
            this.panelSilah.TabIndex = 5;
            this.panelSilah.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSilah_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSilah);
            this.Controls.Add(this.gbFirlatilan);
            this.Controls.Add(this.gbYakinSaldiri);
            this.Controls.Add(this.gbAtesliSilah);
            this.Controls.Add(this.lblDetay);
            this.Controls.Add(this.cmbSilahlar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAtesliSilah.ResumeLayout(false);
            this.gbAtesliSilah.PerformLayout();
            this.gbYakinSaldiri.ResumeLayout(false);
            this.gbFirlatilan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSilahlar;
        private System.Windows.Forms.Label lblDetay;
        private System.Windows.Forms.GroupBox gbAtesliSilah;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnYenidenDoldur;
        private System.Windows.Forms.Button btnAtesEt;
        private System.Windows.Forms.GroupBox gbYakinSaldiri;
        private System.Windows.Forms.Button btnSaldir;
        private System.Windows.Forms.GroupBox gbFirlatilan;
        private System.Windows.Forms.Button btnFirlat;
        private System.Windows.Forms.Panel panelSilah;
    }
}

