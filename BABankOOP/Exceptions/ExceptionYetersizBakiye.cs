using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Exceptions
{
    public class ExceptionYetersizBakiye : Exception
    {
        public ExceptionYetersizBakiye() : base("Bakiyeniz Yetersiz.")
        {

        }
    }
}
