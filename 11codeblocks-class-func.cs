using System;
using Codeblocks.Topla; // namespace'i ekledik (kütüphane)

namespace Codeblocks
{
    class Program
    {
        static void Main(string[] args)
        {
            // CLASSLAR VE FONKSİYONLARDA KOD BLOKLARI
            int sayi = 0;
            sayi = Toplama.Toplam(50); //  Toplam(int a), int yerine 50 yazdık fonksiyonda 50+10 sonucu yazılır.
           // sayi += a; sayi += b; // bu şekilde anlamaz çünkü b toplam fonksiyonunun local değişkenidir.
            Console.WriteLine(sayi);
            Console.ReadLine();
        }

        /*static int Toplam(int a)
        {
            int b = 10;
            return a + b;
        }*/
    }
}
namespace Codeblocks.Topla
{
    class Toplama
    {
        public static int Toplam(int a)
        {
            int b = 10;
            return a + b;
        }
    }
}
