using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PangramApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(IsPanagram(str).ToString());
        }

        public static bool IsPanagram(string str)
        {
            string alphabetLetters = "abcdefghijklmnopqrstuvwxyz";
            return str.ToLower().Where(x => alphabetLetters.Contains(x)).OrderBy(y => y).GroupBy(z => z).Select(a => a.Key).Count() == 26 ? true : false;
        }
    }
}
