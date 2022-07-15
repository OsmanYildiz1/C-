using System;

namespace Classislemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Yeni inst = new Yeni();
            inst.birinci = 10; // eklenen classın elemanları . koyunca gözükür. atama vs. işlemleri ypaılabilir.
            inst.ikinci = 20;


            Console.WriteLine(inst.toplama());

            // Math Fonksiyonu kullanımı örnekler
            // 10 un 2. kuvveti
            // en kucuk değer
            // mutlak deger
            float bir = 10f;
            float iki = 2f; 
            Console.WriteLine("10'un 2. kuvveti tanımı " + Math.Pow(bir,iki)); // ilk sorunun alternatif çözümü
            Console.WriteLine("10'un 2. kuvveti "+ Math.Pow(10f, 2));
            Console.WriteLine("en küçük değer " + Math.Min(20,0));
            Console.WriteLine("mutlak değer " + Math.Abs(-25.4));

            Console.ReadLine();
            
        }
    }
    class Yeni
    {
        public int birinci;
        public int ikinci;

        public int toplama() // Fonksiyon
        {
            return birinci + ikinci;
        }

    }
}
