using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subset_of_a_set
{
    class Program
    {
        static List<string> helper(int n, Dictionary<int, List<string>> memo)
        {
            if (n == 1)
            {
                return new List<string> { "a1" };
            }

            List<string> data = new List<string>();

            if (memo.ContainsKey(n))
            {
                data = memo[n];
            }
            else
            {
                data = helper(n - 1, memo);
            }

            var temp = new List<string>(data);
            foreach (string a in data)
            {
                for (int i = 0; i < a.Length + 1; i = i + 2)
                {
                    string s = InsertCharAt(a, "a" + n, i);
                    temp.Add(s);
                }
            }
            memo.Add(n, temp);

            return memo[n];
        }

        static string InsertCharAt(string word, string c, int i)
        {
            string start = word.Substring(0, i);
            string end = word.Substring(i);
            return start + c + end;
        }

        static void Main(string[] args)
        {
            int n = 3; //{a1},{a1, a2}{a2, a1}
            var memo = new Dictionary<int, List<string>>();
            memo.Add(1, new List<string> { "a1" });

            var subset = helper(n, memo);

            Console.ReadKey();
        }
    }
}
