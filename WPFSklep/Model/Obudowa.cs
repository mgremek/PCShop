using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep
{
    class Obudowa : Podzespol
    {
        string kolor, material;
        Boolean czyOkno;
        public Obudowa(int c, string mo, string prod,string ko, string mat,Boolean cO): base(c,mo,prod)
        {
            kolor = ko;
            material = mat;
            czyOkno = cO;
        }
        public override string PokazDane()
        {
            return base.PokazDane() + "\nKOLOR: " + kolor + "\nMATERIAŁ: " + material + "\nOKIENKO: " + Czy(czyOkno);
        }
        private string Czy(Boolean dana)
        {
            if (dana == false)
                return "nie";
            else return "tak";
        }
    }
}
