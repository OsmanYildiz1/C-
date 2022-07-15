using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            // ARRAY VE FOREACH
            string[] siparisNo = new string[3];
            siparisNo[0] = "AB123";
            siparisNo[1] = "GOOGLE2";
            siparisNo[2] = "GOOGLE3";

            siparisNo[0] = "GOOGLE"; // değişiklik

            int[] fiyat = { 250, 300, 700 };
            int toplamFiyat = 0;
            int say = 0;

            foreach(string siparis in siparisNo)
            {
                Console.WriteLine(siparis); // buradaki döngü siparis no dizisinin uzunluğu kadar yani 3 kere yazılacak
            }
            foreach (int tekilFiyat in fiyat)
            {
                toplamFiyat += tekilFiyat;
                say++;
            }
            Console.WriteLine(toplamFiyat+ " "+ say);



            //Console.WriteLine(siparisNo[0]);
            // *********************

            //string[] siparis = {"birincisiparis", "ikincisiparis", "ucuncusiparis" }; //ARRAY DİĞER YAZIM ŞEKLİ


            //Console.WriteLine(siparis.Length); // arrayin uzunluğu

            //int[] order = new int[4]; // ARRAY ORNEK
            //order[0] = 5;
            //order[1] = 10;
            //order[2] = 15;
            //order[3] = 20;


            //Console.WriteLine(order[3]);








            Console.ReadLine();
        }
    }
}
