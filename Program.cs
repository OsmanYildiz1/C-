using System;

namespace calisma19
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("n değerini giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new Dizi().Olustur(n);
            Dizi dizi = new Dizi();
            int[] tekSayilarDizisi = dizi.TekDiziOlustur(x);
            Dizi.Yazdir(tekSayilarDizisi);
            Console.WriteLine("Tek sayıların sayısı: {0,5}", dizi.TekSayilarinSayisi(x));

            int[] ciftSayilarDizisi = dizi.CiftDiziOlustur(x);
            Dizi.Yazdir(ciftSayilarDizisi);
            Console.WriteLine("Çift sayıların sayısı: {0,5}", dizi.CiftSayilarinSayisi(x));
            Console.ReadLine();
        }

        

     

     

        private static void rastgeledizi()
        {
            Random r = new Random();
            int[] array = new int[5];
            int[] square = new int[5];
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(0, 100);
                square[i] = array[i] * array[i];
                Console.WriteLine("{0} karesi = {1}", array[i], square[i]);
            }
        }
    }

    class Dizi
    {
        public int[] Olustur(int limit)
        {
            int[] sayilar = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.Write("{0,5}", sayilar[i]);

            }
            return sayilar;
        }
        public static int EnBuyuk(int[] dizi)
        // dizideki en büyük sayıyı bulma
        {
            int eb = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > eb)
                {
                    eb = dizi[i];
                }
            }
            return eb;
        }

        public static int EnKucuk(int[] dizi)
        // dizideki en küçük sayıyı bulma
        {
            int ek = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < ek)
                {
                    ek = dizi[i];
                }
            }
            return ek;
        }
        private static void Dizidekienbuyukveenkucuksayıyıbulma()
        {
            Console.WriteLine("n değerini giriniz");
            int limit = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.Write("{0,5}", sayilar[i]);

            }
            Console.WriteLine("\n Dizinin en büyük elemani: {0}", Dizi.EnBuyuk(sayilar));
            Console.WriteLine("\n Dizinin en küçük elemani: {0}", Dizi.EnKucuk(sayilar));
        }

        public static double AritmetikOrtalama(int[] x)
        {
            double toplam = 0;
            for (int i = 0; i < x.Length; i++)
            {
                toplam += x[i];
            }

            return toplam/x.Length;
        }

        /// <summary>
        /// parametre olarak aldığı dizinin standart sapmasını hesaplar
        /// </summary>
        /// <param name="x"> dizi </param>
        /// <returns>Standar Sapma </returns>
        public static double StandartSapma(int[] x)
        {
            double aritmetikOrtalama = AritmetikOrtalama(x);
            double t = 0, f = 0;
            
            for (int i = 0; i < x.Length; i++)
            {
                f = x[i] - aritmetikOrtalama;
                t += Math.Pow(f, 2);
            }
            return Math.Sqrt(t / (x.Length - 1));
        }
        /// <summary>
        /// Bir dizideki tek sayıların sayısı
        /// </summary>
        /// <param name="x"> Dizi</param>
        /// <returns> Tek sayı sayısı </returns>
        public  int TekSayilarinSayisi(int[] x)
        {
            int tekSayilarınSayisi = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i]%2==1)
                {
                    tekSayilarınSayisi++;
                }
            }
            return tekSayilarınSayisi;
        }
        /// <summary>
        /// Bir dizideki çift sayıların sayısı
        /// </summary>
        /// <param name="x"> Dizi</param>
        /// <returns> Çift sayı sayısı </returns>
        public  int CiftSayilarinSayisi(int[] x)
        {
            int ciftSayilarinSayisi = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    ciftSayilarinSayisi++;
                }
            }
            return ciftSayilarinSayisi;
        }

        /// <summary>
        /// Bir dizideki tek sayılardan yeni bir dizi oluşturma
        /// </summary>
        /// <param name="x">Dizi</param>
        /// <returns> Tek sayılardan oluşan dizi</returns>
        public int[] TekDiziOlustur(int[] x)
        {
            int[] tekDizi = new int[TekSayilarinSayisi(x)];
            int y = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i]%2==1)
                {
                    tekDizi[y] = x[i];
                    y++;
                }
                
            }
            return tekDizi;
        }

        /// <summary>
        /// Bir dizideki çift sayılardan yeni bir dizi oluşturma
        /// </summary>
        /// <param name="x">Dizi</param>
        /// <returns> Çift sayılardan oluşan dizi</returns>
        public int[] CiftDiziOlustur(int[] x)
        {
            int[] ciftDizi = new int[CiftSayilarinSayisi(x)];
            int y = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    ciftDizi[y] = x[i];
                    y++;
                }

            }
            return ciftDizi;
        }


        /// <summary>
        /// Parametre olarak aldığı diziyi ekrana yazdırır.
        /// </summary>
        /// <param name="x"></param>
        public static void Yazdir(int[] x)
        {
            Console.WriteLine();
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("{0,3}", x[i]);
            }
        }
    }
}
