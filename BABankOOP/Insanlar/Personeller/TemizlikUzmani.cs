using BABankOOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Insanlar.Personeller
{
    public class TemizlikUzmani : Personel
    {
        public TemizlikUzmani(string Ad) : base(CalisanlarinGorevi.TemizlikUzmani, Ad)
        {

        }
    }
}
