using BABankOOP.Banka;
using BABankOOP.Enums;
using BABankOOP.Insanlar.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Insanlar.Personeller
{
    public class Veznedar : Personel
    {
        public Veznedar(string Ad) : base(CalisanlarinGorevi.Veznedar, Ad)
        {
            List<Fis> fisler;
        }
      
    }
}
