using PaymentMethod.Models.Payment.Abstracts;
using PaymentMethod.Models.Payment.Managers;
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

namespace PaymentMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] taksitler = new[] { 1, 2, 3, 6, 9, 12 };

        private decimal sepetTutari = new Random().Next(1000, 10000);

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPaymentMethod.DataSource = Enum.GetNames(typeof(PaymentsMethods)); //paymentsmethods isimli enumdaki sabitleri yani tanımlanan ödeme metotlarını cmb.PaymentMethod adlı comboboxa atar

            for (int i = 1; i <= 12; i++) //içine ay doldurma (12 tane)
            {
                cmbAy.Items.Add($"{i:00}"); //hep iki haneli görünsün 
            }

            //cmbYil da şuan ve 10 sene sonrasına kadar tarih yazsın ve iki basamağı görünsün:
            //for (int i = DateTime.Now.Year ; i < DateTime.Now.Year + 10; i++)
            //{
            //    cmbYil.Items.Add(i);

            //}

            //Ya da

            for (DateTime i = DateTime.Now; i < DateTime.Now.AddYears(10); i = i.AddYears(1))
            //100 günlük bir takvim oluşturman gerek mesela cumartesi pazar hariç. Bu şekilde yapıp if ile cumartesi pazar mı kontrolü yapabilirsin.
            {
                //cmbYil.Items.Add(i.Year);
                // cmbYil.Items.Add(i.Year.ToString().Substring(2));//son iki basamağını göstermesi için.
                cmbYil.Items.Add($"{i:yy}"); //yy datetime özel bir format.Bunu üstteki forda yapamazsın
            }

        }

        private Card yeniCard;
        private PaymentsMethods method;

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (yeniCard == null)
            //    yeniCard = new Card();

            /*            yeniCard = yeniCard ?? new Card();*/ //yeni kart null ise newlenecek
            yeniCard ??= new Card(); // bu da aynı

            //şunun gibi int a= 5; a= a+5 ; a+=5;

            method = Enum.Parse<PaymentsMethods>(cmbPaymentMethod.SelectedItem.ToString()); //Paymentmethod cmb sinde seçilen değeri stringe çevirip Enum olan Paymentsmethodstaki değerle eşleşip eşleşmediğini kontrol etmek için oluşturduğumuz method değişkenine atar.


            // PaymentsMethods method2 = (PaymentsMethods)Enum.Parse(typeof(PaymentsMethods), cmbPaymentMethod.SelectedItem.ToString()); //2. yöntem

            lstTaksitler.Items.Clear();

            this.Text = $"{ sepetTutari:c2}";

            if (method == PaymentsMethods.Debit)
            {
                lstTaksitler.Items.Add($"Tek Çekim - {sepetTutari:c2}"); //iki basamağını gösterir.
            }
            else if (method == PaymentsMethods.Credit)
            {
                foreach (int taksit in taksitler)
                {
                    lstTaksitler.Items.Add($"{taksit} * {(sepetTutari / taksit):c2}");
                }
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            IPayable paymentManager; //en az bağımlı olan yani interface ile çalışmak daha doğru

            switch (method)
            {
                case PaymentsMethods.Credit:

                    paymentManager = new CreditPaymentManager();
                    CreditPayment payment = new CreditPayment();
                    payment.Commision = 1.12m;
                    payment.Installment = taksitler[lstTaksitler.SelectedIndex];
                    payment.CustomerId = "123";
                    payment.Total = sepetTutari;
                    payment.CardInfo = creditCardBox1.CardInfo; //Credit Card Boxta CardInfo propertysi oluşturduktan sonra bu kısım ile alttaki yorum satırındakileri yazmamıza gerek kalmadı

                    //payment.CardInfo = new Card()  nesneyi oluştururken const. yapmadık diyelim bu şekilde de yapabilirz.object initilizer yöntem ile property doldurulması

                    // {
                    //User control eklemeden önce

                    //Year = 2021,   //card clasındaki propertyler
                    //CVC = txtCVV.Text,
                    //Mount = 11,
                    //NameSurname = txtAdSoyad.Text,
                    //Number = txtCardNumber.Text

                    //User Control Ekleyip Kendi propertylerimizi oluşturduktan sonra

                    //Year = int.Parse(creditCardBox1.Yil),
                    //CVC = creditCardBox1.Cvv,
                    //Mount = int.Parse(creditCardBox1.Ay),
                    //NameSurname = creditCardBox1.AdSoyad,
                    //Number = creditCardBox1.KartNo

                    //Credit Card Boxta CardInfo propertysi oluşturduktan sonra yukarıdakilere ihtiyaç kalmadan direkt cardınfo propertysi ile aynı işlem yapılabilir. (104.satır)

                    // };

                    paymentManager.Pay(payment);

                    break;

                case PaymentsMethods.Debit:
                    paymentManager = new DebitPaymentManager(); //hangisinden newlwnirse onun gibi çalışır. Debit...dan newlwndi onon gibi çalışacak

                    paymentManager = new CreditPaymentManager();
                    CreditPayment payment2 = new CreditPayment();
                    payment2.Commision = 1.12m;
                    payment2.CustomerId = "123";
                    payment2.Total = sepetTutari;
                    payment2.CardInfo = new Card()//nesneyi oluştururken const. yapmadık diyelim bu şşekilde de                                    yapabilirz. //object initilizer yöntem ile property doldurulması
                    {
                        Year = 2021,   //card clasındaki propertyler
                        CVC = txtCVV.Text,
                        Mount = 11,
                        NameSurname = txtAdSoyad.Text,
                        Number = txtCardNumber.Text
                    };

                    paymentManager.Pay(payment2);


                    break;


                default:
                    return;
            }
            if (paymentManager.State == MessageStates.Success)
            {
                MessageBox.Show("Ödemeniz Başarılı");
            }
            //Nullable<int> a = null
            int? a = null;
        }
        
        //ErrorProvider: Hatalı giriş yapıldığında hata simgesi vermek için
        private void creditCardBox1_AdSoyadHata(object sender, KeyPressEventArgs e)
        {
            ErrorProvider provider = new ErrorProvider(this);
            provider.SetError(creditCardBox1, $"Yanlış bir karakter girdiniz:{e.KeyChar}");
            provider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            this.Text = $"Yanlış bir karakter girdiniz:{e.KeyChar}";
            
        }

        private void creditCardBox1_AdSoyadHata(object sender, EventArgs e)
        {

        }
    }
}
