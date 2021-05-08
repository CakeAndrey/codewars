using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToCamelCase
{
    public class Kata
    {
        public static string ToCamelCase(string str) =>
            str.Replace('-', ' ')
                .Replace('_', ' ')
                .Split(' ')
                .Select((x, i) => i > 0 ? x.Insert(0, char.ToUpper(x[0]).ToString()).Remove(1, 1) : x)
                .Aggregate((x, y) => x + y);
    }
}
