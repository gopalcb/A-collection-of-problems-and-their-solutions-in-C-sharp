using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ip_addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "11211";
            var items = GenerateIP(s);
        }

        public static List<string> GenerateIP(string s)
        {
            var res = new List<string>();
            int n = s.Length;
            for (int i = 1; i < n && i < 4; ++i)
            {
                string first = s.Substring(0, i);
                if (!IsValid(first))
                {
                    continue;
                }

                for (int j = 1; i + j < n && j < 4; ++j)
                {
                    string second = s.Substring(i, i + j);
                    if (!IsValid(second))
                    {
                        continue;
                    }

                    for (int k = 1; i + j + k < n & k < 4; ++k)
                    {
                        string third = s.Substring(i + j, i + j + k);
                        string fourth = s.Substring(i + j + k);
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
            if (s.Length > 3)
            {
                return false;
            }
            if(s.StartsWith("0") && s.Length > 1)
            {
                return false;
            }

            int iv = Convert.ToInt32(s);
            return iv >= 0 && iv <= 255;
        }
    }
}
