using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
