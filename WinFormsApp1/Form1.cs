using Crm_Form.Formlar;
using Crm_Form.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crm_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //form1closigten sonra çalışır orda çıkan kutucukta tuşa bastıktan sonra
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Programı kapatmak istiyor musunuz?", "Dikkat, ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }


        //Coklu form için ana formda diğer formları bu şekilde tanımlayıp kontrollü nesne üretimi yapmalısın.
        //singelton araştır 
        private FrmDisariAktar _frmDisariAktar;
        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kontrollü nesne üretimi
            if (_frmDisariAktar == null || _frmDisariAktar.IsDisposed) // dışarı aktar formu boş değilse ve dispose edilmişse
                _frmDisariAktar = new FrmDisariAktar();
            _frmDisariAktar.MdiParent = this;//mdiparentının this oldugunu soyluyoruz. mdi acılan pencerenin ana pencerenn içinde açılmasını sağlayan form propertysi. Mdi parent ile biz tanıtıyoruz senin mdi parentın bu diye. Yani bu pencere form1 in içinde açılacak demek.bu kod satırı onu sağlayacak
            _frmDisariAktar.Show();
        }

        private FrmIceriAktar _frmIceriAktar;
        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kontrollü nesne üretimi"
            if (_frmIceriAktar == null || _frmIceriAktar.IsDisposed) // içeri aktar formu boş değilse ve dispose edilmişse
                _frmIceriAktar = new FrmIceriAktar();
            _frmIceriAktar.MdiParent = this;//mdiparentının this oldugunu soyluyoruz. mdi acılan pencerenin ana pencerenn içinde açılmasını sağlayan form propertysi. Mdi parent ile biz tanıtıyoruz senin mdi parentın bu diye
            _frmIceriAktar.Show();
        }

        public List<Kisi> Kisiler { get; set; } //formum çalıştıkça bu nesne elimde
        private void Form1_Load(object sender, EventArgs e)
        {
            var context = new Context();
            Kisiler = context.Kisiler;
            Console.WriteLine();
        }


        private FrmKisiEkle _frmKisiEkle;
        private void kisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmKisiEkle == null || _frmKisiEkle.IsDisposed)
            {
                _frmKisiEkle = new FrmKisiEkle();
                _frmKisiEkle.MdiParent = this;//mdiparentının this oldugunu soyluyoruz. mdi acılan pencerenin ana pencerenn içinde açılmasını sağlayan form propertysi. Mdi parent ile biz tanıtıyoruz senin mdi parentın bu diye
                _frmKisiEkle.Show();
            }
        }

        private FrmKisiGuncelle _frmKisiGuncelle;
        private void kisiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmKisiGuncelle == null || _frmKisiGuncelle.IsDisposed)
            {
                _frmKisiGuncelle = new FrmKisiGuncelle();
                _frmKisiGuncelle.MdiParent = this;//mdiparentının this oldugunu soyluyoruz. mdi acılan pencerenin ana pencerenn içinde açılmasını sağlayan form propertysi. Mdi parent ile biz tanıtıyoruz senin mdi parentın bu diye
                _frmKisiGuncelle.Kisi = Kisiler.Last();
                _frmKisiGuncelle.Show();
            }
        }

        FrmKisiListele _frmKisiListele;
        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_frmKisiListele == null) || _frmKisiListele.IsDisposed Dialogda bu özellik olmuyor.
            ////https://stackoverflow.com/questions/5233502/how-to-return-a-value-from-a-form-in-c
            _frmKisiListele = new FrmKisiListele();
            //alttaki staırı yazınca hata veriyor
            // _frmKisiListele.MdiParent = this;//mdiparentının this oldugunu soyluyoruz. mdi acılan pencerenin ana pencerenn içinde açılmasını sağlamak için. formda yani. Mdi parent ile biz tanıtıyoruz senin mdi parentın bu diye               
            _frmKisiListele.StartPosition = FormStartPosition.CenterScreen;
            _frmKisiListele.Kisiler = Kisiler;
            var result = _frmKisiListele.ShowDialog();

            if (result == DialogResult.OK)
            {
                var seciliKisi = _frmKisiListele.SeciliKisi;
                MessageBox.Show($"Seçili Kişi:{seciliKisi}");
            }
        }
    }
}
