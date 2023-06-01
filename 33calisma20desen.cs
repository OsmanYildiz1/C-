using System;
using calisma19;

namespace ConsoleApp1
{
    class strngdesenex
    {
        static void Main(string[] args)
        {
            Dizi d = new Dizi();
            

            Console.ReadLine();
        }

 

        private static void ascii()
        {
            for (int i = 32; i <= 126; i++)
            {
                Console.Write("{0,5}", (char)i);

                if (i % 5 == 0)
                    Console.WriteLine();
            }
        }

    }

    class stringler
    {
        /// <summary>
        /// desen oluşturucu
        /// </summary>
        /// <param name="c">karakter tanımı</param>
        /// <param name="n"> tekrar sayısı</param>
        public static void Desen1(char c='*', int n =5)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0,10}", new string(c, i));

            }
        }

        /// <summary>
        /// Desen oluşturucu2
        /// </summary>
        /// <param name="c">karakter</param>
        /// <param name="n">döngü sayısı</param>
        public static void Desen2(char c='-', int n =4)
        {
            for (int i = n; i>=0 ; i--)
            {
                Console.WriteLine("{0}", new string(c,i));
            }
        }

        public static void KarakterSeti(int baslangicIndisi=65, int bitisIndisi=90, int satirKSayisi=5)
        {
            for (int i = baslangicIndisi; i <= bitisIndisi; i++)
            {
                Console.Write("{0,5}", (char)i);
                if(i % satirKSayisi ==0)
                    Console.WriteLine();
            }
        }

        public static void stringfunctions()
        {
            string ifade = " Afacan ";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length);
            Console.WriteLine(ifade.Trim());
            Console.WriteLine(ifade.Trim().Length);
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade.Clone());
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.Replace('a', 'e'));
        }
    }
}
