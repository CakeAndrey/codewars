using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 3;
            var output = Kata.Pyramid(input);

            foreach (var arr in output)
            {
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }

    public class Kata
    {
        public static int[][] Pyramid(int n) =>
            Enumerable.Range(1, n).Select(x => new int[x].Select(y => 1).ToArray()).ToArray();
    }
}
