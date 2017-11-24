using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyskum
{
    abstract class Pristroj:IOvladaniePristroja
    {
        string status;
        protected int cisloPristroja;
        protected int typPristroja;


        public virtual void VypisInformacieOPristroji()
        {
            Console.WriteLine("Číslo prístroja : {0}", cisloPristroja);
        }

        protected abstract void VypisDetailneInformacie();

        public void Zapni()
        {
            status= "zapnutý";
            Console.WriteLine("Stav prístroja: " + status);
        }

        public void Vypni()
        {
            status = "vypnutý";
            Console.WriteLine("Stav prístroja: " + status);
        }
    }
}
