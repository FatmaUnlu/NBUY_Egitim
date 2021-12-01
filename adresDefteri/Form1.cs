using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using adresDefteri.Modelss;

namespace adresDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kişi kisi = new Kişi();
        Ders ders = new Ders();

        private void Form1_Load(object sender, EventArgs e)
        {
            //kisi.ad = "Fatma ";
            //kisi.soyad = " Ünlü"; //set yapılıyor
            //MessageBox.Show(kisi.soyad);//get


            //kişi.cs de property yazınca bu şekilde oldu o klasörü incele
            //try
            //{

            //    kisi.Ad = "Fatma ";
            //    kisi.Soyad = " UNLU"; //set yapılıyor
            //    kisi.KimlikNo = "72345678901";
            //    kisi.DogumTarihi = new DateTime(1985, 5, 20);

            //}


            //catch (Exception ex)
            //{

            //    MessageBox.Show($"bir hata oluştu: {ex.Message}");
            //}

            //MessageBox.Show ($"Kişinin yaşı: { kisi.Yas}"); //get
        }

        private List<Kişi> kisiler = new List<Kişi>(); //veri tabanı yok şuan verileri buraya gireceğiz.

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kişi yeniKisi = new Kişi(); //kişi sınıfından yenikisi nesnesi oluşturduk. Kişi() constructordır.
            try
            {
                yeniKisi.Ad = txtAd.Text; //textboxtan txtad değerini alıp yenikisi nesnesinin Ad değişkenine atanır
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.DogumTarihi = dtpDogumTarihi.Value;
                yeniKisi.KimlikNo = txtTCKN.Text;

                kisiler.Add(yeniKisi);

                // lstKisiler.Items.Add(yeniKisi.ToString()); //böylr yapınca lstkisiler kutusuna adresDefteri.Kişi yazar. Çünkü list box tostring metodunu kullanır gösterirken.//bunu Kişi klasında override ile düzeltiyoruz
                // yeniKisi.olusturulmaZamani = DateTime.Now.AddDays(1); dışarıdan set edilmesini engellediğimiz için hata verdi burda

                ListeyiDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //lstkisilerdeki kişiye tıklayınca bilgiler ad soyad vs textlerine eklenecek. Güncelleme yapılıp tekrar kaydedilecek eski kayıt silinip.

        private void ListeyiDoldur()
        {
            lstKisiler.Items.Clear();

            foreach (Kişi kisi1 in kisiler)
            {
                lstKisiler.Items.Add(kisi1);
            }
        }

        private Kişi seciliKisi;

        //listkisilerdeki kişiye tıklayınca bilgiler ad soyad vs textlerine eklenecek.
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            
                //Kişi seciliKisi = (Kişi)lstKisiler.SelectedItem;
                seciliKisi = lstKisiler.SelectedItem as Kişi;

                txtAd.Text = seciliKisi.Ad;
                txtSoyad.Text = seciliKisi.Soyad;
                txtTCKN.Text = seciliKisi.KimlikNo;
                dtpDogumTarihi.Value = seciliKisi.DogumTarihi;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null) return;
            seciliKisi.Ad = txtAd.Text;
            seciliKisi.Soyad = txtSoyad.Text;
            seciliKisi.KimlikNo = txtTCKN.Text;
            seciliKisi.DogumTarihi = dtpDogumTarihi.Value;

            ListeyiDoldur();

          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null) return;

            DialogResult cevap = MessageBox.Show($"{seciliKisi} yi silmek istiyor musunuz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                kisiler.Remove(seciliKisi);
                ListeyiDoldur();
            }
        }
    }
}
