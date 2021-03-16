using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_Rectangle
{
    class Program
    {
        static int[] rv = { 0, 1, 1 };
        static int[] cv = { 1, 0, 1 };

        static void Main(string[] args)
        {
            char[][] matrix = new char[4][];

            matrix[0] = new char[5] { '1', '0', '1', '0', '0' };
            matrix[1] = new char[5] { '1', '0', '1', '1', '1' };
            matrix[2] = new char[5] { '1', '1', '1', '1', '1' };
            matrix[3] = new char[5] { '1', '0', '1', '1', '0' };

            bool[][] visited = new bool[matrix.GetLength(0)][];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool[] v = new bool[matrix[i].Length];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    v[j] = false;
                }
                visited[i] = v;
            }

            IList<string> s = new List<string>();

        }
    }
}
