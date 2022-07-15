using System;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;                           // DO WHİLE ÖRNEĞİ
            //do
            //{
            //    sayi++;
            //    if (sayi == 7) continue; // continue bulunduğu yerden sonraki kodu es geçer
            //    Console.WriteLine(sayi);
                
            //    // break; anında döngüyü durdurur.
              

            //} while (sayi <10);
                
            while (sayi<10)
            {
                sayi++;
                if (sayi == 8) continue;
                Console.WriteLine(sayi);
              
            }


           
            Console.ReadLine();
        }
    }
}
