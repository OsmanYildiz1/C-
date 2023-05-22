using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisma16uygulamalar
{
    class Sayi
    {
        public static bool TekMi(int n)
        {
            if (n%2==1)
            {
                return true;
            }
            return false;
        }

        public static bool CiftMi(int n)
        {
            if (n%2==0)
            {
                return true;
            }
            return false;
        }

        public static int MutlakDeger(int n)
        {
            if (n>0)
            {
                return n;
            }
            else if (n<0)
            {
                return n * -1;
            }
            else
            {
                return 0;
            }
        }

        public static bool AsalMi(int n)
        {
            if (n<=1)
            {
                Console.WriteLine("En küçük asal sayı 2'dir");
                return false;
            }
            bool kontrol = true;
            for (int i = 2; i < n; i++)
            {
                if (n%i==0)
                {
                    kontrol =false;
                    break;
                }
            }
            return kontrol;
        }
        public static int RakamlariToplami(int n)
        {
            int kalan = 0;
            do
            {
                kalan +=n % 10;
                n /= 10;
            } while (n>0);
            return kalan;
        }

        public static int nekadarolansayilarintoplamı(int n)
        {
            int toplam = 0;
            for (int i = 0; i <= n; i++)
            {
                toplam += i;
            }
            return toplam;
        }
        public static int nekadarolansayilarintoplamiformulle(int n)
        {
           
            return n*(n+1)/2;
        }
        public static int nekadarolanteksayilartoplami(int n)
        {
            int t = 0;
            for (int i =1; i <=n; i+=2)
            {
                    t += i;       
            }
            return t;

        }
        public static int nekadarolanteksayilartoplamiformulile(int n)
        {
            // 2n-1 formulünü uygulayacağız
            n++;
            n /= 2;
            return n * n;
        }
        public static int nekadarolanciftsayilartoplami(int n)
        {
            int t = 0;
            for (int i = 0; i <= n; i+=2)
            {
                t += i;
            }
            return t;
        }
        public static int nekadarolanciftsayilartoplamialternatif(int n)
        {
            int t = 0;
            for (int i = 2; i <= n; i++)
            {
                if (i%2==0)
                {
                    t += i;
                }
            }
            return t;
        }
        public static int nekadarolanciftsayilartoplamiformulle(int n)
        {
            // n* (n+1)
            n = n / 2;
            return n * (n + 1);
        }

    }
}
