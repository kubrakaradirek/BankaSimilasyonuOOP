using BABankOOP.Insanlar.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Banka
{
    public class MusteriListesi
    {
        public List<Musteri> Liste { get; set; }

        public MusteriListesi()
        {
            Liste = new List<Musteri>();
        }   
    }
}
