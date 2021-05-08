using System.Linq;

namespace ShortestWord
{
    public class Kata
    {
        public static int FindShort(string s) =>
            s.Split(' ').Min(x => x.Length);
    }
}
