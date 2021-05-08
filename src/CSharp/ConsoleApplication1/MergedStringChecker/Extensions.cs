using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MergedStringChecker
{
    static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> self, Action<T> action)
        {
            foreach (var item in self)
                action(item);
        }

        public static void ForEach<T>(this IEnumerable<T> self, Action<T, int> action)
        {
            var iteration = 0;

            foreach (var item in self)
                action(item, iteration++);
        }
    }

}
