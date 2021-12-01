using System;
using System.Collections.Generic;

namespace AdamAsmacaHoca
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int hak = 5, bilinen = 0;
                string[] sorular = { "zeytinburnu", "kahramanmaraş", "çanakkale", "hayrabolu" };
                // Random rnd = new Random();//bunu eklemeden şu şekilde yapabilriz. Tek bir kere kullanacagımıziçin sürekli random atama yapmayacagı için zar oyunu gibi.
                string seciliSoru = sorular[new Random().Next(sorular.Length)];
                double puan = seciliSoru.Length*100;
                char[] ekran = new char[seciliSoru.Length]; 
                //string [] kontrolTekrar

                //i lazım olduğu icin for kullanıyoruz   
                for (int i = 0; i < seciliSoru.Length; i++)
                {
                    ekran[i] = '-';
                }
                List<char> öncekiTahminler = new List<char>();
                do
                {
                    //ekranı yazdır
                    foreach (char harf in ekran)
                    {
                        Console.Write(harf + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"{puan:#.00} puan. {hak} hakkınız kaldı");
                    Console.WriteLine("Tahmin: ");
                    string tahmin = Console.ReadLine();   
                    
                    
                   
                    bool dogruMu = false;

                    if (!string.IsNullOrEmpty(tahmin) && tahmin.Length == 1) //harf tahmini
                    {
                        char harf = tahmin.ToLower()[0];
                        bool girildiMi = öncekiTahminler.Contains(harf);

                        if (!girildiMi)
                        {
                            for (int i = 0; i < seciliSoru.Length; i++)
                            {
                                if (seciliSoru[i] == harf ) //&& ekran[i] != harf) //harfin tekrar girilmesini engelleme ekran[i] !="-" .
                                {
                                    öncekiTahminler.Add(harf); //tekrar girilme boş bir dizi oluşturup girilen harfleri içine atıp kontrol edebiliriz.
                                    dogruMu = true;
                                    ekran[i] = harf;
                                    bilinen++;
                                }
                            } 
                        }
                    }
                    else if (!string.IsNullOrEmpty(tahmin))
                    {
                        if (seciliSoru == tahmin.ToLower())
                        {
                            dogruMu = true;
                            break;
                        }
                    }

                    if (!dogruMu)
                    {
                        hak--;
                        puan *= 0.85;
                        if (hak == 0)
                        {
                            break;
                        }
                    }
                    if (seciliSoru.Length == bilinen)
                    {
                        break;
                    }

                } while (true);

                if (hak == 0)
                {
                    Console.WriteLine("Kaybettiniz! Puan: 0");
                }
                else
                {
                    Console.WriteLine(seciliSoru);
                    Console.WriteLine($"Tebrikler kazandınız! Puanınız: {puan:#.00} Kalan hak: {hak}");
                }


                Console.Write("tekrar denemek için E ye basınız ");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;
            } while (true);
        }
    }
}
