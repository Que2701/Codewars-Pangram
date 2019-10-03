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
            Console.WriteLine(IsPangramV(str).ToString());
        }

        public static bool IsPanagram(string str)
        {
            string alphabetLetters = "abcdefghijklmnopqrstuvwxyz";
            return str.ToLower().Where(x => alphabetLetters.Contains(x)).OrderBy(y => y).GroupBy(z => z).Select(a => a.Key).Count() == 26 ? true : false;
        }

        public static bool IsPangramI(string str)
        {
            return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
        }

        public static bool IsPangramII(string str) =>
          str.ToLower()
             .Where(Char.IsLetter)
             .Distinct()
             .Count() == 26;

        public static bool IsPangramIV(string str)
        {
            var listChar = "abcdefghijklmnopqrstuvwxyz".ToList();

            str.ToLower().ToList().ForEach(x => {
                if (listChar.Contains(x))
                    listChar.Remove(x);
            });

            return listChar.Count == 0 ? true : false;
        }

        public static bool IsPangramV(string str)
        {
            string tmp = str.ToLower();
            for (char c = 'a'; c <= 'z'; c++)
                if (tmp.IndexOf(c) < 0)
                    return false;
            return true;
        }
    }
}
