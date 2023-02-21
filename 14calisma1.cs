using System;

namespace calismaicin
{
    class Program
    {   
        // switch case örneği önemli enum kullanımı ve random fonksiyonu var
        enum Islemler   // enum yapısı liste oluşturma gibidir
        {
            Toplama =1,
            Cikarma =2,
            Carpma =3,
            Bolme=4
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Birinci Sayı..");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayı..");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Islemler secim = (Islemler) (new Random().Next(1,4)); // her defasında 1 ile 4 arasında random bir sayı üretir.

            switch (secim)
            {
                case Islemler.Toplama:
                    Console.WriteLine($"{sayi1} + { sayi2} = { sayi1 + sayi2}");
                    break;
                case Islemler.Cikarma:
                    Console.WriteLine($" {sayi1} - { sayi2} = {sayi1 + sayi2}");

                    break;
                case Islemler.Carpma:
                    Console.WriteLine($" {sayi1} *  { sayi2} = {sayi1 * sayi2}");

                    break;
                case Islemler.Bolme:
                    Console.WriteLine($" {sayi1} / { sayi2} = {sayi1  / sayi2}");

                    break;
                default:
                    Console.WriteLine("\a GEçersiz İşlem!");
                    break;
            }

            char k = 'e';
            switch (k)
            {
                case 'a':
                    Console.WriteLine("yanlis");
                    break;
                case 'b':
                    Console.WriteLine("yanlis");
                    break;
                case 'e':
                    Console.WriteLine("dogru");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }

        private static void ifelsecharnasıl()
        {
            var k = (char)Console.Read();   // read'den gelen ifade inttir, onu chara dönüstürdük
            if (char.IsDigit(k))
            {
                Console.WriteLine("Rakamdır");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine("Kücük karakterdir");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine("Büyük karakterdir");
            }
            else
            {
                Console.WriteLine("Bilinmeyen karakterdir");
            }
            Console.WriteLine(k);
        }

        private static void ifelsemutlakdegerornegi()
        {
            // kosul ile mutlak değer örneği
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"|{n}| = {n * -1}"); // mutlak değer almak için eksi sayıyı eksiyle çarpıp pozitife cevirdik
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
        }

        private static void kosulifelse()
        {
            // tek çift 
            Console.WriteLine("Bir sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " çifttir");
            }
            else
            {
                Console.WriteLine($" {n} tek bir sayıdır.");
            }
        }

        private static void operatorler()
        {
            int A = 20, B = 10;
            // Aritmetik operatörler
            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
            Console.WriteLine(A / B);
            Console.WriteLine(A % B);

            // İlişkisel operatörler
            Console.WriteLine(A < B);
            Console.WriteLine(A > B);
            Console.WriteLine(A >= B);
            Console.WriteLine(A <= B);
            Console.WriteLine(A == B);
            Console.WriteLine(A != B);

            Console.WriteLine(A > B && A < 5);
            Console.WriteLine(!(A > B && A < 5));

            Console.WriteLine(A < B || B > 5);
        }

        private static void basitconsolfonksiyonları()
        {
            var ifade = " Merhaba Programlama Dünyası.  ";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length);
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade[0]);
            Console.WriteLine(ifade[1]);
            Console.WriteLine(ifade[ifade.Length - 1]);
        }

        private static void OrtuluDegisken()
        {
            var ifade = Console.ReadKey(); // string veri okur.
            Console.WriteLine(ifade.Key);
            Console.WriteLine(ifade.KeyChar);
            Console.WriteLine(ifade.Modifiers);
        }

        private static void escapecharachters()
        {
            string ifade = @"C:\user\oyildiz";
            string ifade2 = "btk \nakademi \nprıgramlama";  // alt satıra geçer
            string ifade3 = "btk \aakademi \aprıgramlama";  // alert sesi verir
            string ifade4 = "btk \takademi \tprıgramlama"; // bir tab bosluk bırakır


            Console.WriteLine(ifade);
        }

        private static void BasitDegiskenOrnegi()
        {
            int sayi = 5;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi + 2);
            Console.WriteLine(sayi * sayi);
        }

        private static void NewMethod()
        {
            string isim = "Ahmet";

            Console.WriteLine("Merhaba " + isim + ".");

            isim = "Mehmet";
            Console.WriteLine("Merhaba Sayın " + isim + ".");
        }
    } 
}
