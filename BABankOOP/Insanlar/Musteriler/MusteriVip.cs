using BABankOOP.Banka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Insanlar.Musteriler
{
    public class MusteriVip :Musteri, IFisAl
    {     
        
        public void FisAl(Fis fis)
        {
            this.Fisim = fis;
        }
    }
}
