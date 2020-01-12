using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingZerosToTheEnd
{
    class Program
    {
        static void Main(string[] args)
        {
                
        }
    }

    public class Kata
    {
        public static Array MoveZeroes(Array arr) =>
            arr.Cast<object>().OrderBy(x => x as int? == 0).ToArray();
    }
}
