using System;
using System.Collections.Generic;

namespace calisma12linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkedList<T> Temelleri
            // Tanımlama
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");   // trabzon first oldu
            sehirler.AddLast("İstanbul");
            sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun"); // Orduyu bulup ordudan sonra samsunun gelmesini sagladık
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun"); // 3. elemanın öncesine giresunu ekle
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop"); // istanbulun öncesindeki yani samsundan sonraki (addafterdan dolayı) yere sinopu ekledik
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak");

            // Dönme
            foreach (string s in sehirler)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");
            Console.WriteLine();
            var eleman = sehirler.First;
            while (eleman!=null)    // eleman boş değilse
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;   // son elemana gelince son elemanın nexti boş olacağı için döngü kırılır.
            }
            Console.WriteLine();
            Console.WriteLine("Dönüş Güzergahı");
            Console.WriteLine();
            var sonEleman = sehirler.Last;
            while (sonEleman != null)
            {
                Console.WriteLine(sonEleman.Value);
                sonEleman = sonEleman.Previous; // ilk elemana gelince ilk elemanın previousu bos olacağı için döngü kırılır.
            }
            Console.ReadLine();
        }
      
    }
}
