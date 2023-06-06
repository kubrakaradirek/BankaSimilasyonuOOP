using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Exceptions
{
    public class ExceptionSiradaMusteriYok : Exception
    {
        public ExceptionSiradaMusteriYok() :base("Sırada müşteri yok.")
        {

        }
    }
}
