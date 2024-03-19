using System;
using System.Collections.Generic;

namespace GenericCollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rakamlar = new List<int>();

            rakamlar.Add(0);
            rakamlar.Add(1);
            rakamlar.Add(2);
            rakamlar.Add(3);
            rakamlar.Add(4);
            rakamlar.Add(5);
            rakamlar.Add(6);
            rakamlar.Add(7);
            rakamlar.Add(8);
            rakamlar.Add(9);

            foreach(int rakam in rakamlar)
            {
                Console.WriteLine(rakam);
            }

            Console.WriteLine("");
            
            List<Musteri> musteriler = new List<Musteri>();

            musteriler.Add(new Musteri(1, "Enes", "Bayram", "enes.bayram@gmail.com"));
            musteriler.Add(new Musteri(2, "Yakup", "Reçber", "yakup.recber@gmail.com"));
            musteriler.Add(new Musteri(3, "Bilal", "Çamur", "bilal.camur@gmail.com"));

            Console.WriteLine("Müşteriler listesinin eleman sayısı: " + musteriler.Count);
            musteriler.RemoveAt(0);
            
            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri);
            }

            Console.ReadLine();

        }
    }
}
