using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyskum
{
    class FactoryPristroje
    {
        public static Pristroj VytvorMikroskop(int cisloPristroja, int typPristroja)
        {
            return new Mikroskop(cisloPristroja, typPristroja);
        }

        public static Pristroj VytvorOdstredivku(int cisloPristroja, int typPristroja)
        {
            return new Odstredivka(cisloPristroja, typPristroja);
        }
    }
}
