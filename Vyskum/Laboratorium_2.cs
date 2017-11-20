using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyskum
{
    partial class Laboratorium
    {
        public class Veduci
        {
            private string meno;
            private string priezvysko;

            public Veduci(string meno, string priezvysko)
            {
                this.meno = meno;
                this.priezvysko = priezvysko;
            }

            public void VypisMeno()
            {
                Console.WriteLine("Vedúci Laboratória\nMeno : {0}\nPriezvysko : {1}\n", meno, priezvysko);
            }

        }
    }
}
