namespace calisma6veriyapılarıclass
{
    public class OgretimElemani
    {
        // Properties
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }
        
        // Default ctor parametre olmadanda çalışır.
        public OgretimElemani()
        {
          
        }

        public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilNo;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public override string ToString()
        {
            return $"{SicilNo,-5} " +
                $"{Adi,-5} " +
                $"{Soyadi,-5}" +
                string.Format("{0,10}", Cinsiyet == true ? "Bay" : "Bayan");
        }
    }

    public class Calisanlar
    {
        public int numara { get; set; }
        public string adsoyad { get; set; }

        public bool pozisyon { get; set; }

        public Calisanlar()
        {

        }
        public Calisanlar(int numara, string adsoyad, bool pozisyon = true)
        {
            this.numara = numara;
            this.adsoyad = adsoyad;
            this.pozisyon = pozisyon;
        }
        
        public override string ToString()
        {
            return $"{numara} " +
                $"{adsoyad} " +
                string.Format("{0,5}", pozisyon == true ? "Bay" : "Bayan");
        }
    }
}
