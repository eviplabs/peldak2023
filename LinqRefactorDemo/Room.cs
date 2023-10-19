using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRefactorDemo
{
    internal class Room
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Faculty { get; set; }

        public bool NeedsKey { get; set; }
        public bool HasProjector { get; set; }
    }
}
