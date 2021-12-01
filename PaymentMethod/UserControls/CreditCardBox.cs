using PaymentMethod.Models.Payment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentMethod.UserControls
{
    public delegate void AdSoyadHataEvent(object sender, KeyPressEventArgs e); //eventı tanımlama birinci adım
    public partial class CreditCardBox : UserControl
    {
        public CreditCardBox()
        {
            InitializeComponent();
        }

        public string KartNo
        {
            //get { return txtKartNo.Text; }
            // set { txtKartNo.Text = value; }

            get => txtKartNo.Text;
            set => txtKartNo.Text = value;
        }
        public string AdSoyad
        {
            get => txtAdSoyad.Text;
            set => txtAdSoyad.Text = value;
        }

        public string Ay
        {
            get => cmbAy.SelectedItem.ToString();
            set
            {
                string format = $"{int.Parse(value):00}";
                int index = cmbAy.Items.IndexOf(format);
                if (index != 1)
                    cmbAy.SelectedIndex = index;
            }
        }

        public Card CardInfo => new Card() //Form1.cs de direkt Card ile tüm dolması gereken yerlere erişebilmek için böyle bir property oluşturduk
        {
            Year = int.Parse(this.Yil),
            CVC = this.Cvv,
            Mount = int.Parse(this.Ay),
            NameSurname = this.AdSoyad,
            Number = this.KartNo
        };


        public string Yil
        {
            get => cmbYil.SelectedItem.ToString();
            set
            {
                string format = $"{int.Parse(value): 00}";
                int index = cmbYil.Items.IndexOf(format);
                
                if (index != 1)
                    cmbYil.SelectedIndex = index;
            }
        }       
        public string Cvv 
        {
            get => txtCvv.Text;
            set => txtCvv.Text = value;
        }

        public event AdSoyadHataEvent AdSoyadHata; //eventı tanımlama 2. adım
        private void CreditCardBox_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 12; i++) //içine ay doldurma (12 tane)
            {
                cmbAy.Items.Add($"{i:00}"); //hep iki haneli görünsün 
            }

            for (DateTime i = DateTime.Now; i < DateTime.Now.AddYears(10); i = i.AddYears(1))
            {
                //cmbYil.Items.Add(i.Year);
                // cmbYil.Items.Add(i.Year.ToString().Substring(2));//son iki basamağını göstermesi için.
                cmbYil.Items.Add($"{i:yy}"); //yy datetime özel bir format.Bunu üstteki forda yapamazsın
            }
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txtadSoyada bir şet yazıldığı anda o karakter sayı mı char mı vs diye kontrol ediyoruz.
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;

                AdSoyadHata?.Invoke(sender, e); // AdSoyadHata eventını çağırıyorum. AdSoyad hatalı girişinde hata verecek, event
            }
        }
    }
}
