using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRefactorDemo
{
    internal class FacultyCapacityComparer : IComparer<FacultyWithCapacity>
    {
        public int Compare(FacultyWithCapacity x, FacultyWithCapacity y)
        {
            return x.Capacity.CompareTo(y.Capacity);
        }
    }
}
