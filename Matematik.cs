using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    public class Matematik
    {

        /// <summary>
        /// parametre alarak aldığı taban ve kuvvete baglı olarak ust alma işlemi gerçekleştiren metot
        /// </summary>
        /// <param name="taban">taban</param>
        /// <param name="kuvvet">üst</param>
        /// <returns></returns>
        public static double UstAlma(double taban, double kuvvet)
        {
            double s = 1;
            for (int i = 1; i <= kuvvet; i++)
            {
                s *= taban;
            }
            return s;
        }

        /// <summary>
        /// bir sayının tüm asal carpanlarını verir
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string AsalCarpanlar(int n)
        {
            string carpanListesi = "";
            int i = 2;
            // asal carpanları bulalım
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    carpanListesi += i.ToString() + ",";
                }
                else
                {
                    i++;
                }
            }
            carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1); // satır sonundaki virgülü kaldırmak
            return carpanListesi;
        }

        /// <summary>
        /// bir sayının tekrar etmeyen asal carpanlarını int bir dizi olarak verir
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>tekrar etmeyen asal carpanlar</returns>
        public static int[] AsalCarpanlar2(int n)
        {
            string carpanListesi = "";
            int i = 2;
            // asal carpanları bulalım
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    carpanListesi += i.ToString() + ",";
                }
                else
                {
                    i++;
                }
            }
            carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1); // satır sonundaki virgülü kaldırmak
            string[] carpanlar = carpanListesi.Split(",");

            string s = carpanlar[0];
            string y = s;
            for (i = 0; i < carpanlar.Length; i++)
            {
                if (!(s == carpanlar[i])) // carpanlar dizisindeki eleman s ye eşit değilse
                {
                    y = y + "," + carpanlar[i];
                    s = carpanlar[i];
                }
            }
            carpanlar = y.Split(',');
            int[] asalCarpanlar = new int[carpanlar.Length];

            for (i = 0; i < asalCarpanlar.Length; i++)
                asalCarpanlar[i] = Convert.ToInt32(carpanlar[i]);


            return asalCarpanlar; // asal çarpanların sadece tekrar etmeyenlerini döndürmüş olduk
        }

        /// <summary>
        /// listelerle asal carpanları bulma
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<int> AsalCarpanlar3(int n)
        {    
            var asalcarpanlar = new List<int>();
            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    asalcarpanlar.Add(i);
                }
                else
                    i++;
            }
            return asalcarpanlar;
        }

        /// <summary>
        /// Bir sayının asal carpanlarının toplamını verir
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>toplam</returns>
        public static int AsalCarpanlarınToplami(int n)
        {
            int[] asalCarpanlar = AsalCarpanlar2(60);
            int t = 0;
            for (int i = 0; i < asalCarpanlar.Length; i++)
            {
                t += asalCarpanlar[i];
            }
            return t; // 2 + 2 + 3 + 5
        }

        /// <summary>
        /// bir sayının asal carpalnlarının carpımını hesaplar
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>carpim sonucu</returns>
        public static int AsalCarpanlarınCarpimi(int n)
        {
            int c = 1;
            int[] asalCarpanlar = AsalCarpanlar2(n);
            for (int i = 0; i < asalCarpanlar.Length; i++)
            {
                c *= asalCarpanlar[i];
            }
            return c;
        }

        /// <summary>
        /// iki sayı arasındaki en küçük katı bulan okek programı
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static int OKEK(int s1, int s2)
        {
            int sonuc = 1;
            while (s1!=1 && s2!=1)
            {
                int bol = 2;
                for (int i = 1; i <(s1>s2?s1 : s2); i++) // s1, s2'den büyükse s1'e kadar değilse s2'ye kadar
                {
                    if (s1%bol==0 || s2%bol==0)
                    {
                        sonuc *= bol;
                        if (s1%bol==0)
                            s1 = s1 / bol;
                        if (s2 % bol == 0)
                            s2 /= bol;
                    }
                    else
                    {
                        bol++;
                    }
                }
            }
            return sonuc;
        }

        public static int OBEB(int s1, int s2)
        {
            int s = 1;
            int bol = 2;
            while (s1!=1 && s2!=1)
            {
                for (int i = 2; i < (s1>s2 ? s1 :s2); i++)
                {
                    if (s1 % bol == 0 || s2 % bol == 0)
                    {
                        if (s1 % bol == 0 && s2 % bol == 0)
                            s *= bol;
                        if (s1 % bol == 0)
                            s1 /= bol;
                        if (s2 % bol == 0)
                            s2 /= bol;
                    }
                    else
                        bol++;
                }
            }
            return s;

        }

        /// <summary>
        /// Faktöriyel hesabı yapar
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Faktoriyel(int n)
        {
            if (n<=1)
                return 1;
            int f = 1;
            for (int i = 2; i <=n ; i++)
            {
                f *= i;
            }
            return f;
        }

        public int[] IfadeyiDiziyeCevir(string ifade)
        {
            string[] bolunmusIfade = ifade.Split(',');  // virgül karakterlerini tarıyoruz

            int n = bolunmusIfade.Length;

            // sayısal dizi
            int[] sayisalDizi = new int[n];
            //ayristirma
            for (int i = 0; i < n; i++)
            {
                sayisalDizi[i] = Convert.ToInt32(bolunmusIfade[i]);
                Console.WriteLine("dizi[{0}] ={1}", i + 1, sayisalDizi[i]);
            }
            return sayisalDizi;
        }

        /// <summary>
        /// ikilik tabandan onluk tabana çeviren program
        /// </summary>
        /// <param name="ikilikSayi">string olarak girilen ikilen sayı</param>
        /// <returns>onluk tabandaki sayi</returns>
        public static int IkilikTabandanOnlukTabana(string ikilikSayi)
        {
      
            // uzunlugu belirle
            int n = ikilikSayi.Length;

            //  h er bir basamağın dizide tutulması
            int[] basamaklar = new int[n];
            // onluk karsiligi
            int sayi = 0;
            bool kontrol = true;
            for (int i = 0; i < n; i++)
            {
                if (!(ikilikSayi[i] == '0' || ikilikSayi[i] == '1'))
                {
                    Console.WriteLine("\a Hatalı Giris!");
                    kontrol = false;
                    break;
                }
                basamaklar[i] = (ikilikSayi[i] - '0'); // -'0' ın anlamı char ifadenin inte dönüşümü için
            }
            // 2 lik sistemden 10luk sisteme geçiş
            if (kontrol)
            {
                for (int i = 0; i < n; i++)
                    sayi += (int)Math.Pow(2, n - 1 - i) * basamaklar[i];
                Console.WriteLine("({0}) ikilik sayi = {1}", ikilikSayi, sayi);
            }

            return sayi;
        }

        /// <summary>
        /// Gİrilen ifadedeki sesli harf sayısını döner.
        /// </summary>
        /// <param name="ifade">stirng ifade</param>
        /// <returns>sesli harf sayısı</returns>
        public int SesliHarfSayisi(string ifade)
        {
            // sesli harf
            int sesliHarf = 0;
            for (int i = 0; i < ifade.Length; i++)
            {
                // kontrol
                if (ifade[i] == 'a' || ifade[i] == 'A' || ifade[i] == 'e' || ifade[i] == 'E' ||
                    ifade[i] == 'ı' || ifade[i] == 'I' || ifade[i] == 'i' || ifade[i] == 'İ' || ifade[i] == 'u' || ifade[i] == 'U'
                    || ifade[i] == 'ü' || ifade[i] == 'ü' || ifade[i] == 'o' || ifade[i] == 'O' || ifade[i] == 'ö' || ifade[i] == 'Ö')
                {
                    sesliHarf++;
                }
            }
            Console.WriteLine($"{ifade} ifadesinde {sesliHarf} sesli harf vardır.");

            return sesliHarf;
        }
    }
}

