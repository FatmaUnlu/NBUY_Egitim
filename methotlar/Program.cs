using System;

namespace methotlar
{
    class Program
    {
        static void Main(string[] args)

            
        {
            Console.WriteLine();
            double alan = AlanHesapla(kenar: 5);
            //bu methodun açıklaması aşağıdaki gibi çalışır

            alan = AlanHesapla(3, 4);
            alan = AlanHesapla(3d);
            int sonuc = Topla(Topla(3, 5), 5) + Topla(9, 7); //methodlar zincirleme kullaılabilir.
            int[] sayilar = { 3, 45, 6, 7, 8, 9, 0, 12, 3, 4, 5,4, 68, 9, 7 };
            sonuc = Topla(new[] { 3, 5, 6, 5, 8, 7, 4, 5, 5, 9, 8, 7, 7, 8, 32, 5, 5 }, 1);
            sonuc = Topla(sayilar, 1);
            sonuc = Topla(3, 5, 6, 5, 8, 7, 4, 5, 5, 9, 8, 7, 7, 8, 32, 5, 5);
            Console.WriteLine(sonuc);

        }
        /// <summary>
        /// Karenin alanının hesaplayan method
        /// </summary>
        /// <param name="kenar">Karenin bir kenarının uzunkuğu</param>
        /// <returns>Karenin alanı</returns>
        static double AlanHesapla(int kenar)
        {
            double sonuc = kenar * kenar;
            return sonuc;

        }
        /// <summary>
        /// Dİkdörtgeni alnanının hesaplanmasında kullanılır
        /// </summary>
        /// <param name="kenar1"></param>
        /// <param name="kenar2"></param>
        /// <returns>DidörtgeninAlanı</returns>
        static double AlanHesapla(int kenar1, int kenar2) //1 referance filan yazıyo ya onlar o methodun nerelerde kullanıldıgını kac kere kullanıldıgını söyler
        {
            return kenar1 * kenar2;
        }
        /// <summary>
        /// Çemberin alanını hesaplayan method
        /// </summary>
        /// <param name="r">yarıçap</param>
        /// <param name="pi">pi</param>
        /// <returns>Çemberin Alanı</returns>
        static double AlanHesapla( double r , double pi = Math.PI) //optionalparameter , hiç bir parametre girilmezse kullanılacak default parametre kullanılır.default parametreler her zaman en sonda yazılır.
        {
            return r * r * pi;
        }

        static int Topla (int a, int b)
        {
            return a + b;
        }

        static int Topla(int[] sayilar, int yuvarlama)
        {
            int sonuc = 0;
            foreach (int sayi in sayilar)
            {
                sonuc += sayi;
            }
            return sonuc;
        }
        static int Topla(double yuvarlama, params int[] sayilar) //params başta kullanılsaydı sonrasında yeni parametre girilmesine izin verilmeyecekti. Karışacağı neyin ne olduğu anlaşılmayacagı için:Çünkü paramsta nerde başlayıp nerde bittiğini ayırt edemeyiz
        {
            int sonuc = 0;
            foreach (int sayi in sayilar)
            {
                sonuc += sayi;
            }
            return sonuc;
        }

    }
}
