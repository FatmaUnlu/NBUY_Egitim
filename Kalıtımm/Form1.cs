using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtımm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Kare k1 = new Kare(10); //buraya parametreli constructor olduğu için 10 yazdık. Bu x parametresi olmadan çalışmaz sadece parametreli
            //                        //constructor varsa.Ancak overloading yapaarsak kullanabiliriz parametresiz

            //k1.x = 10; //bunu yazınca karenin kenarını veriyoruz. Bu olmazsa hataa verebilirdi referans tip olup default değeri olmayanlarda
            //double kareAlanı = k1.AlanHesapla();
            //MessageBox.Show("Karenin Alanı: " + kareAlanı);


            //Dikdörtgen d1 = new Dikdörtgen(3, 4);
            //double dikdortgenAlani = d1.AlanHesapla();
            //MessageBox.Show("Dikdörtgenin Alanı:" + dikdortgenAlani);


            ////Sekil sekil1 = new Sekil();      //bu şekilde hangi şekil için geçerli belli değil kare mi dikdörtgen mi? abstract kullanarak new alması engelleniyo sekil sınıfının. karışmaması için
            ////sekil1.x = 20;
            ////double alan = sekil1.AlanHesapla(); 



            Kare k1 = new Kare(10);    //Sekil k1 = new Kare(10); bu şekilde de yazabilirz aynı şey. buna polymorphism denir.
            Kare k2 = new Kare(5);
            Dikdörtgen d1 = new Dikdörtgen(3,4);
            Dikdörtgen d2 = new Dikdörtgen(5, 12);
            Daire da1 = new Daire(7);
            Daire da2 = new Daire(9);
            DikÜcgen u1 = new DikÜcgen(6, 8);
            DikÜcgen u2 = new DikÜcgen(10, 24);

            lstsekiller.Items.Add(k1);
            lstsekiller.Items.Add(k2);
            lstsekiller.Items.Add(d1);
            lstsekiller.Items.Add(d2);
            lstsekiller.Items.Add(da1);
            lstsekiller.Items.Add(da2);
            lstsekiller.Items.Add(u1);
            lstsekiller.Items.Add(u2);

        }

        private void lstsekiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstsekiller.SelectedItem == null) return; //hiç birşey seçili değilse aşağıdaki kodlara geçmeyecek
            
           // Sekil seciliSekil =lstsekiller.SelectedItem as sekil
            Sekil seciliSekil = (Sekil)lstsekiller.SelectedItem;


            if (seciliSekil is Kare)
            {

            }
            else if(seciliSekil is Dikdörtgen)
            {
                Dikdörtgen dd = seciliSekil as Dikdörtgen;
            }
            //else if (seciliSekil is Daire)
            //{
            //    Daire dd = seciliSekil as Daire;   // Daire clasına özel bir şeye ulaşabilmek için.polymorphism ile sadece ortak özelliklere erişebiliriz. Farklı özelliklere bu yöntemle. Bunu kısaca aşağıdaki gibi de yazabiliriz
            //}
            else if (seciliSekil is Daire dd)
            {
                this.Text = dd.Cap().ToString();
            }


            lblDetay.Text = $"Alanı:{seciliSekil.AlanHesapla()}\n Çevresi: {seciliSekil.CevreHesapla()}\n Köşegen Uzunluğu:{seciliSekil.KosegenHesapla()}"; 
            
            
            
            
            //polymorfizm: görünüşleri aynı çalışmaları farklı. Hepsi şekil tipinde görünüyor ama kare dikdörtgen vs.var içinde. Çağırırken şekil diye çağırıyorum çünkü bir sınıf altında toplayabiliyoruz bunları yani hepsi şekil diye ana bir sınıfa dahil edebiliriz. Ödeme işlemleri bildirim mekanizmları, farklı tekniklerle çalışan anı işi yapan işlemler oldugunda cok kullanılır.

        }
    }
}
