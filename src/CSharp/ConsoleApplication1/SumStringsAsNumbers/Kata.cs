using System.Linq;
using System.Text;

namespace SumStringsAsNumbers
{
    // todo checkout the result.
    public static class Kata
    {
        public static string sumStrings(string a, string b) =>
            Enumerable.Range(0, a.Length)
                .Reverse()
                .Aggregate(new StringBuilder(), (x, i) => x.Append(a[i])).ToString();

    }
}
