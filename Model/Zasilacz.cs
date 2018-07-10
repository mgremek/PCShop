using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep
{
    class Zasilacz : Podzespol
    {
        int moc, sprawnosc;
        string standard;
        public Zasilacz(int c,string m,string p,int moc,int s,string std) :base(c,m,p)
        {
            this.moc = moc;
            sprawnosc = s;
            standard = std;
        }
        public override string PokazDane()
        {
            return base.PokazDane() +"\nMOC: "+ moc + " W\nSPRAWNOŚĆ: "+sprawnosc+" %\nSTANDARD: "+ standard;
        }
    }
}
