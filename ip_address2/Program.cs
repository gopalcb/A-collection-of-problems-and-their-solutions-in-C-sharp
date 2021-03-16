using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ip_address2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "1111";
            var items = GenerateIP(s);

            foreach (string str in items)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }

        public static List<string> GenerateIP(string s)
        {
            var res = new List<string>();
            int n = s.Length;
            var nums = s.ToArray();
            string first = "";
            for (int i = 0; i < n && i < 4; i++)
            {
                first = first + nums[i].ToString();
                if (!IsValid(first))
                {
                    continue;
                }

                string second = "";
                for (int j = i + 1; j < n && j < 4; j++)
                {
                    second = second + nums[j].ToString();
                    if (!IsValid(second))
                    {
                        continue;
                    }

                    string third = "";
                    for (int k = j + 1; k < n & k < 4; k++)
                    {
                        third = third + nums[k].ToString();
                        string fourth = "";

                        for (int l = k + 1; l < n & k < 4; l++)
                        {
                            fourth = fourth + nums[l].ToString();
                        }

                        if (!IsValid(third) || !IsValid(fourth))
                        {
                            continue;
                        }

                        res.Add(first + "." + second + "." + third + "." + fourth);
                    }
                }
            }

            return res;
        }

        public static bool IsValid(string s)
        {
            if (s.Length > 3 || s.Length <= 0)
            {
                return false;
            }
            if (s.StartsWith("0") && s.Length > 1)
            {
                return false;
            }

            int iv = Convert.ToInt32(s);
            return iv >= 0 && iv <= 255;
        }
    }
}
