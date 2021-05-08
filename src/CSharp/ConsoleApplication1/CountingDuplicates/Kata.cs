using System.Linq;

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
