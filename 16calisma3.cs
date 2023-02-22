using System;
using System.Collections;
using System.Collections.Generic;

namespace calismaicin3
{
    class Program
    {
        public static void Main(string[] args)
        {
            double odenecekMiktar = SatisYap(50);
            Console.WriteLine(odenecekMiktar);

            var odenecekMiktar2 = SatisYap(100, .1);
            Console.WriteLine("{0,5:0.##}", odenecekMiktar2);

          
            Console.WriteLine("Serinin Toplamı = " + SeriToplami(1.2,35.4,45,2));
            Console.WriteLine("Metot bitti");
            Console.ReadLine();
        }

        /// <summary>
        /// Satış yapan fonksiyon
        /// </summary>
        /// <param name="miktar">Alış-veriş tutarı.</param>
        /// <returns> KDV eklenmiş toplam ödenecek miktar.</returns>
        static double SatisYap(double miktar=0)
        {

            return miktar * 1.18;
        }

        /// <summary>
        /// Satış yapan fonksiyon
        /// </summary>
        /// <param name="miktar">Alış-veriş tutarı</param>
        /// <param name="indirim">İndirim Oranı</param>
        /// <returns>KDV eklenmiş toplam ödenecek miktar</returns>
        static double SatisYap(double miktar, double indirim)
        {
            return (miktar * (1.0 - indirim)) * 1.18;
        }
        

        private static double SeriToplami(params double[] seri)
        {
            double toplam = 0;
            foreach (double s in seri)
                toplam += s;
             return toplam;
            // Console.WriteLine(" {0,5:0.##}", SeriToplami(5.50, 15.78, 25.49, 10.57, 50.45)); // 0, 5 eleman ve aralık saısını :0.## ise ondalıklı sayının virgülden sonra en fazla 2 karakter almasını sağlar.
        }

        public static int Karsilastir(int a, int b)
        {
            return a > b ? a : b; // eğer a b den büyükse a değilse b
            

        }

        static double KareAl(double sayi)
        {
            sayi = sayi * sayi;
            return sayi;
        }
        private static void Listeler()
        {
            // Listeler- Tanımlama
            List<int> sayilar = new List<int>() { 10, 15, 20 }; //  var sayilar = new List<int>(); şeklinde de yazılabilir.
            int x = 55;
            // int[] seri = new int[] { 70, 80, 90 };

            // ekleme 

            sayilar.Add(x);

            // dolaşma// diziyi listeye ekleme
            sayilar.AddRange(new int[] { 70, 80, 90 });
            //foreach (var item in seri) 
            //{
            //    sayilar.Add(item);
            //}



            // araya ekleme
            sayilar.Insert(3,0);
            sayilar.InsertRange(4, new int[] { 1, 31 });
            foreach (int s in sayilar)
            {
                Console.WriteLine($"{s,-5}");
            }


            // silme
            sayilar.RemoveAt(3); // 3. elemanı at
            sayilar.Remove(sayilar.IndexOf(55));
            foreach (int s in sayilar)
            {
                Console.Write($"{s,-5}");
            }
        }

        private static void arraylistislemleri()
        {
            // ArrayList Tanımlama
            ArrayList arrayList = new ArrayList() {     // var arrayList şeklinde de tanımlanabilir.
                10,"Btk Akademi", true, 'e'};   // ekleme işi bu sekilde de yapılabilir.

            // Ekleme
            //arrayList.Add(10);
            //arrayList.Add("BTK Akademi");
            //arrayList.Add(true);
            //arrayList.Add('e');


            // Dolaşma
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }


            // diziyi arrayliste ekleme
            int[] sayilar = new int[] { 23, 44, 55 };
            arrayList.AddRange(sayilar);
            Console.WriteLine();
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }

            // elemana erişme
            Console.WriteLine(arrayList[4]);

            // elemana erişme - atama
            int x = (int)arrayList[0];
            Console.WriteLine(x + 10);

            // eleman silme
            // arrayList.Remove(10);
            //  arrayList.RemoveAt(1); // 10 değeri atıldıktan sonra 1. elemanı sil
            arrayList.RemoveRange(3, 3); // 3. elemandan basla 3 elamanı sil
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
        }
    }

}
