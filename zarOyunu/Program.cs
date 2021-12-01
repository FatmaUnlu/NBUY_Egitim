using System;

namespace zarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖDEV2
            do
            {

                Random rnd = new Random();
                int sayac = 0;
                int birinciZar = 0; 
                int ikinciZar = 0;
                int sayi = 0;

                Console.WriteLine("1-7 arası bir zar bilgisi seçin:");
                
                do
                {
                    try
                    {
                        sayi = int.Parse(Console.ReadLine());
                        if (sayi < 1 || sayi > 6)
                        {
                            throw new Exception(); // throw ile hata catchine atar.                        
                                          // Console.WriteLine("Yanlış giriş yaptınız. Belirtilen aralıkta bir sayı girin: ");

                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Yanlış giriş yaptınız. Belirtilen aralıkta bir sayı girin: ");
                    }
                    
                } while (true);

                
                do
                {

                    birinciZar = rnd.Next(1, 7);
                    ikinciZar = rnd.Next(1, 7);                   

                    sayac++;

                    Console.WriteLine("ilk zar :{0} , ikinci zar : {1} ", birinciZar, ikinciZar);
                    Console.WriteLine("{0}. denemede çift zar geldi ", sayac);

                    if (birinciZar == ikinciZar && birinciZar == sayi)
                    {
                        Console.WriteLine("{0}. denemede çift zar geldi ", sayac);
                        break;
                    }

                } while (true);

                Console.WriteLine("tekrar denemek için E ye basınız ");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;

            } while (true);



        }
    }
}
