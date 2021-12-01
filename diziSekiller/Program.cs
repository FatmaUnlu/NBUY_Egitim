using System;

namespace diziSekiller
{
    class Program
    {
        static void Main(string[] args)
        {
            //içi boş kare yapımı 

            //bool[,] matris = null;
            //try
            //{
            //    Console.WriteLine("Lütfen boyut girin: ");
            //    int girilenBoyut = int.Parse(Console.ReadLine());
            //    matris = new bool[girilenBoyut, girilenBoyut];


            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //for (int satir = 0; satir < matris.GetLength(dimension: 0); satir++)
            //{
            //    for (int sütun = 0; sütun < matris.GetLength(dimension: 1); sütun++)
            //    {
            //        if (satir == 0 || sütun == 0 || satir == matris.GetLength(dimension: 0) - 1 || sütun == matris.GetLength(dimension: 1) - 1)
            //        {
            //            matris[satir, sütun] = true;
            //        }
            //    }
            //}
            //// bu kısım hep aynı kalacak burası yıldız bastırma metodu
            //for (int satir = 0; satir < matris.GetLength(dimension: 0); satir++)
            //{
            //    for (int sütun = 0; sütun < matris.GetLength(dimension: 1); sütun++)
            //    {
            //        Console.Write(matris[satir,sütun] ? "*" : " ");
            //    }
            //    Console.WriteLine();
            //}

            //üçgen işareti

            //bool[,] matris = null;
            //try // kullanıcıdan bir değer aldığında hata olmasına karşın her zaman try catch dene
            //{
            //    Console.WriteLine("Lütfen boyut girin: ");
            //    int girilenBoyut = int.Parse(Console.ReadLine());
            //    matris = new bool[girilenBoyut, 2 * girilenBoyut - 1]; //şekil için gerekli matrisin boyutu [satır, sütun] ve2n-1 ile üçgenin tabanı hesaplanır
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //int x = matris.GetLength(dimension: 0); // matrisin satır uzunluğu
            //int y = matris.GetLength(dimension: 1); //matrisin sütun uzunluğu

            //for (int satir =  x-1 ; satir>=0 ; satir--)
            //{
            //    for (int sütun = 0; sütun < y ; sütun++)
            //    {

            //        matris[satir, sütun] = true; //hepsini yıldız yapıyor sonra belirli yerlere boşluk koyacak
            //        int boslukSayisi = (x - 1 - satir) * 2;

            //        int bosluk2 = boslukSayisi / 2;
            //        if (bosluk2 == 0) continue;

            //        for( int i = 0; i < bosluk2; i++)
            //        {
            //            matris[satir, i] = false;
            //        }
            //        for (int i = 0; i < bosluk2; i++)
            //        {
            //            matris[satir, i] = false;
            //        }
            //        for (int i = y - 1; i > y - 1 - bosluk2 ; i--)
            //        {
            //            matris[satir, i] = false;
            //        }
            //    }
            //}
            //// bu kısım hep aynı kalacak burası yıldız bastırma metodu
            //for (int satir = 0; satir < matris.GetLength(dimension: 0); satir++)
            //{
            //    for (int sütun = 0; sütun < matris.GetLength(dimension: 1); sütun++)
            //    {
            //        Console.Write(matris[satir, sütun] ? "*" : " ");
            //    }
            //    Console.WriteLine();
            //} 

            //üçgen matris

            bool[,] matris = null;
            try
            {
                Console.Write("Lütfen Boyutu Girin: ");
                int girilenBoyut = int.Parse(Console.ReadLine());
                matris = new bool[girilenBoyut, 2 * girilenBoyut - 1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            for (int satir = 0; satir < matris.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matris.GetLength(1); sutun++)
                {
                    if ((satir + sutun >= matris.GetLength(0) - 1 && sutun - satir <= matris.GetLength(0) - 1))
                    {
                        matris[satir, sutun] = true ;
                    }
                }
            }

            //ekrana yazdır

            for (int satir = 0 ; satir < matris.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matris.GetLength(1); sutun++)
                {
                    Console.Write(matris[satir, sutun] ? " X " : " ");
                }
                Console.WriteLine();
            }

            //Console.Write("Uzunluk : ");
            //int kenarUzunlugu = Convert.ToInt32(Console.ReadLine());
            //int ortaNokta = kenarUzunlugu - 1;
            //int taban = kenarUzunlugu * 2 - 1;
            //for (int i = 0; i < kenarUzunlugu; i++)
            //{
            //    for (int k = 0; k < taban; k++)
            //    {
            //        if ((i + k >= ortaNokta && k - i <= ortaNokta))
            //        {
            //            Console.Write("*");
            //        }
            //        else if (i == ortaNokta)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();



        }
    }
}
