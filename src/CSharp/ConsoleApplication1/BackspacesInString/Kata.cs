using System.Linq;

namespace BackspacesInString
{
    public class Kata
    {
        public static string CleanString(string s) =>
            s.Contains('#') 
                ? s.IndexOf('#') == 0 
                    ? CleanString(s.Remove(0, 1)) 
                    : CleanString(s.Remove(s.IndexOf('#') - 1, 2)) 
                : s;
    }
}
