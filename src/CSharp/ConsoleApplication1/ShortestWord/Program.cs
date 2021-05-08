using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestWord
{
    public class Kata
    {
        public static int FindShort(string s) =>
            s.Split(' ').Min(x => x.Length);
    }
}
