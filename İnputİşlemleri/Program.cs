using System; 

namespace İnputİşlemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Adınızı giriniz: ");
            //string ad = Console.ReadLine();
            //Console.WriteLine();

            /*
             * Kullanıcı girişleri
             * Veritabanı istekleri (CRUD)
             * Dosya işlemleri
             * Sunucu istekleri
             * Tür dönüşümleri
             *gibi durumlarda hata olma ihtimaline karşı mutlaka
             * Try - Catch | Error Handling kullanılmalıdır.
             */

            Console.Write("Lütfen 1 ile 100 arasında bir sayı giriniz: ");
            int girilenSayi = 0; //girilen sayiyi burda tanımlamamızın sebebi if bloğunun dışında da kullanılabilir olmasını sağlamak için. 
            try
            {
                girilenSayi = int.Parse(Console.ReadLine()); // parse kullanmam için string bir ifade gereklidir. Convert diğer veri tipleri için de kullanılabilir
                if (girilenSayi < 1 || girilenSayi > 100)
                {
                    throw new Exception("Girilen sayı 1-100 arasında değil."); // throw ile hata catchine atar.
                }

               // Console.WriteLine(girilenSayi * girilenSayi);
            }
            catch (OverflowException ex1)
            {
                Console.WriteLine("Girilen sayı çok büyük ya da çok küçük");
                //Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
            }
            catch (Exception ex) // tüm hataları kapsar. Sadece 1 hata catchi yazabiliriz exception ile. diğerlerini yazmamıza gerek olmaz. Fakat diğerlerini yazacaksak illaki exception catchini en alta yazmalıyız. Çünkü diğerlerini kapsadığı için diğerlerini kontrol etmeden bunun içine girer.
            {
                Console.WriteLine(ex.Message);
            }
            finally // finally her zaman çalışır hata olsa da olmasa da.
            {
                Console.WriteLine("Finally çalıştı");
            }

            Console.WriteLine("1-6 arası bir sayı giriniz");// bu uygulamada 1 ile 6 arasında olmasını kontrol etmiyor. yazı mı sayı mı onu kontrol ediyor ?
            int sayi2 = 0;
            string girilen = Console.ReadLine();
            if (int.TryParse(girilen, out sayi2)) //boolean bir ifade. Bunun içinde de try catch var. Catche düşmediyse true düştüyse false değeri döndürür.
            {

                Console.WriteLine(sayi2 * sayi2 * sayi2);
            }
            else
            {
                Console.WriteLine("Bir sayı girmeyi beceremedin");
            }
        }
    }
}
