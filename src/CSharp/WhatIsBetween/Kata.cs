using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsBetween
{
    public class Kata
    {
        public static int[] Between(int a, int b) =>
            Enumerable.Range(a, b - a + 1).ToArray();
    }
}
