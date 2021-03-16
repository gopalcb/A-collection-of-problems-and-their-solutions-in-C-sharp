using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group_anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

            var dict = new Dictionary<string, List<string>>();

            for(int i = 0; i < arr.Length; i++)
            {
                var a = arr[i].ToArray();
                Array.Sort(a);
                var b = new string(a);

                if (dict.ContainsKey(b))
                {
                    dict[b].Add(arr[i]);
                }
                else
                {
                    dict.Add(b, new List<string> { arr[i] });
                }
            }

            foreach(var d in dict)
            {
                foreach(var e in d.Value)
                {
                    Console.Write(e + "  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
