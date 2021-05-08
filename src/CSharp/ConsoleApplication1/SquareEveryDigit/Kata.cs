using System.Linq;
using static System.Math;

namespace SquareEveryDigit
{
    public class Kata
    {
        public static int SquareDigits(int n) =>
            int.Parse(n.ToString()
                .Select(x => Pow(x - '0', 2).ToString())
                .Aggregate((x, y) => x + y));
    }

}
