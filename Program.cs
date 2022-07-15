using System;

namespace fordongu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int j = 1; j < 20; j+=2)
            {
                Console.WriteLine(j);
            }

            string[] siparisNo = {"google", "google2", "google3"};
            for (int i = siparisNo.Length-1 ; i >= 0; i--)
            {
                Console.WriteLine(siparisNo[i]);
            }

            Console.ReadLine();
        }
    }
}
