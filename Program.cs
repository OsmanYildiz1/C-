using System;

namespace veritipleri
{
    class Program
    {
        static string d;
        static bool c; // true veya false olabilir. mantık operasyonlarında kullanılır.
        static int a; 
        // private ise başka bir classtan erişilemez. public olunca erişilebilir.
        static float b;
        static void Main(string[] args)
        {
            d = "string tipi birden fazla karakter alabilir.";
            c = true;
            b = 1.1f;
            a = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(4.0m);// değişken tanımlamadan decimal sayılar bu şekilde yazdırılabilir.
            Console.WriteLine(4.5f); //değişken tanımlamadan float sayılar bu şekilde yazdırılabilir.
            Console.WriteLine(c);
            Console.WriteLine(false); // değişken tanımlamadan bool değişkeni bu sekilde yazdırılabilir.s
            Console.WriteLine(d);

            float ondalikUcBasamakliSayi; // camel case
            float OndalikSayi; // pascal case
            decimal ondalik; // ondalık sayılar için diğer veri tipi
            string benimAdim;
            benimAdim = "Osman";
            Console.WriteLine(benimAdim);
            benimAdim = "Yildiz";           // deklerasyon örneği
            Console.WriteLine(benimAdim);

            //var tam; // bu şekilde kullanılamaz. tanımlarken değer ataması yapılmalıdır.
            var tam = true;
            Console.WriteLine(tam);
            var sayi = 1.6f;
            Console.WriteLine(sayi);

            // ÖRNEK: İzmirde bomba yedim ve tanesi 5 liraydı ve hava sıcaklığu 25.5 dereceydi
            string sehir="İzmir";
            int fiyat =5;
            float sicaklik= 25.5f;
            Console.Write(sehir+"de bomba yedim ve tanesi ");
            Console.Write(fiyat + " liraydı ve hava sıcaklığı ");
            Console.Write(sicaklik + " dereceydi");

            

            Console.ReadLine();
        }
    }
}
