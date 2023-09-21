using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoKonzolosApp
{
    internal class EmberPrinterBase : IEmberPrinter
    {
        public virtual void Print(Ember ember)
        {
            Console.WriteLine($"[ {ember.Nev}({ember.SzuletesiEv}) ]");
        }
    }
}
