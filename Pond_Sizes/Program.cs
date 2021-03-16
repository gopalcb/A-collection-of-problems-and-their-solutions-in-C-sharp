using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pond_Sizes
{
    class Program
    {
        static int r, c, count = 0;
        static int arr[,],visited[,];

        static void Main(string[] args)
        {
        }

        public void countpond()
        {
            for (int i = 0; i < r; ++i)
                for (int j = 0; j < c; ++j)
                    if (arr[i][j] == 0 && visited[i][j] == 0)
                    { count = 1; dfs(i, j); System.out.print(count + "\t"); }
        }
        public void dfs(int row, int col)
        {
            int rowNbr[] = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
            int colNbr[] = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };
            visited[row][col] = 1;
            for (int k = 0; k < 8; ++k)
                if (isSafe(row + rowNbr[k], col + colNbr[k]) == 1)
                    dfs(row + rowNbr[k], col + colNbr[k]);
        }
        int isSafe(int row, int col)
        {
            if ((row >= 0) && (row < r) && (col >= 0) && (col < c) && (arr[row][col] == 0 && visited[row][col] == 0))
            {
                count++;
                return 1;
            }
            return 0;
        }
    }
}
