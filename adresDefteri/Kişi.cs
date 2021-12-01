using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adresDefteri
{
    class Kişi
    {
        //erişim belirleyici ( Access Modifiers)
        /*public
         * private:sadece tanımlandığı yer ver altınds kullanılır. private class olmaz çünkü classı zaten başka bi yerde kullanmak için yazıyoruz
         * internal
         * protected
         * internal protected //
         */

        //constructor :nesne oluşturulurken ekstra bir işlem yapmak istersek bunu kullanabiliriz. Örneğin nesnenin oluşturulma zamanı tutulmak istenirse
        public Kişi() //hiç yazmasak bile biz arka planda sistem oluşturur.
        {
            this.olusturulmaZamani = DateTime.Now ; //burda nesnenin oluşturulma zamanını tutar.Aşağıda oluşturulmaZamanı diye property yaptık
        }

        //Fields: _ ile yazılır
        /*
         */
        #region Fields

        private string _ad;
        private string _soyad;
        private string _kimlikNo; //kimlik no telefon numaraları aritmetik işlem yapmadığımız için string olacak.int kadar yer kaplaması mümkün değil bir de bunların o yüzden
      //  private DateTime _dogumTarihi;
      //  private int _yas; bu ikisi property kısmında kullanılmadığı iöin yorum satırı yaptım.

        #endregion


        //Encapsulation : fields ve propertyleri kapsar. Fieldste vs hangi tipte ise burdakinde de aynı tipte yazılır
        //property
        public string Ad //sadece set veya get kullanabilirsin. Aşağıdaki yapı bir propertydir.
        {
            set //value diye bir keyword gwlir
            {
                _ad = value; //neyi setlediysek o gelir. Form1cs de Fatma setledik mesela. value burda Fatma olur
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("kişinin ismi boş geçilemez");
                }
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))
                    {
                        throw new Exception(" kişinin isminde rakam bulunamaz ");
                    }
                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))
                        throw new Exception("kişinin adında geçersiz karakter bulunmaktadır");
                }
                if (value.Length > 50)
                    throw new Exception(" girilen ifade 50 karakterden büyük olmasın");

            }

            get //return olmalı
            {
                //for (int i = 0; i < _ad.Length; i++)
                //{
                //    if(i)
                //}

                return _ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower(); //0Dan bire kadar demek bu yani ilk harfi yalnızca,sonraki de 1 den sonra geri kalanını alıyor

            }

        }

        public string Soyad
        {
            get
            {
                return _soyad.Substring(0, 1).ToUpper() + _soyad.Substring(1).ToLower();
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("kişinin soyadı boş geçilemez"); //try catch yazmadık. kim kullanacaksa bu klası o düşünsün. Mesela form1.cs de bakıyoruz orada yazdık
                }
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))
                        throw new Exception("kişini soyadında rakam bulunamaz");

                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))
                        throw new Exception("kişinin soyadında geçersiz karakter bulunmaktadır");
                }
                if (value.Length > 50)
                    throw new Exception(" girilen ifade 50 karakterden büyük olmasın");

                _soyad = value;
            }
        }
        public string KimlikNo
        {
            get
            {
                return _kimlikNo;
            }
            set
            {               
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("kimlik no boş geçilemez");
                }
                foreach (char item in value)
                {
                    if (char.IsLetter(item))
                        throw new Exception("kişinin kimlik nosunda harf bulunamaz");

                    if (char.IsSymbol(item) || char.IsControl(item) || char.IsPunctuation(item))
                        throw new Exception("kişinin kimlikno da geçersiz karakter bulunmaktadır");
                }
                if (value.Length < 11 || value.Length > 11)
                    throw new Exception("kimlik nosu 11  rakam içermelidir");

                if (value.StartsWith("0"))
                    throw new Exception("kimlik numarası sıfır ile başlayamaz");

                if (!(int.Parse(value.Substring(9)) % 2 == 0))
                    throw new Exception(" kimlik numarasının son hanesi çift rakam olmalıdır");


                _kimlikNo = value; //yukarıdaki şartları geçerse value olarak atanır.
            }
        }

        //propertyler veriyi kaydetmez. Nerden getirileceğini vs. kaydeder
        //full propertylerde her zaman bir field vardır. Set get ve içinde fieldlar vardır.

        public DateTime DogumTarihi { get; set; } //eğer kontrol yapmıcaksak bu şekilde kullanabilirz. Sistem arka planda Datetime tipinde bir field oluşturacak ordan bakıcaz. //auto property
        //public DateTime DogumTarihi { get; set; } //prop + tab yapınca otomatik olur
        //yaş kontrol yapacaksan bu şekilde yapamazsın.
        //{
        //    get { return _dogumTarihi; }
        //    set {  _dogumTarihi = value;}
        //}

        public int Yas //sadece okuma yapılan property
        {
            get
            {
                return DateTime.Now.Year - this.DogumTarihi.Year; //this nesnesi hangi referansında çalışıyosa onu getir diye kullanılır. O anki nesneyi baz alır. this kişini o anki instace ındaki referansı kastediyo
            }
        }

        

        public DateTime olusturulmaZamani { get; private set; } //private olduğu için sadece o clasın içinden setlenebilir. Dışarıdan biri manipüle edemez bu şekilde.Dışarıdan setlenmeye kapalı

        public override string ToString() //adresDefteri.Kişi yazmasını önlemek için listboxa formda.Override ile o metodu eziyoruz burda ve değiştiriyoruz.overrde  = ezmek
        {
            return $"{ this.Ad} - {this.Soyad } - { this.Yas}"; 
            
            
        }
        interface IKisi { }

        enum Kisileri { }

    }
}
