using System;
using System.Collections.Generic;

namespace calisma14SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sorted Dictionary ile kitap indeksi uygulaması- kavramlar key yani string, bahsedildiği sayfa numaralı, value ise bir listede 
            var kitapIndeks = new SortedDictionary<string, List<int>>()
            {
                {"HTML", new List<int>(){8,10,12} },
                {"CSS", new List<int>(){70,80,90} },
                {"jQuery", new List<int>(){3,5,15} },
                {"SQL", new List<int>(){70,80} },
            };
            kitapIndeks.Add("FTP", new List<int>() { 3, 5, 7 });
            kitapIndeks.Add("ASP.NET", new List<int>() { 50, 60 });

            foreach (var kavram in kitapIndeks)
            {
                Console.WriteLine(kavram.Key);
                kavram.Value.ForEach(s => Console.WriteLine($"\t > {s}"));
            }
            Console.ReadKey();
            kitapIndeks.Remove("HTML");
            foreach (var item in kitapIndeks)
            {
                Console.Write(item.Key);
                Console.WriteLine();
                item.Value.ForEach(v => Console.WriteLine($"\t\a {v,-10}"));
            }
            Console.ReadLine();
        }
    }
}
