using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_queen
{
    class Program
    {
        //number of queens
        public static int N = 4;
        //chessboard
        private static int[,] board = new int[N,N];

        static void Main(string[] args)
        {
            nQueen(N);
            //printing the matix
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(board[i,j] + "  ");
                    //Console.WriteLine();
                }

                Console.WriteLine();
            }
            
            Console.ReadKey();
        }

        //function to check if the cell is attacked or not
        private static bool isAttack(int i, int j)
        {
            //checking if there is a queen in row or column
            for (int k = 0; k < N; k++)
            {
                if ((board[i,k] == 1) || (board[k,j] == 1))
                    return true;
            }
            //checking for diagonals
            for (int k = 0; k < N; k++)
            {
                for (int l = 0; l < N; l++)
                {
                    if (((k + l) == (i + j)) || ((k - l) == (i - j)))
                    {
                        if (board[k,l] == 1)
                            return true;
                    }
                }
            }
            return false;
        }

        private static bool nQueen(int n)
        {
            //if n is 0, solution found
            if (n == 0)
                return true;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((!isAttack(i, j)) && (board[i,j] != 1))
                    {
                        board[i,j] = 1;
                        //recursion
                        //wether we can put the next queen with this arrangment or not
                        if (nQueen(n - 1) == true)
                        {
                            return true;
                        }
                        board[i,j] = 0;
                    }
                }
            }
            return false;
        }
    }

    
}
