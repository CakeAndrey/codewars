using System.Linq;
using static System.Math;

namespace SumOfIntervals
{
    public class Intervals
    {
        public static int SumIntervals((int a, int b)[] intervals) =>
            intervals
                .OrderBy(x => x.a)
                .ThenBy(x => x.b)
                .Aggregate((tuple: (a: int.MaxValue, b: int.MinValue), sum: 0),
                    (result, tuple) => result.tuple.b > tuple.a 
                        ? ((result.tuple.a, Max(result.tuple.b, tuple.b)), result.sum + Max(tuple.b - result.tuple.b, 0)) 
                        : (tuple, result.sum + tuple.b - tuple.a)).sum;
    }
}
