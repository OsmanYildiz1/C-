using System;
using System.Collections.Generic;

namespace calisma11Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // örnek:sesli harfler eklensin mi eklenmesin mi
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','o','ö','u','ü'
            };

            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();
            foreach (char k in sesliHarfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{k, -5} kuyruğa eklensin mi? [e/h] ");
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key==ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n {k,-5} kuyruğa eklendi");
                    Console.WriteLine($"Kuyruktaki eleman sayisi: {kuyruk.Count}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kuyruktan elemanların kaldırılması için Esc tuşuna basınız");
            Console.WriteLine();

            ConsoleKeyInfo kaldir;
            while (kuyruk.Count>0)
            {
                kaldir = Console.ReadKey();
                Console.WriteLine();
                if (kaldir.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkarılıyor.");
                    Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkarıldı");
                    Console.WriteLine($"Kuyruktaki eleman sayisi: {kuyruk.Count}");
                }
      
            }

            Console.WriteLine("\nKuyruktan çıkarma işlemi tamamlandı.");
            Console.ReadLine();
        }

        private static void Queuetemelleri()
        {
            //Sesli harfleri tutan bir kuyruk yapısı
            //Queue Tanımlama
            var karakterKuyrugu = new Queue<char>();

            // ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');
            Console.WriteLine($"Eleman sayısı: {karakterKuyrugu.Count}");

            var dizi = karakterKuyrugu.ToArray(); // diziye dönüştürdük

            // çıkarma
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
            Console.WriteLine($"{karakterKuyrugu.Dequeue()} kuyruktan çıkarıldı."); // listenin başındaki elemanı siler
            Console.WriteLine($"Eleman sayısı: {karakterKuyrugu.Count}");
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
        }
    }
}
