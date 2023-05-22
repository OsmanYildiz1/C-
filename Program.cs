using System;
using System.Collections.Generic;

namespace calisma13Dictionary
{
    public class Personel
    {
        public Personel(string adi, string soyadi, decimal maas)
        {
            Adi = adi;
            Soyadi = soyadi;
            Maas = maas;
        }

        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal Maas { get; set; }

        public override string ToString()
        {
            return $"{Adi,-10} {Soyadi,-15} {Maas,-10}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary - PErsonel classını kullanarak listeyi kullanalım
            var personelListesi = new Dictionary<int, Personel>()
            {
                {110, new Personel("Mehmet","Sonsöz", 7500) },
                {120, new Personel("Ahmet","Can", 9000) }
            };
            personelListesi.Add(100, new Personel("Zeynep", "Çoşkun", 5000));
            foreach (var item in personelListesi)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

        private static void DictionaryTemelleri()
        {
            // Dictionary -- Şehirler arası telefon kodlarını içeren sözlük yapısı örneği
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332,"Konya" },
                {424,"Elazığ" },
                {466,"Artvin" },
                {422,"Malatya" }
            };

            // Ekleme
            telefonKodlari.Add(322, "Adana");
            //telefonKodlari.Add(322, "Osmaniye");    // anahtar aynı olamaz
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");

            // Erişme
            telefonKodlari[466] = "Artvin";

            // containKey 
            if (!telefonKodlari.ContainsKey(312))   // telefon kodlarında anahtarlarda 312 yoksa
            {
                Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi");
            }
            // containsvalue
            if (!telefonKodlari.ContainsValue("Malatya"))   // yukarıya malatyada eklediğimiz için burası calısmaz
            {
                Console.WriteLine("\aMalatya'nın kod bilgisi tanımlı değil");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni kod eklendi");
            }

            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            Console.WriteLine();
            // silme
            telefonKodlari.Remove(322);
            Console.WriteLine("\aAdana silindi");
            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }
        }
    }
}
