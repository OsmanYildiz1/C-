using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            // 20'ye kadar sayı olan bir zar
            // 15 ile 20 arasında büyük zarar
            // 10 ile 15 arasında orta zarar
            // 5 ile 10 arasında zarar yok
            // 0 ve 5 arasında ise kendime zarar
            // 4. veya 5. zar 18 üstü gelirse ek zarar verecek

            Random zar = new Random(); // Random fonksiyonunu çağırdık.
            int birinciAtis= zar.Next(0, 20);   // next ile sayı aralığını belirledik. 5 zar atışı yaptırdık
            int ikinciAtis = zar.Next(0, 20);
            int ucuncuAtis = zar.Next(0, 20);
            int dorduncuAtis = zar.Next(0, 20);
            int besinciAtis = zar.Next(0, 20);

           
            Console.WriteLine("Birinci Atış " + birinciAtis);
            Console.WriteLine("İkinci Atış " + ikinciAtis);
            Console.WriteLine("Üçüncü Atış " + ucuncuAtis);
            Console.WriteLine("Dördüncü Atış " + dorduncuAtis);
            Console.WriteLine("Beşinci Atış " + besinciAtis);

            float ortalama = (birinciAtis + ikinciAtis + ucuncuAtis + dorduncuAtis + besinciAtis) / 5f;

            Console.WriteLine("Ortalama:  " + ortalama);

            if (ortalama > 15)
            {
                Console.WriteLine("Büyük zarar verdin");
            }
            else if (ortalama <= 15 && ortalama > 10) // && ve operatörü, || veya operatörü
            {
                Console.WriteLine("Orta zarar verdin");
            }
            else  if (ortalama > 5 && ortalama <= 10)
            {
                Console.WriteLine("Zarar yok");
            }
            else if (ortalama <= 5 && ortalama>2 )
            {
                Console.WriteLine("Kendine zarar verdin");
            }
            else
            {
                Console.WriteLine("2den küçük olduğunda çalışacak");
            }
            if(dorduncuAtis>=18 || besinciAtis>=18)
            {
                Console.WriteLine("Ek zarar verdiniz");
            }
            if(ortalama >10)
            {
                if (birinciAtis > 10)
                {
                    if (ikinciAtis > 15)
                    {
                        Console.WriteLine("Nested if orneği");
                    }
                    else if (ikinciAtis > 12)
                    {
                        Console.WriteLine("İkinci 12'nin üzerinde");
                    }
                }

            }


        
            Console.ReadLine();

            /* ÖRNEK TEKRARI
            Random rnd = new Random();
            int birinciatis = rnd.Next(1, 25);
            int ikinciatis = rnd.Next(1, 25);
            int ucuncuatis = rnd.Next(1, 25);

            float ortalama = (birinciatis + ikinciatis + ucuncuatis) / 3;

            Console.WriteLine("Birinci atış:" + birinciatis);
            Console.WriteLine("İkinci atış: " + ikinciatis);
            Console.WriteLine("Üçüncü atış " + ucuncuatis);
            Console.WriteLine("ortalamanız: " + ortalama);

            if (ortalama >= 20)
            {
                Console.WriteLine("+100 damage");
            }
            else if (ortalama < 20 && ortalama >= 10)
            {
                Console.WriteLine("+25 damage");
            }
            else if (ortalama >= 5 && ortalama < 10)
            {
                Console.WriteLine("Saldırınız bloklandı");
            }
            else
            {
                Console.WriteLine("-25 damage");
            }

            Console.ReadLine();
            */


        }
    }
}
