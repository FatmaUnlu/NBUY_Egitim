using System;

namespace diziler_ödev
{
    class Program
    {
        static void Main(string[] args)
        {


            //ÖDEV1

            do
            {
                Random randomSayi = new Random();
                int sayi = randomSayi.Next(0, 100); //0-100 arası sayi

                Console.WriteLine("Tahmin edilen sayi: " + sayi);
                do
                {
                    try
                    {

                        Console.WriteLine("Sayıyı tahmin ediniz: ");
                        int tahmin = int.Parse(Console.ReadLine());
                        if (tahmin < 1 || tahmin > 100)
                        {
                            throw new Exception(); // throw ile hata catchine atar.
                        }
                        else if (tahmin > sayi)
                        {
                            Console.WriteLine("Tahminizi azltın");
                        }
                        else if (tahmin < sayi)
                        {
                            Console.WriteLine("Tahminizi artırın");
                        }
                        else if (tahmin == sayi)
                        {
                            Console.WriteLine("Tebrikler bildiniz: ");
                            break;
                        }


                    }
                    catch (Exception)
                    {

                        Console.WriteLine(" Lütfen 0 ve 100 arasında bir sayı değeri giriniz: ");
                    }

                } while (true);

                Console.WriteLine("Tekrar oynamak içi E tuşuna basınız");

                if (!"E".Equals(Console.ReadLine().ToLower())) ;
                break;

            } while (true);






        }
    }
}
