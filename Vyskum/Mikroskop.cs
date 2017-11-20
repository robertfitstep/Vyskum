using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyskum
{
    sealed class Mikroskop:Pristroj
    {
        private int typPristroja;

        public Mikroskop(int cisloPristroja, int typPristroja)
        {
            this.cisloPristroja = cisloPristroja;
            this.typPristroja = typPristroja;
        }

        public override void VypisInformacieOPristroji()
        {
            base.VypisInformacieOPristroji();
            VypisDetailneInformacie();
        }

        protected override void VypisDetailneInformacie()
        {
            Console.WriteLine("Som Mikroskop typ : {0}", typPristroja);
        }
    }
}
