using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_items
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] g = new string[,]
            {
                { "A", "B" },
                { "C", "D" },
                { "A", "E" },
                { "G", "K" },
                { "B", "L" },
                { "D", "M" }
            };

            bool[] v = new bool[g.GetLength(0)];

            List<List<string>> res = new List<List<string>>();

            for(int i = 0; i < g.GetLength(0); i++)
            {
                if (!v[i])
                {
                    List<string> clist = new List<string>();
                    clist.Add(g[i, 0]);
                    clist.Add(g[i, 1]);
                    v[i] = true;

                    for(int j = 0; j < g.GetLength(0); j++)
                    {
                        if (IsValid(clist, v, j, g[j, 0], g[j, 1]))
                        {
                            if (!clist.Contains(g[j, 0])) clist.Add(g[j, 0]);
                            if (!clist.Contains(g[j, 1])) clist.Add(g[j, 1]);

                            v[j] = true;
                        }
                    }

                    res.Add(clist);
                }
            }

            Console.ReadKey();
        }

        static bool IsValid(List<string> clist, bool[] v, int i, string a, string b)
        {
            if(!v[i] && (clist.Contains(a) || clist.Contains(b)))
            {
                return true;
            }

            return false;
        }
    }
}
