namespace calisma5veriyapıları
{
    // tanımlama
    public struct Ogrenci
    {
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet = true) // yapılandırıcı metod
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;        // alternatif kullanım 3
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; } // property - özellik // değer okumak için get yazmak için set kullanılır.
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        // Bir metodu geçersiz kılmak, override
        public override string ToString()
        {
            return $"{Numara,-5}" +
                $" {Adi,-10}" +
                $"{Soyadi,-10}" +
               string.Format("{0, -10}", Cinsiyet == true ? "Bay" : "Bayan");
        }
      

    }

    

    
}
