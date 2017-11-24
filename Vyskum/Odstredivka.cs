using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyskum
{
    sealed class Odstredivka:Pristroj
    {

        public Odstredivka(int cisloPristroja, int typPristroja)
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
            Console.WriteLine("Som Odstredivka typ : {0}", typPristroja);
        }
  
    }
}
