using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parenthesis_check
{
    class Program
    {
        public static bool IsValid(string s)
        {

            if(s == "") return true;

            char[] arr = s.ToCharArray();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (stack.Count == 0 && (arr[i] == ')' || arr[i] == '}' || arr[i] == ']'))
                {
                    return false;
                }

                if (arr[i] == '(' || arr[i] == '{' || arr[i] == '[')
                {
                    stack.Push(arr[i]);
                }
                else
                {
                    char paren = stack.Pop();

                    if ((paren == '(' && arr[i] == ')') || (paren == '{' && arr[i] == '}') || (paren == '[' && arr[i] == ']'))
                    {
                        //return true;
                    }
                    else
                    {
                        //return false;
                    }
                }
            }

            if(stack.Count == 0)
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            var res = IsValid("([]");
        }
    }
}
