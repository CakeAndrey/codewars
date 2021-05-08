using System;

namespace MergedStringChecker
{
    class StringMerger
    {
        static void Kata(string[] args)
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
}