using BABankOOP.Banka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Insanlar.Musteriler
{
    /// <summary>
    /// Kendine özgü bir uygulamaları yoktur ve doğrudan kullanamazlar. Soyut sınıflar temel alınarak türerilen alt sınıflar tarafından genişletilir. Ve soyut üyeler alt sınıflar tarafından uygulanır.
    /// </summary>
    public abstract class Musteri : Insan
    {
        /// <summary>
        /// Müşteri ile alakalı olan bütün propertyler tanımlanmıştır.
        /// </summary>
       
        public string AdSoyad { get; set; }
        public string TcNo { get; set; }
        public Fis Fisim { get; set; }      
        public IslemSonucu Sonuc { get; set; }
        public decimal Miktar { get; set; }
        public decimal Bakiye { get; set; }


        /*
        bu şekildede kulllanabiliriz

        public abstract void FisAl();
        */
    }

    
}
