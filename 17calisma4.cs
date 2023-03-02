using System;
using System.Collections.Generic;

namespace calismaiçin4
{
    class Program
    {
        static void Main(string[] args)
        {
            // referans tipli liste uygulaması
            List<string> sehirler = new List<string>() { "Ankara", "İstanbul", "Van", "Samsun", "Ordu" };

            // lambda expressions =>
            sehirler.ForEach(s => Console.WriteLine(s)); // foreach döngüsünü kısaca yazmanın yolu.

            Console.WriteLine(new string('-',50)); // 50 karakterlik çizgi oluşturur.

            var iller = sehirler;
            iller.ForEach(i => Console.WriteLine(i));
            
            sehirler.Add("Bursa");
            Console.WriteLine();
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();
            iller.ForEach(i => Console.WriteLine(i));
            Console.WriteLine();
            iller.Remove("Ankara");
            iller.ForEach(i => Console.WriteLine(i));
           

            Console.WriteLine();
            sehirler.ForEach(s => Console.WriteLine(s));

            Console.ReadLine(); 
        }

        private static void Degistir(ref int a, ref int b) // referanslar değişiklikleri sıfırlamadan işlemlere devam eder. adrese göre calısır.
        {
            //int x = 10;
            //int y = 20;
            //Console.WriteLine("{0},{1}", x, y);

            //Degistir(ref x, ref y);
            //Console.WriteLine("{0},{1}", x, y);
            //Console.WriteLine();
            int gecici = a;
            a = b;
            b = gecici;
            Console.WriteLine("{0},{1}", a, b);

        }
    }
}
