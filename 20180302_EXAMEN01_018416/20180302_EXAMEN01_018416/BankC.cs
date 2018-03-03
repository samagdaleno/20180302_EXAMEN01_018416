using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_018416
{
    class BankC : Bank
    {
        String message;
        public void bankTransfer(string origin, string end, string sum)
        {
            message = "The transfer has been made from " + origin + " to " + end + ", by the amount: " + sum;
            notify(message);
        }
    }
}
