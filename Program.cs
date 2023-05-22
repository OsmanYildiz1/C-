using System;

namespace calisma18forornek
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    Console.WriteLine("{0,5} x {1,5} = {2,5}", i,j, i*j);
                }
                Console.WriteLine("\n--------------------\n");

            }
        }

        private static void for5()
        {
            // 1000'den 0'a kadar olan beş ve beşin katlarını yazdırma. kaç adet sayı oldugunu gösterme
            int sayac = 0;
            for (int i = 1000; i >= 0; i -= 5)
            {
                Console.Write("{0,5}", i);
                sayac++;
            }
            Console.WriteLine($"\n{sayac} tane sayı var.");
            Console.ReadLine();
        }

        private static void for4()
        {
            int tekToplam = 0, ciftToplam = 0;
            // 1'den 100' kadar olan tek ve çift sayıları ve toplamlarını yazdırma
            Console.WriteLine("Limit değeri giriniz");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} 'a kadar olan tek sayılar", limit);
            for (int i = 1; i < limit; i += 2)
            {
                Console.Write("{0,5}", i);
                tekToplam += i;

            }

            Console.WriteLine("\n{0}'a kadar olan çift sayılar", limit);
            for (int i = 0; i < limit; i += 2)
            {
                Console.Write("{0,5}", i);
                ciftToplam += i;

            }
            Console.WriteLine("\n1'den limite kadar olan tek sayıların toplamı" + tekToplam);
            Console.WriteLine("\n1'den limite kadar olan çift sayıların toplamı" + ciftToplam);
        }

        private static void for3()
        {
            //100'den baslayıp 5er 5er azalan
            for (int i = 100; i > 0; i -= 5)
            {
                Console.WriteLine("{0,5} > {1,5}", i, i * i);
            }
        }

        private static void for2()
        {
            // 5'er 5'er artan 
            for (int i = 5; i <= 100; i += 5)
            {
                Console.WriteLine("{0} > {1}", i, i * i);
            }
        }

        private static void for1()

        {
            // 1'den 100'e kadar olan sayılar ve kareleri
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"{i}'nin karesi = {i * i}");
            }
        }
    }
}
