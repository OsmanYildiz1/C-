using System;

namespace boolornekler
{
    class Program
    {
      // public static int y; // HEPSİNİ KAPSAR.
        static void Main(string[] args)
        {
            // Conditional Operator
            int sayi = 5;
            string isim = "Osman Yıldız";
            Console.WriteLine("a" == "a"); // a=a'mı? 2 tane string karşılaştırma aynıysa true
            Console.WriteLine("b" == "B"); // b = B'mi= False
            Console.WriteLine(1.2f == 1.3f); // 1.2 f eşit mi 1.3f'e ? false
            Console.WriteLine(1 == sayi); // 1, sayiya eşit mi?
            Console.WriteLine(1 != sayi); // 1, sayiya eşit değil mi? evet eşit değil yani true.
            Console.WriteLine(isim.Contains("n Y")); // .contains belirtilen stringin içindeki karakter var mı yok mu kontrol eder var ise true değeri döndürür.
            // sayım 6 ise ismim Osman olsun sayım 5 ise ismime Yıldız yazsın (Conditional Operator)
            Console.WriteLine(sayi == 5 ? "Osman" : "Yıldız"); // sayı 6 ise(?) Osman(True), değilse (:) Yıldız(false) 
            Console.WriteLine(sayi >= 5 ? 1 : 0); // sayi 5'e büyük eşitse 1 değilse 0

            Console.WriteLine("*****************GLOBAL VE LOCAL DEĞİŞKENLER***********************");

             int y=0; // buradaki tanımlama sayesinde yazabildik. GLOBAL
             int x = 5;
             if (x == 5)
              {
                y = 20; //LOCAL
               
              }
            Console.WriteLine(y); // y değişkeni local olduğu için burada yazamayız. daha üstte tanımlarsak yazabiliriz.

            Console.ReadLine();
        }
    }
}
