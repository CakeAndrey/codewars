using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourOrderPlease
{
    public static class Kata
    {
        public static string Order(string words) =>
            words.Split(' ')
                .Select(x => (value: x, position: x.FirstOrDefault(char.IsNumber)))
                .OrderBy(x => x.position)
                .Select((x, i) => i == 0 ? x.value : ' ' + x.value)
                .Aggregate((x, y) => x + y);
    }
}
