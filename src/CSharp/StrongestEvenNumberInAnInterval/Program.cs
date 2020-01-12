using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

using static System.Math;
using static System.Linq.Enumerable;

namespace StrongestEvenNumberInAnInterval
{
    class Solution
    {
        static void Main()
        {
            var n = 1;
            var m = 127;

            var result = Range(0, 31).Aggregate((x, y) => x < n ? x | m & 1 << 31 - y : x);

            Console.WriteLine(result);
            Console.ReadKey();

        }

        public static int strongestEven(int n, int m) => 
            Range(1, 30).Aggregate(0, (a, b) => a < n ? a | m & 1 << 31 - b : a);

    }
}
