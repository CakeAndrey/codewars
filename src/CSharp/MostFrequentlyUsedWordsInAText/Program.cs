using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentlyUsedWordsInAText
{
    public class TopWords
    {
        public static List<string> Top3(string s) =>
            string.Concat(s.Select(x => char.IsLetter(x) || x == '\'' ? x : ' '))
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => char.IsLetter(x.FirstOrDefault()))
                .Select(x => x.ToLower())
                .GroupBy(x => x, (x, y) => (word: x, count: y.Count(z => z == x)))
                .OrderByDescending(x => x.count)
                .Take(3)
                .Select(x => x.word)
                .ToList();
    }
}
