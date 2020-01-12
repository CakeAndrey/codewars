using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace RGBToHexConversion
{
    public class Kata
    {
        public static string Rgb(int r, int g, int b) =>
            string
                .Concat(String.Format("{0,1:X2}", Min(Max(r, 0), 255)).ToUpper()
                .Concat(String.Format("{0,1:X2}", Min(Max(g, 0), 255)).ToUpper())
                .Concat(String.Format("{0,1:X2}", Min(Max(b, 0), 255)).ToUpper()));
}
}
