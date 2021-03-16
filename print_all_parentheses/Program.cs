using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_all_parentheses
{
    class Program
    {
        static void _printParenthesis(char[] str, int pos, int n, int open, int close)
        {
            if (close == n)
            {
                for (int i = 0; i < str.Length; i++)
                    Console.Write(str[i]);

                Console.WriteLine();
                return;
            }
            else
            {
                if (open > close)
                {
                    str[pos] = ')';
                    _printParenthesis(str, pos + 1, n, open, close + 1);
                }
                if (open < n)
                {
                    str[pos] = '(';
                    _printParenthesis(str, pos + 1, n, open + 1, close);
                }
            }
        }

        static void printParenthesis(char[] str, int n)
        {
            if (n > 0)
                _printParenthesis(str, 0, n, 0, 0);
            return;
        }

        static void Main(string[] args)
        {
            int n = 2;
            char[] str = new char[2 * n];

            printParenthesis(str, n);
            Console.ReadKey();
        }
    }
}
