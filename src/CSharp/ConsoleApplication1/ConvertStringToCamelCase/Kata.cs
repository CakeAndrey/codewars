using System.Linq;

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
