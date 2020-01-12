using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable SimplifyConditionalTernaryExpression

namespace MergedStringChecker
{
    // todo
    class StringMerger
    {
        static void Main(string[] args)
        {
            isMerge("Bananas from Bahamas", "Bahas", "Bananas from am");
            Console.ReadKey();
        }

        public static bool isMerge(string s, string part1, string part2)
        {
            Console.WriteLine(s);
            Console.WriteLine(part1);
            Console.WriteLine(part2);

            Console.WriteLine();
            throw new NotImplementedException("Finding the best solution to implement this using linq.");

        }



    }

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
