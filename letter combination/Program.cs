using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_combination
{
    class Program
    {
        public static IList<string> solve(List<string> letters, List<string> res, int n, string s)
        {

            if (n == letters.Count)
            {
                res.Add(s);
                return res;
            }

            for (int i = 0; i < letters[n].Length; i++)
            {
                s += letters[n][i];
                solve(letters, res, n + 1, s);
                s = s.Remove(s.Length - 1);
            }

            return res;
        }

        static void Main(string[] args)
        {
            string digits = "234";
            Dictionary<string, string> map = new Dictionary<string, string>();

            map.Add("2", "abc");
            map.Add("3", "def");
            map.Add("4", "ghi");
            map.Add("5", "jkl");
            map.Add("6", "mno");
            map.Add("7", "pqrs");
            map.Add("8", "tuv");
            map.Add("9", "wxyz");

            List<string> letters = new List<string>();

            char[] darr = digits.ToCharArray();

            for (int i = 0; i < darr.Length; i++)
            {
                letters.Add(map[darr[i].ToString()]);
            }


            var res = solve(letters, new List<string>(), 0, "");
        }
    }
}
