using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoKonzolosApp
{
    internal class SimplePrinter : IEmberPrinter
    {
        public void Print(Ember ember)
        {
            Console.WriteLine(ember);
        }
    }
}
