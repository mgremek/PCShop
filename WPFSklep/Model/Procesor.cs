using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep
{
    class Procesor : Podzespol
    {
        int id,liczbaRdzeni, architektura, cache;
        float taktowanie;
        string typGniazda;
        static int licznik;

        public string TypGniazda
        {
            get
            {
                return typGniazda;
            }

            private set
            {
                typGniazda = value;
            }
        }

        public Procesor()
        {

        }
        public Procesor(int c, string mo, string pr, int lr, int arch, int ca, float takt,string tg) : base(c, mo, pr)
        {
            licznik++;
            id = licznik;
            liczbaRdzeni = lr;
            architektura = arch;
            cache = ca;
            taktowanie = takt;
            TypGniazda = tg;
        }
        public override string PokazDane()
        {
            return base.PokazDane()+ "\nTYP GNIAZDA: "+TypGniazda+"\nLICZBA RDZENI: " + liczbaRdzeni + "\nARCHITEKTURA: " + architektura + " bit\nCACHE: " + cache + " MB\nTAKTOWANIE: " + taktowanie + " GHz";
        }
        

    }
}
