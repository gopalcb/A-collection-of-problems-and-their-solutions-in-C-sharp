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
            if (n == 0)
            {
                return new List<string> { "" };
            }
            else
            {
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
                    string s = "";
                    if (a == "")
                    {
                        s = a + "a" + n;
                    }
                    else
                    {
                        s = a + ", a" + n;
                    }
                    temp.Add(s);
                }
                memo.Add(n, temp);
            }

            return memo[n];
        }

        static void Main(string[] args)
        {
            int n = 5; //{},{a1, a2}
            var memo = new Dictionary<int, List<string>>();
            memo.Add(0, new List<string> { "" });

            var subset = helper(n, memo);

            Console.ReadKey();
        }
    }
}
