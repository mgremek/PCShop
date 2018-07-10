using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep
{
    class Ram :Podzespol
    {
        int pojemnosc, czestotliwosc;
        string typPamieci;
        public Ram(int c, string mo, string pr,int poj,int cz,string tp): base(c,mo,pr)
        {
            pojemnosc = poj;
            czestotliwosc = cz;
            typPamieci = tp;
        }
        public override string PokazDane()
        {
            return base.PokazDane() + "\nPOJEMNOŚĆ: " + pojemnosc + " GB\nCZĘSTOTLIWOŚĆ: " + czestotliwosc + " GHz\nTYP PAMIĘCI: " + typPamieci;
        }
    }
}
