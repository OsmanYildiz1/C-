using System;
using System.Collections;

namespace calisma8hash
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hashtable uygulaması: web sitelerdeki baslığı urlye eklerkenki kurallara uygun hale getirmek
            
            // başlığı okuma
            Console.WriteLine("Başlık Giriniz: ");
            string baslik = Console.ReadLine();

            // kucultme
            baslik = baslik.ToLower();

            // Hashtable
            var karakterSeti = new Hashtable()
            {
                {'ç','c'},
                {'ı', 'i' },
                {'ö','o' },
                {'ü' , 'u'},
                {' ', '-'},
                {'\'','-' },
                {'ğ','g' },
                {'.','-' },
                {'?' ,'-' }
            };
            karakterSeti.Add('w', 'v');
            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }
            Console.WriteLine(baslik);
            Console.ReadLine();
        }

        private static void TemelHash()
        {
            // HASHTABLE
            // tanımlama
            Hashtable sehirler = new Hashtable();

            // ekleme
            sehirler.Add(6, "Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(55, "Samsun");
            sehirler.Add(23, "Elazığ");

            // Dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5} - {item.Value,10}");
            }
            // Sadece anahtarları alma
            Console.WriteLine("\nAnahtarlar (Keys)");
            var anahtarlar = sehirler.Keys; // ICollection anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            // Sadece Değerleri alma
            Console.WriteLine("Değerler (Values)");
            ICollection degerler = sehirler.Values;
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
            // Elemana Erişme
            Console.WriteLine("\nElemana Erişme");
            Console.WriteLine(sehirler[55]);

            // Eleman Silme
            Console.WriteLine("\nEleman silme");
            sehirler.Remove(23);
            // Yeni liste için dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5} - {item.Value,10}");
            }
        }
    }
}
