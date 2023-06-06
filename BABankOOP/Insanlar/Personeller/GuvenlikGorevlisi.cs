using BABankOOP.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Insanlar.Personeller
{
    public class GuvenlikGorevlisi : Personel
    {
        public GuvenlikGorevlisi(string Ad) : base(CalisanlarinGorevi.GuvenlikGorevlisi,Ad)
        {
           
        }

        [Description("Güvenlik görevlisinin görevi bankanın güvenliğini sağlamaktır.")]
        public override CalisanlarinGorevi Gorev => base.Gorev;
    }
}
