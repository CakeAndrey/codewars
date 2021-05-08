using System;
using System.Linq;

namespace MovingZerosToTheEnd
{
    public class Kata
    {
        public static Array MoveZeroes(Array arr) =>
            arr.Cast<object>().OrderBy(x => x as int? == 0).ToArray();
    }
}
