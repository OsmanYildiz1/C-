using System;
using System.Collections.Generic;

namespace calisma6veriyapılarıclass
{
    class Program
    {
        static void Main(string[] args)
        {
            OgretimElemani ogrGor = new OgretimElemani() {SicilNo=102, Adi="Osman",Soyadi ="Yıldız", Cinsiyet =true };
            OgretimElemani ogrGor1 = new OgretimElemani(103, "Ayça", "Küçükhayrat", false);

            // classları liste ile kullanımı
            var liste1 = new List<OgretimElemani>() {
                new OgretimElemani(100,"Ahmet", "Yalçın", true),
                new OgretimElemani(101,"Aylin", "Dağ", false),
                new OgretimElemani(102, "Mehmet", "Aydoğan", true),
                new OgretimElemani(103, "Servet", "Aydoğdu", true),
                new OgretimElemani(104, "Leyla","Aydın", false),
                new OgretimElemani(105, "Selim","Asilhan", true)
            };
            #region
            Console.WriteLine(ogrGor);
            Console.WriteLine(ogrGor1);
            Console.WriteLine();
            Console.WriteLine("Liste1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));

            List<OgretimElemani> liste2 = liste1;

            Console.WriteLine("Liste2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));

            #endregion

            liste2.Add(new OgretimElemani(106, "Öner", "Han", true));
            Console.ReadKey();

            liste1.RemoveAt(0);

            Console.WriteLine("Liste1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));

            Console.WriteLine("Liste2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));
            //Calisanlar calisan1 = new Calisanlar( 205, "Ahmet X", true);
            //Calisanlar calisan2 = new Calisanlar() { adsoyad = "Mehmet Naci", numara = 105, pozisyon = false };

            //Console.WriteLine(calisan1);
            //Console.WriteLine(calisan2);
            Console.ReadLine();


        }
    }
}
