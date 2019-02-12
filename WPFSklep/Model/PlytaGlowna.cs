using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep
{
    class PlytaGlowna : Podzespol
    {
        //static int licznik;
        string chipset, gniazdo, standard;
        
        public PlytaGlowna(int c,string mo,string pr,string ch,string gn,string std): base(c,mo,pr)
        {
            chipset = ch;
            gniazdo = gn;
            standard = std;
        }

        public string Gniazdo
        {
            get
            {
                return gniazdo;
            }
        }

        public override string PokazDane()
        {
            return base.PokazDane() +"\nCHIPSET: "+ chipset+"\nGNIAZDO: "+ Gniazdo+ "\nSTANDARD: "+ standard;
        }
    }
}
