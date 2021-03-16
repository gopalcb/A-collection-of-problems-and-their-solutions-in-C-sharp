using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom_check
{
    class Program
    {
        static bool IsPalindrome(string myString)
        {
            int length = myString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (myString[i] != myString[length - i - 1])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string s = "aabbaa1";
            var isp = IsPalindrome(s);
        }
    }
}
