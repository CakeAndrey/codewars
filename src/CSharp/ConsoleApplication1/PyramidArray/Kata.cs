using System.Linq;

namespace PyramidArray
{
    public class Kata
    {
        public static int[][] Pyramid(int n) =>
            Enumerable.Range(1, n).Select(x => new int[x].Select(y => 1).ToArray()).ToArray();
    }
}
