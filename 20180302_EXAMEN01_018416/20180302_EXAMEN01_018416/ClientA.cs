using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_018416
{
    class ClientA : IObserver
    {
        List<string> banks = new List<string>();
        public ClientA() { }
        public void update(Bank obs, Object o)
        {
            String message = o.ToString();
            display(message);
        }

        public void display(String message)
        {
            Console.WriteLine("Client B:" + message);
        }
    }
}
