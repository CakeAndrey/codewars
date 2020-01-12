using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Linq.Enumerable;

namespace BitCounting
{
    class BitCounting
    {
        public static int CountBits(int n) =>
            Range(0, 30).Count(x => (n & 1 << x) != 0);
    }
}
