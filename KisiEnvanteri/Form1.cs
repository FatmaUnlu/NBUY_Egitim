using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace KisiEnvanteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Kisi> kisiler = new List<Kisi>();

       // public object XmlSeialization { get; private set; }

        private void ListeyiDoldur()
        {
            lstKisiler.Items.Clear();

            foreach (Kisi kisi in kisiler)
            {
                lstKisiler.Items.Add(kisi);
                
            }
            KisiContext.Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KisiContext.Load();
            this.kisiler = KisiContext.Kisiler; //Referanslarını eşitledik KisiContext nesnesi programın basından kapanana kadar ramda kalır.
            ListeyiDoldur();
        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false; //çoklu dosya seçek istemiyorsak
            dialog.Title = "Bir fotoğraf seçiniz: ";
            dialog.Filter = "JPEG | *.jpeg; *.jpg"; // hangi dosya türlerini seçmek istiyosak onu ayarlıyoruz. *= uzantılı anlamaında.
            //dialog.InitialDirectory = "C"; //C dosyasında açılsın bilgisayarda demek.
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //bilgisayarda kayıtlı olan dosyalara erişmek için Enviroment

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbResim.ImageLocation = dialog.FileName; //image location ile internetten bir resim yolu da eklenebilir. 
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yenikisi = new Kisi()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                Telefon = txtTelefon.Text

            };

            if (pbResim.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbResim.Image.Save(resimStream, ImageFormat.Jpeg);
                yenikisi.Fotograf = resimStream.ToArray();
            }
            kisiler.Add(yenikisi);
            ListeyiDoldur();

        }
        private Kisi seciliKisi;
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return; //index çaıştığında null gelebilir. Hata verme.

           // Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem; //yukarıda secilikisi Değişkenini oluşturdugumuz için bunu yorum satırı yaptım
           seciliKisi = lstKisiler.SelectedItem as Kisi;

            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtTelefon.Text = seciliKisi.Telefon;
            dtpDogumTarihi.Value = seciliKisi.DogumTarihi;

            if (seciliKisi.Fotograf != null)
            {
                MemoryStream stream = new MemoryStream(seciliKisi.Fotograf);
                pbResim.Image = Image.FromStream(stream);
            }

        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {

           // Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;

            if (seciliKisi == null) return;

            
            seciliKisi.Ad = txtAd.Text;
            seciliKisi.Soyad = txtSoyad.Text;
            seciliKisi.Telefon = txtTelefon.Text;
            seciliKisi.DogumTarihi = dtpDogumTarihi.Value;

            if (pbResim.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbResim.Image.Save(resimStream, ImageFormat.Jpeg);
                seciliKisi.Fotograf = resimStream.ToArray();
            }

            ListeyiDoldur();
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Dışarı Aktar ";
            dialog.Filter = "Xml Format | *.xml"; // hangi dosya türlerini seçmek istiyosak onu ayarlıyoruz. *= uzantılı anlamaında.            
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //bilgisayarda desktopta kayıtlı olan dosyalara erişmek için Enviroment

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //listi Xmle serialize ediyoruz
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>)); //array list olsaydı onu yazacaktık type olarak ya da başka bişey
                TextWriter writer = new StreamWriter(dialog.FileName); //bir dosyaya yazacağız serialize olmuş verileri
                serializer.Serialize(writer, kisiler); //writer kisiler listesini yazacak
                writer.Close();
                MessageBox.Show($" {kisiler.Count} kadar kişi dışarı aktarıldı");
            }
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir Xml dosyası seçiniz: ";
            dialog.Filter = "Xml | *.xml"; // hangi dosya türlerini seçmek istiyosak onu ayarlıyoruz. *= uzantılı anlamaında.            
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //bilgisayarda desktopta kayıtlı olan dosyalara erişmek için Enviroment

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //listi Xmle serialize ediyoruz
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>)); //array list olsaydı onu yazacaktık type olarak ya da başka bişey
                XmlTextReader reader = new XmlTextReader(dialog.FileName);
                kisiler = (List<Kisi>)serializer.Deserialize(reader);
                MessageBox.Show($"{kisiler.Count}adert kişi içeri aktarıldı");
                ListeyiDoldur();
            }
        }

        private void jSONDışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Dışarı Aktar ";
            dialog.Filter = "JSON Format | *.json"; // hangi dosya türlerini seçmek istiyosak onu ayarlıyoruz. *= uzantılı anlamaında.            
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //bilgisayarda desktopta kayıtlı olan dosyalara erişmek için Enviroment

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //listi Json serialize ediyoruz
                FileStream fileStream = new FileStream(dialog.FileName, FileMode.OpenOrCreate); //dosya varsa içine kaydet yoksa oluşturup kaydet : openorcreate komutu ile 
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(kisiler, Formatting.Indented));
                writer.Close();
                writer.Dispose();
                MessageBox.Show($"{kisiler.Count}adert kişi dışarı aktarıldı");
            }
        }

        private void jSONİçeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir Xml dosyası seçiniz: ";
            dialog.Filter = "JSON | *.json"; // hangi dosya türlerini seçmek istiyosak onu ayarlıyoruz. *= uzantılı anlamaında.            
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //bilgisayarda desktopta kayıtlı olan dosyalara erişmek için Enviroment

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(dialog.FileName, FileMode.Open);
                StreamReader reader = new StreamReader(fileStream);
                string dosyaİcerigi = reader.ReadToEnd();
                kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaİcerigi);
                MessageBox.Show($"{kisiler.Count}adert kişi içeri aktarıldı");
                ListeyiDoldur();
            }
        }
    }
}
