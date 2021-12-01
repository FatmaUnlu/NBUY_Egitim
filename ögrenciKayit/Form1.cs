using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ögrenciKayit.Lib;

namespace ögrenciKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ögrenci ögrenci = new Ögrenci();
        Sınıf sinif = new Sınıf();

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    ögrenci.Ad = "Fatma ";
            //    ögrenci.Soyad = "Ünlü";
            //    ögrenci.No= "140208451";
            //    ögrenci.Sinif = "89";
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            //}

        }
        List<Ögrenci> ögrenciler = new List<Ögrenci>();

        private void btnKaydet_Click(object sender, EventArgs e)
           
        {
            Ögrenci ögrenci = new Ögrenci();
            try
            {

                ögrenci.Ad = txtAd.Text;
                ögrenci.Soyad = txtSoyad.Text;
                ögrenci.Sinif = txtSınıf.Text;
                ögrenci.No = txtNo.Text;
                ögrenci.DogumTarihi = dtpDogumTarihi.Value;

                ögrenciler.Add(ögrenci);

                lstKişiler.Items.Add(ögrenci);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata oluştu",  MessageBoxButtons.OK ,MessageBoxIcon.Error );
            }
        }
    }
}
