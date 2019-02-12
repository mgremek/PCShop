using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep
{
    class KartaGraficzna : Podzespol
    {
        int iloscRamu;
        string chipset, ram, typZlacza;
        public KartaGraficzna(int c, string mo, string pr, int ir,string ch,string r,string tz) :base(c,mo,pr)
        {
            iloscRamu = ir;
            chipset = ch;
            ram = r;
            typZlacza = tz;
        }
        public override string PokazDane()
        {
            return base.PokazDane() + "\nILOŚĆ RAMU: " + iloscRamu + " GB\nCHIPSET: " + chipset +
                " \nTYP RAMU: " + ram + " \nTYP ZŁĄCZA: " + typZlacza;
        }
    }
}
