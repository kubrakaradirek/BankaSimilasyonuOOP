using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Exceptions
{
    public class ExceptionGecersizIslem : Exception
    {
        public ExceptionGecersizIslem() : base("Lütfen geçerli bir işlem yapınız.")
        {

        }
    }
}
