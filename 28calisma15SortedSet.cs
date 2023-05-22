using System;
using System.Collections.Generic;

namespace calisma15SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // SortedSet Küme İşlemleri
           var A = new SortedSet<int>(RastgeleSayiUret(15));
            var B = new SortedSet<int>(RastgeleSayiUret(5));
            #region yazdirma
            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();

            Console.WriteLine("B kümesi");
            foreach (int b in B)
            {
                Console.Write($"{b,5}");
            }
            #endregion
            // Birleşim - Union
            //A.UnionWith(B);
            //Console.WriteLine("\nA ve B kümesinin birleşimi");
            //foreach (var s in A)
            //{
            //    Console.Write($"{s,5}");
            //}
            //Console.WriteLine("\nToplam eleman sayisi: {0}", A.Count);
            //Console.WriteLine("\n");
            //Console.WriteLine();

            // A ve B kümesinin kesişimi
            //A.IntersectWith(B);
            //Console.WriteLine("\nA ve B kümesinin kesişimi");
            //foreach (var a in A)
            //{
            //    Console.Write($"{a,5}");
            //}
            //Console.WriteLine("\nKesişen toplam eleman sayisi: {0}", A.Count);

            // Fark alma A-B
            //Console.WriteLine("\n Sadece A'da olanlar A-B");
            //A.ExceptWith(B);
            //foreach (var item in A)
            //{
            //    Console.Write($"{item,5}");
            //}
            //Console.WriteLine($"\nA-B'deki eleman sayısı: {A.Count}");

            // kesişim dışındaki tüm elemanlar
            Console.WriteLine("\n Kesişim dışındaki elemanlar");
            A.SymmetricExceptWith(B);
            foreach (var item in A)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine($"\nKesişim dışındaki eleman sayısı: {A.Count}");

            A.IsSubsetOf(B); // A B'nin bir alt kümesi mi?
            Console.ReadLine();
        }

        static List<int> RastgeleSayiUret (int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0, 10));
            }
            return list;
        }

        private static void randomsayılarlaliste()
        {
            // Random sayılarla oluşan listenin alt kümesi
            var sayilar = new List<int>();
            var r = new Random();
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(0, 100));  // 0 ila 10 arasında random sayılar üretip listeye ekle.
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            // Listedeki benzersiz elemanları bulmak
            var listedekiSayiListesi = new SortedSet<int>(sayilar);
            Console.WriteLine("\nListedeki Sayıların Listesi\n");
            foreach (int sayi in listedekiSayiListesi)
            {
                Console.WriteLine($"{sayi,-3}");
            }
            Console.WriteLine("Listede {0} sayı var", listedekiSayiListesi.Count);
        }

        private static void SortedSetTemeller()
        {
            // Sorted Set
            // Tanımlama
            var list = new SortedSet<string>()
            {
                {"Efşan"}
            };
            // Ekleme   sorted sete eklenen değerler benzersiz olmalıdır.
            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet eklendi");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız");
            }
            Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet eklendi" : "Ekleme başarısız");
            list.Add("Sule");
            list.Add("Neslihan");
            list.Add("Fatih");
            list.Add("Fahrettin");

            // silme
            list.Remove("Sule");
            list.RemoveWhere(deger => deger.Contains("A")); // A içeren kayıtları sil
            list.RemoveWhere(deger => deger.StartsWith("F"));  // F ile başlayan kayıtları sil
            // Dolaşma
            Console.WriteLine("\nİsimler listesi\n");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n Eleman sayisi {0}", list.Count);
        }
    }
}
