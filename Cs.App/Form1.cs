using Cs.Lib.Abstract;
using Cs.Lib.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Cs.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSilahlar.DataSource = Enum.GetNames(typeof(Silahlar)); //Silahlar Enumındaki Silah tiplerini alıp cmbSilahlar klasörüne atama

            tmrSeri.Tick += TmrSeri_Tick1; //1.Yol  //formda event tanımlamak için
            //tmrseri.Tick= new EventHandler();
        }

        //Aşağıdaki mouseup mosedown için kullandık. Seri atış aralığını belirlemek için
        private void TmrSeri_Tick1(object sender, EventArgs e)
        {
            btnAtesEt.PerformClick();
            Thread.Sleep(500);
        }


        private Silah silah;

        private Timer tmrSeri = new Timer();
        private void cmbSilahlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSilahlar.SelectedItem == null) return;

            Silahlar seciliSilah = Enum.Parse<Silahlar>(cmbSilahlar.SelectedItem.ToString());

            switch (seciliSilah)
            {
                case Silahlar.Bıçak:
                    silah = new Bicak();
                    break;
                case Silahlar.USP:
                    silah = new USP();
                    break;
                case Silahlar.Glock:
                    silah = new Glock();
                    break;
                case Silahlar.AK47:
                    silah = new Ak47();
                    break;
                case Silahlar.M4A1S:
                    silah = new M4A1S();
                    break;
                case Silahlar.AWP:
                    silah = new AWP();
                    break;
                case Silahlar.ElBombası:
                    silah = new ElBombasi();
                    break;
                case Silahlar.FlashBombası:
                    silah = new FlashBombasi();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
                    break;
            }

          //  if (silah == null) return;  silah null gelse de bize hata verme demek

            if (silah is IAtesEdebilen)
            {
                gbAtesliSilah.Visible = true;
                gbFirlatilan.Visible = false;
                gbYakinSaldiri.Visible = false;
            }
            else if (silah is IFirlatilabilen)
            {
                gbAtesliSilah.Visible = false;
                gbFirlatilan.Visible = true;
                gbYakinSaldiri.Visible = false;
            }
            else
            {
                gbAtesliSilah.Visible = false;
                gbFirlatilan.Visible = false;
                gbYakinSaldiri.Visible = true;
            }          

            panelSilah.Controls.Clear();
            PictureBox pbBox = new PictureBox();
            pbBox.Image = Image.FromStream(silah.SilahResim);
            pbBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBox.Dock = DockStyle.Fill;
            panelSilah.Controls.Add(pbBox);

            SilahBilgisiGoster(silah);
        }

        private void SilahBilgisiGoster(Silah silah)
        {
            lblDetay.Text = $"Ülke: {silah.Ulke}\nFiyat: {silah.Fiyat:c2}";
            //ISarjorlu seciliSilah = null;
            if (silah is ISarjorlu sarjorSilah)
                lblDurum.Text = $"{sarjorSilah.KalanFisek}/{sarjorSilah.SarjorKapasitesi}";
        }

        private void btnAtesEt_Click(object sender, EventArgs e)
        {
            btnAtesEt.Enabled = false;
            IAtesEdebilen atesliSilah = silah as IAtesEdebilen;
            int sayi = atesliSilah.AtesEt();
            SoundPlayer player;

            if (sayi != 0)
            {
                player = new SoundPlayer(atesliSilah.AtisSesi);
                atesliSilah.AtisSesi.Position = 0;
            }
            else
            {
                player = new SoundPlayer(atesliSilah.BitikFisekSesi);
                atesliSilah.BitikFisekSesi.Position = 0;
            }
            SilahBilgisiGoster(silah);
            player.Play();
            btnAtesEt.Enabled = true;
        }
        
        private void btnYenidenDoldur_Click(object sender, EventArgs e)
        {
            ISarjorlu atesliSilah = silah as ISarjorlu;
            atesliSilah.YenidenDoldur();
            SoundPlayer player = new SoundPlayer(atesliSilah.YenidenDoldurmaSesi);
            atesliSilah.YenidenDoldurmaSesi.Position = 0;
            SilahBilgisiGoster(silah);
            player.Play();
        }

        private void btnAtesEt_MouseDown(object sender, MouseEventArgs e)
        {
            if (silah is ISeriAtabilir ss)
            {
                tmrSeri.Interval = ss.AtisKatsayisi;
                tmrSeri.Start();
            }
        }

        private void btnAtesEt_MouseUp(object sender, MouseEventArgs e)
        {
            if (silah is ISeriAtabilir)
            {
                tmrSeri.Stop();
            }
        }

        private void btnFirlat_Click(object sender, EventArgs e)
        {
            IFirlatilabilen elBombaliSaldiri = silah as IFirlatilabilen;

            elBombaliSaldiri.Firlat();

            SoundPlayer player = new SoundPlayer(elBombaliSaldiri.BombaSesi);
           
            SilahBilgisiGoster(silah);
            
            player.Play();
        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            IVurulabilir bicakliSaldiri = silah as IVurulabilir;

            bicakliSaldiri.Vur();        
         
            SoundPlayer player = new SoundPlayer(bicakliSaldiri.BicakSaplamaSesi);
            
            SilahBilgisiGoster(silah);
           
            player.Play();          

        }

        private void panelSilah_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
