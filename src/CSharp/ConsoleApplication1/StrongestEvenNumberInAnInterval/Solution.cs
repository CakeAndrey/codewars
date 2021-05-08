using System.Linq;
using static System.Linq.Enumerable;

namespace StrongestEvenNumberInAnInterval
{
    class Solution
    {
        public static int strongestEven(int n, int m) => 
            Range(1, 30).Aggregate(0, (a, b) => a < n ? a | m & 1 << 31 - b : a);

    }
}
