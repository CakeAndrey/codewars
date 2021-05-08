using System.Linq;
using static System.Math;

namespace RGBToHexConversion
{
    public class Kata
    {
        public static string Rgb(int r, int g, int b) =>
            string
                .Concat($"{Min(Max(r, 0), 255),1:X2}".ToUpper()
                .Concat($"{Min(Max(g, 0), 255),1:X2}".ToUpper())
                .Concat($"{Min(Max(b, 0), 255),1:X2}".ToUpper()));
}
}
