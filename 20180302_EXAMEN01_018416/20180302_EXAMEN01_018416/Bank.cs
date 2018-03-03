using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_018416
{
    abstract class Bank
    {
        List<IFormat> formatList;
        List<IProtocol> protocolList;
        List<IObserver> clients;

        public Bank()
        {
            this.formatList = new List<IFormat>();
            this.protocolList = new List<IProtocol>();
        }

        public void add(IObserver observer)
        {
            this.clients.Add(observer);
        }

        public void remove(IObserver observer)
        {
            this.clients.Remove(observer);
        }

        public void notify(Object o)
        {
            foreach (IObserver client in clients)
                client.update(this, o);
        }

        public void transfer()
        {
            foreach (IFormat format in formatList)
                Console.WriteLine(format);

            foreach (IProtocol protocol in protocolList)
                Console.WriteLine(protocol);
        }
    }
}
