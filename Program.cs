using System;
using System.Collections.Generic;

namespace calisma10stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // girilen sayının birler basamağından push edilerek ekrana yazdırılması
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan sayı aldık

            Stack<int> sayiYigini = new Stack<int>();
            while (sayi>0)      
            {
                int k = sayi % 10;      // sayının 10'a bölümünden kalan birler basamağını verir. döngü döndükçe onlar, yüzler, binler...
                sayiYigini.Push(k);     // alınan her basamağı push ettik
                sayi = sayi / 10;       // en küçük basamağı aldıktan sonra atmış olduk
            }
            int i = 0;
            int n = sayiYigini.Count - 1;       // 1 eksik olmasının sebebi birler basamağının 10^0 olmasından dolayı yani n değeri basamak uzunluğunun bir eksiğini tutacak
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"\t{s,2} x {Math.Pow(10,n-i),7} = {s*Math.Pow(10,n-i),7}");   // pow ile sx10^3 gibi değerleri 10^0'a kadar verecek
                i++;                                                                    // i değeri arttıkça bir sonraki basamağa geçiş yapılacak
            }
            

            Console.ReadLine();
        }

        private static void stackuygulama1ascii()
        {
            var karakterYigini = new Stack<char>();

            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);   // 65 den 90'a kadar olan ascii karakterleri sırayla ekleyip yazdırdık
                Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi");   // push ettiğimiz veriyi peek ile gösterdik.
                Console.WriteLine($"Yığındaki eleman sayısı: {karakterYigini.Count}");
            }
            // ek bilgi
            var dizi = karakterYigini.ToArray();    // toArray metoduyla yığını diziye dönüştürebiliriz. char tipinde bir dizi elde edilmiş oldu.

            Console.WriteLine("Yığından çıkarma işlemi için bir tuşa basın");
            Console.ReadKey();

            while (karakterYigini.Count > 0)  // stack içindeki eleman sayısı 0 dan büyük olduğu sürece 
            {
                Console.WriteLine(karakterYigini.Pop() + " Yığından çıkarıldı"); // elemanları çıkarmaya devam et
                Console.ReadKey();
            }
        }

        private static void StackTemelleri()
        {
            // Stack Tanımlama
            var karakterYigini = new Stack<char>();

            //Ekleme
            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());

            // Çıkarma
            Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı");
            Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı");
            Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı");
        }
    }
}
