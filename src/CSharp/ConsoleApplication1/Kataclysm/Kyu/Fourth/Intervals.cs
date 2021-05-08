using System;
using System.Linq;

namespace Kataclysm.Kyu.Fourth
{
    public class Intervals
    {
        public static int SumIntervals((int a, int b)[] intervals) =>
            intervals
                .OrderBy(x => x.a)
                .ThenBy(x => x.b)
                .Aggregate((tuple: (a: int.MaxValue, b: int.MinValue), sum: 0),
                    (result, tuple) => result.tuple.b > tuple.a 
                        ? ((result.tuple.a, Math.Max(result.tuple.b, tuple.b)), result.sum + Math.Max(tuple.b - result.tuple.b, 0)) 
                        : (tuple, result.sum + tuple.b - tuple.a)).sum;
    }
}
