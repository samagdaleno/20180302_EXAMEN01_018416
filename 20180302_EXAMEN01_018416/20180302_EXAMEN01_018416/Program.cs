using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_018416
{
    class Program
    {
        static void Main(string[] args)
        {
            BankA banka = new BankA();
            BankB bankb = new BankB();
            BankC bankc = new BankC();

            ClientA cla = new ClientA();
            ClientB clb = new ClientB();


            bankb.add(clb);

            bankb.bankTransfer("54654651", "554545", "$552");
            Console.ReadKey();


        }
    }
}
