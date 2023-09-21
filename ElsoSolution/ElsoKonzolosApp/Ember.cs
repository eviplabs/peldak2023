using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoKonzolosApp
{
    public class Ember
    {
        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }

        public Ember(string nev, int szuletesiEv)
        {
            Nev = nev;
            SzuletesiEv = szuletesiEv;
        }

        //override public string ToString()
        //{
        //    return Nev + " (" + SzuletesiEv + ")";
        //}
    }
}
