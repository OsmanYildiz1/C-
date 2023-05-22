using System;

namespace calisma17cember
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dairenin yariçapı değerini giriniz:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dairenin çevresi = 2* {0} * {1} = {2}" ,cember.pi,r,cember.Cevresi(r));
            Console.WriteLine("Dairenin alanı = {0} * {1} * {1} ={2}",cember.pi,r,cember.Alani(r));
            Console.WriteLine("Dairenin 60 derecelik alanı = {0} * {1} * {1} ={2}",cember.pi,r,cember.Alani(r,60));
            Console.ReadLine();
        }
    }

    public class cember
    {
        // çemberin çevresi = 2 pi r. pi const olacak
        public const double pi = 3.14;
        // Console.WriteLine("2 * {0:F2} * {1:F2} = {2:F2}", pi,r, 2*pi* r); // :2F 2 karakter anlamına gelir

        public static double Cevresi(double r)
        {
            return 2 * pi * r;
        }
        public static double Alani(double r)
        {
            // dairenin alanı pi *r*r'dir
            return pi * r * r;
        }

        public static double Alani(double r, double aci) // overload etmiş olduk
        {
            // bir dairenin belirli bir parçasının alanını hesaplamak için: pi * r*r * açı/360
            return pi * r * r * aci / 360;
        }
    }
}
