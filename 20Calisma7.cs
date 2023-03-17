using System;
using System.Collections;
using System.Collections.Generic;

namespace calismadizi7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array farklı tanımlamalar
            int[] sayilar = new int[] { 5, 3, 8, 10, 2,18,23,44,55,6,34,19 };
            var numbers = Array.CreateInstance(typeof(int), sayilar.Length);
            var arr = new ArrayList(sayilar);
            //numbers.SetValue(5, 0);
            //numbers.SetValue(3, 1);
            //numbers.SetValue(8, 2);       // buradaki değer atamasını döngüyle sayilar dizisinden alalım
            //numbers.SetValue(10, 3);
            //numbers.SetValue(2, 4);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    numbers.SetValue(sayilar[i], i);      // sayilar dizisinden kopyalama işlemi
            //}

            sayilar.CopyTo(numbers, 0); // belirtilen diziye belirtilen indis numarasından başlayıp kopyala
            Array.Sort(sayilar);    
            Array.Sort(numbers);
            Array.Clear(sayilar, 2, 2); // diziyi x indisten başlayıp y eleman kadar sil
            Console.WriteLine($"44'ü içeren ilk elemanın indis numarası = {Array.IndexOf(sayilar, 44)}");
            arr.Sort();
            


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"sayilar [{i}] = {sayilar[i],3} - " +
                    $"numbers[{i}] = {numbers.GetValue(i),3} " +
                    $"arr[{i}] = {arr[i],3}");

                // alternatif gösterim.  Console.WriteLine("sayilar[{0}] = {1} - numbers[{0}] = {2}",
                //    i, sayilar[i], numbers.GetValue(i));
            }

            
            Console.ReadLine();
        }
    }
}
