using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDuplicates
{
    class Kata
    {
        public static int DuplicateCount(string str) =>
            str.ToLower()
                .GroupBy(x => x)
                .Where(x => x.Count() > 1)
                .Distinct()
                .Count();
    }
}
