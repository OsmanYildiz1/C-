using System;

namespace HelloWorld
{
    class Program
       
    {   
        private int a; // başka bir classtan erişilemez : private. public olursa başka bir classtan erişilebilir.
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            // Console.Write("1.satır");
            // Console.Write("2.satır"); // write fonksiyonu alt satıra geçmeden yazdırır.
            Console.WriteLine("Bu bir satırdır.");
            Console.WriteLine("Bu da bir satırdır");
            Console.Write("\nBu bir sonraki satırdır.");
            Console.Write("\nBu en sondaki satırdır."); // Write komutu ile alt satıra geçmek için \n kullanılır.
            Console.ReadLine(); // ekranın kapanmaması için
         

        }
    }
}
