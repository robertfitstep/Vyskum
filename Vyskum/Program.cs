using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyskum
{
    class Program
    {
        static void Main(string[] args)
        {
            Laboratorium laboratorium = new Laboratorium();
            laboratorium.laboratornyPristroj1 = FactoryPristroje.VytvorOdstredivku(2655, 708);
            laboratorium.laboratornyPristroj2 = FactoryPristroje.VytvorOdstredivku(5146587, 247);
            laboratorium.veduci = new Laboratorium.Veduci("Jozef", "Mrkva");
            laboratorium.SpustVyskum();
            Console.ReadLine();
        }
    }
}
