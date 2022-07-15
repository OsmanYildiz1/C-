using System;

namespace dortislem
{
    class Program
    {
        static void Main(string[] args)
        {

            int toplama = 35 + 34;
            int cikarma = 35 - 34;
            int carpim = 35 * 34;
            // int bolme = 35 / 34;
            decimal bolme = 35m / 34; // ya da float 35f
            Console.WriteLine("Toplam"+ toplama+ "\n Çıkarma"+ cikarma+ "\n Çarpım"+ carpim+ "\n Bölme "+ bolme );

            int ilkSayi = 35;
            int ikinciSayi = 34;
            float bolmeIkinci = (float) ilkSayi / ikinciSayi; // ilk sayi float okunsun.
            Console.WriteLine("Bölme"+ bolmeIkinci);

            int mod = ilkSayi % ikinciSayi;
            Console.WriteLine("Mod işlemi= " + mod);

            int ornek1 = 5 + 6 * 7;
            int ornek2 = (5 + 6) * 7;
            Console.WriteLine("Örnek1: " + ornek1);
            Console.WriteLine("Örnek2 " + ornek2);

            // Öncelik: () -- üstel -- carpma ve bolme -- toplama cıkarma sagdan sola gider.


            int ucuncuSayi = ilkSayi + 5; 
            ucuncuSayi += 10;            //ucuncuSayi = ucuncuSayi + 10;
            Console.WriteLine(ucuncuSayi); //35+5+10 =50

            ucuncuSayi -= 10;
            Console.WriteLine(ucuncuSayi); //35+5+10-10=40

            ucuncuSayi *= 2;
            Console.WriteLine(ucuncuSayi); // 40*2 =80

            ucuncuSayi /= 5;
            Console.WriteLine(ucuncuSayi); // 80/5 =16

            int dorduncuSayi = 5;
            dorduncuSayi++; // 5+1=6
            Console.WriteLine(dorduncuSayi);

        
            dorduncuSayi--; // 6-1=5
            Console.WriteLine(dorduncuSayi);

            ++dorduncuSayi;
            Console.WriteLine(dorduncuSayi);

            --dorduncuSayi;
            Console.WriteLine(dorduncuSayi);

            Console.WriteLine("-----Örnekler------");


            // cm'den inche'e çevirme 1inch =2.54cm
            // m2'den sqfeet'e çevirme 1 m²=10.76 ft²
            // 150 cm olan bir ağacım 1000m2 arazimde tek başına duruyor.       //ALTERNATİF ÇÖZÜM
            /*
             * 
            float a = 2.54f; // 1 cm= 2.54 inch
            float b = 150 / a;  
            float c = 10.76f;       
            float d = 1000 * c;
            Console.WriteLine(b + "inch olan bir ağacım "+ d + "sqfeet arazimde tek başına duruyor" ); */

            int agac = 150;
            int alan = 1000;
            Console.WriteLine((agac / 2.54f) + "inch olan bir ağacım " + (alan*10.76f)+ "sqfeet arazimde tek başına duruyor");

            Console.ReadLine();
        }
    }
}
