using System;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int golsayisi = 0;
            string takimSeviyesi = ""; // takım seviyelerinin attıkları gole göre isimlendirildiği bir örnek
            Random gol = new Random();
            golsayisi= gol.Next(0, 5); // 0 ve 4 sayıları arasında gelebilir.


            switch (golsayisi)
            {
                case 1:
                    takimSeviyesi = "OK"; // 1 gol attıgında
                    break;
                case 2:
                    takimSeviyesi = "Güzel"; // 2 gol attıgında
                    break;
                case 3:
                    takimSeviyesi = "Harika"; // 3 gol attıfında
                    break;
                case 4:
                    takimSeviyesi="Waooow"; // 4 gol attığında
                    break;

                default:
                    takimSeviyesi="Kötü";
                    break;
                   

            }
            Console.WriteLine("Gol sayısı:"+ golsayisi+ " " + takimSeviyesi);
            Console.ReadLine();
        }
    }
}
