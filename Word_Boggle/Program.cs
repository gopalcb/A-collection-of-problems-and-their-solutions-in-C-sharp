using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Boggle
{
    class Program
    {
        static int[] pathRow = { 0, 0, 1, 1, -1, 1, -1, -1 };
        static int[] pathCol = { 1, -1, -1, 1, 1, 0, 0, -1 };

        static char[,] board =
        {
            {'G','I','Z' },
            {'U', 'E','K' },
            {'Q','S','E' }
        };

        static bool[,] visited =
        {
            {false, false, false },
            {false, false, false },
            {false, false, false }
        };

        static List<string> dict = new List<string>
        {
            "GEEKS", "QUIZ", "FOR", "GO"
        };

        static void Main(string[] args)
        {
            string word = "";
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    visited[i, j] = true;
                    FindWord(board, visited, 0, 0, word+board[i,j], dict);
                    visited[i, j] = false;
                }
            }
            Console.ReadKey();
        }

        public static void FindWord(char[,] board, bool[,] visited, int row, int col, string word, List<string> dict)
        {
            if (dict.Contains(word))
            {
                Console.WriteLine(word);
            }

            if(board.Length == word.Length)
            {
                return;
            }

            for(int i=0; i < pathRow.Length; i++)
            {
                int rowNew = row + pathRow[i];
                int colNew = col + pathCol[i];

                if(IsValid(rowNew, colNew, visited))
                {
                    visited[rowNew, colNew] = true;
                    //word = word + board[rowNew, colNew];
                    FindWord(board, visited, rowNew, colNew, word + board[rowNew, colNew], dict);
                    visited[rowNew, colNew] = false;
                }
            }
        }

        public static bool IsValid(int rowNew, int colNew, bool[,] visited)
        {
            if(rowNew>=0 && rowNew<3 && colNew>=0 && colNew<3 && !visited[rowNew, colNew])
            {
                return true;
            }

            return false;
        }
    }
}
