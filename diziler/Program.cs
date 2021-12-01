using System;
using System.Collections;
using System.Collections.Generic;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //aynı tipte birden fazla değeri tutabildiğimi< veri tiplerine dizi adı verilir.
            // indexler 0 dn baslar mssql hariç tüm bilişimlerde[mssql hariç)f
            int[] sayilar = new[] { 3, 44, 6, 75, 34, 7, 9 };
            sayilar = new int[10];

            sayilar[0] = 3;
            sayilar[1] = 5;
            sayilar[2] = 6;
            sayilar[3] = 69;

            Console.WriteLine(sayilar.Length);
            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(maxValue: 100);
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }

            double[,] matris = new double[5, 2]; //matris oluşturma iki boyutlu dizi. iki boyutlu dizilerde for kullanmak daha mantıklı
            for (int i = 0; i < matris.GetLength(dimension: 0); i++)
            {
                for (int j = 0; j < matris.GetLength(dimension: 0); j++)
                {
                    matris[i, j] = rnd.NextDouble() * rnd.Next(maxValue: 1000);
                }
            }

            Array.Resize(ref sayilar, newSize: 20); //dizinin boyutunu içindeki verileri değiştirmeden değiştirmek için kullanılır. tek boyutlu dizilerde kullanılır

            //ArrayList
            // System.Collections.ArrayList Liste1 = new ArrayList(); diye de kullanılabilir. En tepeye using collectıons komutu eklemek istemezsek. 
            //istediğimiz tipte değikeni atayabilirz içine.

            ArrayList Liste1 = new ArrayList();
            Liste1.Add(123);
            Liste1.Add("Kamil");
            Liste1.Add(true);
            Liste1.Add(null);

            //List

            //Generic List
            List<int> Liste2 = new List<int>();
            Liste2.Add(25); //nesneyi neyle olulturduysanız öyle çalışır. Mesela intle oluşturduk intle çalışıt
            Liste2.Add(43);

            //linq

            //To Array
            //Liste1.ToArray // object arraye çevirir.
            //Liste2.ToArray //int arraye çevirir

        }
    }
}
