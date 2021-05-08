using System;
using System.Linq;

namespace DescendingOrder
{
    public static class Program
    {
        public static int DescendingOrder(int num) =>
            Convert.ToInt32(string.Concat(num
                .ToString()
                .OrderByDescending(x => x)
                .Select(x => x.ToString().Single())));
    }
}
