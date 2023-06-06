using BABankOOP.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Insanlar.Personeller
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public DateTime İseGirisTarihi { get; set; }
        public DateTime İstenCikisTarihi { get; set; }

        private CalisanlarinGorevi gorev;

        public Personel(CalisanlarinGorevi gorev, string Ad)
        {         
            İseGirisTarihi = DateTime.Now;
            this.Ad = Ad;
            this.gorev = gorev;
        }

        

        public virtual CalisanlarinGorevi Gorev
        {
            get { return this.gorev; }
        }
    }
}
