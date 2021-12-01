using System;

namespace sayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random rnd = new Random();
                int tahminSayisi = 0, rastgeleSayi = rnd.Next(1, 101), giris=0;
                do
                {
                    Console.WriteLine("Rastgele sayi tahmin et");
                    try
                    {
                        giris = int.Parse(Console.ReadLine());
                    }
                    catch 
                    {

                        Console.WriteLine("Yanlış bir ifade girdiniz. ");
                        continue;
                    }
                    finally
                    {
                        tahminSayisi++;
                    }
                    
                    if (giris == rastgeleSayi)
                    {
                        Console.WriteLine("Tebrikler " + tahminSayisi + ".denemede bildiniz.");
                        break;
                    }
                    else if (giris > rastgeleSayi)
                    {
                        Console.WriteLine("Tahmininizi düşürün. ");
                    }
                    else
                    {
                        Console.WriteLine("Tahmininizi artırın");
                    }
                } while (true);

                Console.Write("tekrar denemek için E ye basınız ");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;
            } while (true);
        }
    }
}
