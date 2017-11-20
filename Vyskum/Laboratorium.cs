using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyskum
{
    partial class Laboratorium
    {
        public Pristroj laboratornyPristroj1;
        public Pristroj laboratornyPristroj2;
        public Veduci veduci;

        public void SpustVyskum()
        {
            veduci.VypisMeno();
            laboratornyPristroj1.VypisInformacieOPristroji();
            laboratornyPristroj1.Zapni();
            laboratornyPristroj2.VypisInformacieOPristroji();
            laboratornyPristroj2.Zapni();
        }
    }
}
