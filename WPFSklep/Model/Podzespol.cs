using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep
{
    public abstract class Podzespol
    {
        protected int cena;
        protected string model, producent;
        public Podzespol()
        {
            cena = 0;
            model=producent= "";
        }
        public Podzespol(int c, string mo, string pr)
        {
            cena = c;
            model = mo;
            producent = pr;
        }
        public virtual string PokazDane()
        {
            return "CENA: " + cena + " zł\nPRODUCENT: " + producent + " \nMODEL: " + model;
        }
        public virtual int ReturnCena()
        {
            return this.cena;
        }
    }
}
