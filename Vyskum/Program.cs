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
            laboratorium.laboratornyPristroj1 = new Odstredivka(2655, 708);
            laboratorium.laboratornyPristroj2 = new Mikroskop(5146587, 247);
            laboratorium.veduci = new Laboratorium.Veduci("Jozef", "Mrkva");
            laboratorium.SpustVyskum();
            Console.ReadLine();
        }
    }
}
