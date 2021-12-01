using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ögrenciKayit
{
    class Ögrenci
    {
        #region Fields
        private string _ad;
        private string _soyAd;
        private string _ögrenciNo;
        private string _sinif;
        private DateTime _dogumTarihi;
        private int _yas;
        #endregion

        #region properties 
        public string Ad
        {
            get
            {
                return _ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower();
            }

            set
            {
                _ad = value;
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Ad kısmı boş bırakılamaz");
                }
                foreach (char item in value)
                {
                    if (char.IsDigit(item) || char.IsControl(item) || char.IsPunctuation(item) || char.IsSymbol(item))
                        throw new Exception("Ad kısmına harf dışında bir karakter girdiniz! ");
                }
                if (value.Length > 50)
                    throw new Exception("Adın boyutu 50 karakteri geçmemelidir.");
            }

        }

        public string Soyad
        {

            get
            {
                return _soyAd.Substring(0, 1).ToUpper() + _soyAd.Substring(1).ToLower();
            }
            set
            {
                _soyAd = value;

                if (string.IsNullOrEmpty(value))
                    throw new Exception("Soyad alanı boş bırakılamaz.");
                if (value.Length > 50)
                    throw new Exception("Soyad 50 karakterden büyük olamaz");
                foreach (char item in value)
                {
                    if (!char.IsLetter(item))
                        throw new Exception("Soyad kısmında istenmeyen bir karakter girdiniz. Tüm karakterler harf olmalı");

                }


            }
        }


        public string No
        {
            get
            {
                return _ögrenciNo;
            }
            set
            {
                _ögrenciNo = value;

                if (!(value.Length == 9))
                    throw new Exception("Ögrenci No 9 haneli olmalıdır.");
                foreach (char item in value)
                {
                    if (!char.IsDigit(item))
                    {
                        throw new Exception("Ögrenci No kısmına rakam hahrici bir karakter girilemez!");
                    }
                }

                if (!value.StartsWith("1"))
                    throw new Exception("Ögrenci no su 1 ile başlamalıdır");
            }
        }
        #endregion
        #region

        public string Sinif
        {

            get
            {
                return _sinif;
            }
            set
            {
                _sinif = value;

                if (string.IsNullOrEmpty(value))
                    throw new Exception("Bu kısım boş bırakılamaz");

                if (!(value.Length == 3 || value.Length == 2))
                {
                    throw new Exception("En az iki en fazla 3 karakterli bir giriş yapmalısınız.");
                }
                if (value.Length == 2)
                {

                    if (!(char.IsDigit(value, 0)))
                    {
                        throw new Exception("ilk karakter rakam olmalıdır.");

                    }
                    if (!(char.IsLetter(value, 1)))
                    {
                        throw new Exception("ikinci karakter harf olmalıdır.");

                    }

                }
                if (value.Length == 3)
                {
                    //char eleman = Convert.ToChar(value);
                    if (!(char.IsDigit(value, 0) || char.IsDigit(value, 1)))
                    {
                        throw new Exception("ilk iki karakter rakam olmalıdır.");

                    }
                    if (!(char.IsLetter(value, 2)))
                    {
                        throw new Exception("üçüncü karakter harf olmalıdır.");
                    }


                }
            }
        }
        #endregion
        public DateTime DogumTarihi { get; set; }

        public int Yas
        {
            get
            {
                return DateTime.Now.Year - this.DogumTarihi.Year;
            }
        }
        public DateTime OlusturulmaZamani { get; private set; }
        public override string ToString()
        {
            return $"{ this.Ad} - {this.Soyad } - { this.Sinif}- { this.No}- { this.Yas}";
        }


    }

}
