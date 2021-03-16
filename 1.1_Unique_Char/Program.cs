using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Unique_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ABCDEFGHB";

            var sarr = s.ToArray();

            IDictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var sc in sarr)
            {
                if (dict.ContainsKey(sc.ToString()))
                {
                    Console.WriteLine("Duplicate found");
                    break;
                }
                else
                {
                    dict.Add(sc.ToString(), 1);
                }
            }
            //Console.WriteLine("Unique");
            Console.ReadKey();
        }
    }
}
