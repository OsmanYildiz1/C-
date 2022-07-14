using System;

namespace escapecharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello \nWorld!");// end of line alt satıra geçer.

            Console.WriteLine("Hello \tworld"); // bir tab kadar boşluk bırakır.

            Console.WriteLine(" \"Hello World\""); // "Hello World yazmak istersek?"

            Console.WriteLine("c:\\users\\lenovo\\appdata"); // c:\users\lenovo\appdata yazmak istersek? 
            // ikinci yol
            Console.WriteLine(@"c:\users\lenovo\appdata");

            string birinci = "Osman";
            string ara = "Unity xx ";
            string ikinci = "Unity Developer " + birinci;
            string ucuncu = "Unity Certified Instructor " + birinci + " " + "Yildiz";
            string dorduncu = $"{birinci} {ikinci}"; // string birleştirme

            string besinci = $@"c:\users\lenovo\{ birinci}\dataapp";
            Console.WriteLine(ucuncu); // string birlestirme
            // ya da 
            Console.WriteLine(ara+ birinci);
            Console.WriteLine(dorduncu);
            Console.WriteLine(besinci);
            Console.ReadLine();
        }
    }
}
