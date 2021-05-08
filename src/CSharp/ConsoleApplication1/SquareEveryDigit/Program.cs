using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
