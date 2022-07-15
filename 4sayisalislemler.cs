using System;

namespace sayısalişlemler
{
    class Program
    {
        static void Main(string[] args)   
        {
            int birinci = 34;
            int ikinci = 29;
            Console.WriteLine(birinci+ikinci); // 24+39
            Console.WriteLine(birinci + ikinci + "string"); // topla yanına stringi yaz.
            Console.WriteLine(birinci + "string" + ikinci); // yan yana yaz.
            Console.WriteLine(birinci + "string" + ikinci + 10 ); // 34 string 39 olmalı. hayır 34 string 2910 oldu.
            Console.WriteLine( (birinci +10 )+ "string" + ikinci + 10); // 44 string 2910 olmalı. doğru
            // parantez içinde olan işlem yapıldı, parantez içindeki tipler aynı int + int parantezde oldugu için toplandı.
            Console.ReadLine();
        }
    }
}
