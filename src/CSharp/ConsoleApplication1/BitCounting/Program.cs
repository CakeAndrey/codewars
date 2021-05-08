using static System.Linq.Enumerable;

namespace BitCounting
{
    class Program
    {
        public static int CountBits(int n) =>
            Range(0, 30).Count(x => (n & 1 << x) != 0);
    }
}
