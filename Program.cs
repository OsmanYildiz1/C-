using System;
using System.Collections;
using System.Collections.Generic;

namespace calisma5veriyapıları
{
    public struct Nokta
    {
        public int x { get; set; }
        public int y { get; set; }

        public override string ToString()
        {
            return $"{x},{y}";
        }

        // default contructor
        public Nokta(int X, int Y)  // structta doğrudan kullanılamayacağı için içine değişken tanımlayıp değerlerimizi atadık
        {
            x = X;
            y = Y;
        }

        // metot ekleyelim
        public void SetOrigin()
        {
            x = 0;
            y = 0;          
        }

        public void Degistir()
        {
            var gecici = x;
            x = y;
            y = gecici;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // struct - kullanma
            //Ogrenci ogr = new Ogrenci();
            //ogr.Numara = 10;
            //ogr.Adi = "Ahmet";
            //ogr.Soyadi = "Yılmaz";
            //ogr.Cinsiyet = true;

            // Alternatif kullanma
            //var ogr2 = new Ogrenci(){
                //Numara = 20, Adi = "Fatma", Soyadi = "Yıldız", Cinsiyet = false };

            // alternatif kullanım 3   
            // var ogr4 = new Ogrenci(40, "Asaf", "Karlıdag");


            var ogrenciListesi = new List<Ogrenci>() {
                 new Ogrenci(10,"Ahmet","Yılmaz", true),
                 new Ogrenci(20, "Fatma", "Yıldız", false),
                 new Ogrenci(30, "Mehmet", "Avşar", true),
                 new Ogrenci(40, "Asaf", "Karlıdag")
                 };

            //foreach (Ogrenci o in ogrenciListesi)
            //{
            //    Console.WriteLine(o);
            //}

            //  ogrenciListesi.ForEach(o => Console.WriteLine(o));

            var n1 = new Nokta(3,4);
            Console.WriteLine($"n1: {n1}");
            n1.Degistir();
            Console.WriteLine($"n1: {n1}");
         

            var n2 = n1;
            Console.WriteLine($"n2: {n2}");
            n2.x  *= -1;
            Console.WriteLine($"n1: {n1}");
            Console.WriteLine($"n2: {n2}");

            n1.SetOrigin();
            Console.WriteLine($"n1: {n1}");
            Console.ReadLine();
        }

        private static void yerlesikveritürleri()
        {
            // 8 bit integer - 1byte
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt limit       :{SByte.MinValue,20}");
            Console.WriteLine($"Üst limit       :{SByte.MaxValue,20}");
            Console.WriteLine($"Boyut           :{sizeof(SByte),20}");
            Console.WriteLine();
            Console.ReadKey();

            //unsigned 8 bit integer - 1byte
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt Limit       :{Byte.MinValue,20}");
            Console.WriteLine($"Üst Limit       :{Byte.MaxValue,20}");
            Console.WriteLine($"Boyut           :{sizeof(Byte),20}");
            Console.WriteLine();
            Console.ReadKey();

            //signed 16 bit integer- 2 byte
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt Limit       :{Int16.MinValue,20}");
            Console.WriteLine($"Üst Limit       :{Int16.MaxValue,20}");
            Console.WriteLine($"Boyut           :{sizeof(Int16),20}");
            Console.WriteLine();
            Console.ReadKey();

            //unsigned 16 bit integer- 2 byte
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt Limit       :{UInt16.MinValue,20}");
            Console.WriteLine($"Üst Limit       :{UInt16.MaxValue,20}");
            Console.WriteLine($"Boyut           :{sizeof(UInt16),20}");
            Console.WriteLine();


            //signed 32 bit integer- 4 byte
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt Limit       :{Int32.MinValue,20}");
            Console.WriteLine($"Üst Limit       :{Int32.MaxValue,20}");
            Console.WriteLine($"Boyut           :{sizeof(Int32),20}");
            Console.WriteLine();
            Console.ReadKey();

            //unsigned 32 bit integer - 4 byte
            Console.WriteLine(nameof(UInt32));
            Console.WriteLine("Alt Limit        :" + UInt32.MinValue, 20);
            Console.WriteLine("Üst Limit        :" + UInt32.MaxValue, 20);
            Console.WriteLine("Boyut            :" + sizeof(UInt32), 20);
            Console.WriteLine();
            Console.ReadKey();

            // .... bit double
            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt Limit       :{Double.MaxValue,20}");
            Console.WriteLine("Üst Limit        :" + Double.MaxValue, 20);
            Console.WriteLine("Boyut            :" + sizeof(Double), 20);
            Console.ReadKey();
        }
    }
}
