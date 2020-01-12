using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using static System.Math;

namespace SumStringsAsNumbers
{
    // todo

    class Program
    {
        static void Main(string[] args)
        {
            var a = "12345";
            var b = "67890";

            var res = Kata.sumStrings(a, b);

            var res1 = a.Join(b, x => x, x => x, (x, y) => (x, y));
            var res2 = a
                .Select((x, i) => (a: a[i], b: b.ElementAtOrDefault(i)))
                .Aggregate(0, (x, y) => x + y.a - '0' + y.b - '0');

            Console.WriteLine(res2);

            //Console.WriteLine(res);

            Console.ReadKey();
        }
    }

    public static class Kata
    {
        public static string sumStrings(string a, string b) =>
            Enumerable.Range(0, a.Length)
                .Reverse()
                .Aggregate(new StringBuilder(), (x, i) => x.Append(a[i])).ToString();

    }
}
