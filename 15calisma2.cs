using System;

namespace calismaicin2
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matris = new int[,] {
           {1,2,3 },
           {4,5,6 },
           {7,8,9 },
           };
            int toplam = 0;
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (matris[i,j] %3 == 0)
                    {
                        matris[i, j] = 0;
                    }
                    if (i ==j )
                    {
                      matris[i,j] =-1;
                    }

                    Console.Write($"{matris[i,j],4}");
                    toplam += matris[i, j];
                }
                
                Console.WriteLine();
                
            }
            Console.WriteLine($"Matrisn toplamı = " + toplam);
            Console.ReadLine();
        }

        private static void cokboyutludiziornegionemli()
        {
            float[,] matris = new float[,]  // virgüller dizinin kaç boyutlu olacağını ifade eder.
            { {1,2,3,4 },
              {4,5,6,7 },
              {4,5,6,9 },
              {4,5,6,9 },
            };
            float toplam = 0;
            for (int i = 0; i < matris.GetLength(0); i++)    // get lenght çok boyutlu bir dizinin belirli bir boyutunun uzunluğunu döndürür.0 satırı 1 sütunu ifade eder.
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)                          // indeks sırasına göre i ve j nin eşit oldugu değerler -1 olsun. i satır j sütun sayısını temsil eder.11 22 33 44
                        matris[i, j] = -1;                       // 1.satır 1. sütun, 2.satır 2.sütun gibi. Buda diagonal yani çarpraz olarak tanımlanır.


                    if (matris[i, j] % 2 == 0)               // 2 ye bölünebilenleri 0 yap
                        matris[i, j] = 0;


                    toplam += matris[i, j];
                    Console.Write($"{matris[i, j],5}");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Toplam:  {toplam}");
        }

        private static void dizirandomsayitekrar()
        {
            Console.WriteLine("Dizi boyutunu giriniz");
            int boyut = Convert.ToInt32(Console.ReadLine());

            var random = new Random();
            int[] dizi = new int[boyut];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = random.Next(1, 100);
            }
            foreach (int d in dizi)
            {
                Console.WriteLine($"{d,5} {d * d,5}");
            }
        }

        private static void dizilerandomsayıuretenprogram()
        {
            // kullanıcıdan dizi boyutunu alıp random sayılar üreten program
            Console.WriteLine("Dizi boyutunu giriniz: ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            var r = new Random();
            int[] sayilar = new int[boyut];
            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1, 10); // random next fonksiyonu ile 1 ie 10 arasında rastgele sayılar üretilecek.

            foreach (int s in sayilar)  // s dizinin o anki elemanını temsil eder
            {
                Console.WriteLine(s);
            }
        }

        private static void temeldiziler3()
        {
            int[] ornek = { 5, 10, 15, 20, 25, 28, 30, 49 }; // iki şekilde de atama yapılabilir.
            for (int i = 0; i < ornek.Length; i++)
            {
                Console.WriteLine($" Numaralar [{i}] = " +
                    $"{ornek[i]}");
            }
        }

        private static void temeldiziler2()
        {
            int[] dizi = new int[] { 4, 5, 1, 0, 29, 38 };
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }

        private static void temeldiziler()
        {
            int[] numaralar; // tanımlama 
            numaralar = new int[10]; // başlatma
            int[] nums = new int[3]; // ikisi bir arada
            nums[0] = 3;
            nums[1] = 5;
            nums[2] = 7;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        private static void icicefordongu()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();   
            }
        }

        private static void fordonguornek()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i < b; i++)
            {
                if (i % 3 == 0)
                    continue;   // 3 ün katının görürsen atla i yi arttır.
                else if (i == 100)
                {
                    break; // 100 olursa döngüyü kır.
                }
                Console.Write("{0,3}", i);
            }
        }

        private static void dowhileornek()
        {
            // klavyeden girilen sayıya kadar olan çift sayıları ekrana yazdır.
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            do
            {
                Console.WriteLine("{0,3} {1,3}", i, i * i);
                i = i + 2;
            } while (i <= n);
        }

        private static void whileazalan()
        {
            int i = 10;
            while (i > 0)
            {
                Console.WriteLine("{0, -3} {1, -3}", i, i * i);
                i--;
            }
        }

        private static void whileornek()
        {
            int sayac = 1;
            while (sayac <= 10)
            {

                Console.WriteLine("{0,-3} {1,-3}", sayac, sayac*sayac); // yan yana yaz ve her ifade için 5 karakterlik bosluk bırak. - ile yazılırsa sola hizalanır
                sayac++;
                // sayac +=1  sayac = sayac +1
            }
            Console.WriteLine("Döngü sonu");
        }
    }
}
