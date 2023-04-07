using System;
using System.Collections;
using System.Collections.Generic;

namespace calisma9sortedlist
{
   
    public class Sehir: IComparable<Sehir> 
    {
        public int PlakaNo { get; set; }
        public string SehirAdi { get; set; }

        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }

        public override string ToString()
        {
            return $"{PlakaNo,-5} {SehirAdi,-15}";
        }

        public int CompareTo(Sehir other)   // IComperamble interfaceinden gelir. int bir değer döndürmeliyiz
        {
            if (this.PlakaNo<other.PlakaNo)
            {
                return -1;
            }
            else if (this.PlakaNo == other.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // List
            List<int> sayilar = new List<int>() { 53, 40, 14, 2, 3, 12, 15 };
            sayilar.Sort(); // listeyi sıralayalım
            sayilar.ForEach(s => Console.WriteLine(s)); // lambda ifadeleriyle yazdırma

            // Şehir Listesi
            var sehirler = new List<Sehir>()
            {
                new Sehir(6,"Ankara"),
                new Sehir(34,"İstanbul"),
                new Sehir(55,"Samsun"),
                new Sehir(23,"Elazığ"),
                new Sehir(44,"Malatya")
            };
            sehirler.Add(new Sehir(1, "Adana"));
            sehirler.Sort();
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.ReadLine();
        }

        private static void sortedlistuygulama()
        {
            // SortesList Uygulama: Kitap içeriklerini belirtme, key değeri sayfa numarası değer bilgisi icerik bilgisi olsun
            var kitapiceriği = new SortedList()
            {
                {1,"Önsöz" },
                {50,"Değişkenler" },
                {40,"Operatörler" },
                {60,"Döngüler" },
                {45,"İlişkisel Operatörler" }
            };
            Console.WriteLine("İçindekier");
            Console.WriteLine(new string('-', 25));

            Console.WriteLine($"{"Konular",-33}  {"Sayfalar",5}");

            foreach (DictionaryEntry item in kitapiceriği)
            {
                Console.WriteLine($"{item.Value,-33}  {item.Key,5}");
            }
        }

        private static void sorteslisttemelleri()
        {
            // SortedList - Temeller
            // Tanımlama
            SortedList list = new SortedList()
            {
                { 1,"Bir"},
                {2,"İki" },
                {3, "Üç" },
                {8,"Sekiz" },
                {5,"Beş" },
                {6,"Altı" },
                {10,"On" }
            };
            list.Add(4, "Dört");
            list.Add(7, "Yedi");

            // Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - { item.Value}");
            }

            Console.WriteLine("Listedeki elaman sayısı: {0}", list.Count);
            Console.WriteLine("Listenin kapasitesi: {0} ", list.Capacity);

            list.TrimToSize();
            Console.WriteLine("Listenin kapasitesi {0}", list.Capacity);

            // Erişme 
            // KEy
            Console.WriteLine(list[4]); // anahtar girilir değer alınır.
            // Index
            Console.WriteLine(list.GetByIndex(0)); // indeks girilir karsılık gelen değer alınır.
            // Get => Key
            Console.WriteLine(list.GetKey(0)); // indekse karsılık gelen anahtarı getirir.

            // Liste sonundaki elemanın değeri
            Console.WriteLine(list.GetByIndex(list.Count - 1));

            // Liste sonundaki elemanın anahtarı
            Console.WriteLine(list.GetKey(list.Count - 1));

            // listenin sadece anahtarlarını alma
            var anahtarlar = list.Keys;
            Console.WriteLine("\nAnahtarlar");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            // Listenin sadece değerlerini alma
            ICollection degerler = list.Values;
            Console.WriteLine("\nDeğerler");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Güncelleme");
            if (list.ContainsKey(1)) // 1'e karşılık gelen bir key var mı?
            {
                list[1] = "One";
            }

            // güncel dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - { item.Value}");
            }

            // silme 
            Console.WriteLine("Silme işlemi");
            list.Remove(7); // keyi 7 olan elemanı sil
            list.RemoveAt(0); // 0. indisdeki elemanı sil
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
