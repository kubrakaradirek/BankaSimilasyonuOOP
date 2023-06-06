using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Enums
{
    public enum CalisanlarinGorevi
    {
        //anotation veya attribute
        [Description("Veznedarın görevi veznede müşterilerle ilgilenmektir.")]
        Veznedar,

        [Description("Güvenlik görevlisinin görevi bankanın güvenliğini sağlamaktır.")]
        GuvenlikGorevlisi,

        [Description("Temizlik uzmanının görevi bankanın temizliğini yapmaktır.")]
        TemizlikUzmani,

        [Description("Müdürün görevi bankadaki düzeni yönetmektir.")]
        Mudur
    }
}
