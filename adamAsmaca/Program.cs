using System;

namespace adamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, hak=0, bilinen=0 ;
            Random rnd = new Random();
            string[] kelimeler = new string [] { "Araba" , "Masa" , "Bilgisayar" , "Kalem" , "Telefon" , "Kitap" , "Buzdolabı" , "Kablo" } ;
            sayi = rnd.Next(kelimeler.Length); // en fazla dizinin uzunluğu kadar rastgele bir sayı olustur
            string secilenKelime = kelimeler[sayi]; //o rastgele sayııya göre dizinin elemanlarından birini seç
            double puan = secilenKelime.Length * 100; 
            char[] ekran = new char[secilenKelime.Length]; //kelimenin uzunluğu kadar char tipinde bir dizi harfleri turmak için

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                ekran[i] = '-';
            }
            do
            {
                foreach (char harf in ekran)
                {
                    {
                        Console.Write(harf + " ");
                    }
                   
                    Console.WriteLine();
                    Console.WriteLine($"{puan:#.00} puan. {hak} hakkınız kaldı");
                    Console.WriteLine("Tahmin: ");
                    string tahmin = Console.ReadLine();


                    if (string.IsNullOrEmpty(tahmin) && tahmin.Length == 1)
                    {

                    }
                }

            } while (true);
                
            }

        }
    }

