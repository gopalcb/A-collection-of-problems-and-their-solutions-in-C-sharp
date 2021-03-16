using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Stacking_Problem
{
    class Program
    {
        static int getMaxHeight(int[,] boxes)
        {
            //3 possible rotations
            int len = boxes.GetLength(0);
            int[,] all = new int[3 * len, 3];

            for(int i = 0; i < len; i++)
            {
                int max = Math.Max(boxes[i, 1], boxes[i, 2]);
                int min = Math.Max(boxes[i, 1], boxes[i, 2]);
                int[] b = new[] { boxes[i, 0], max, min };
            }



            return 0;
        }


        static void Main(string[] args)
        {
            int[,] boxes = new int[4,3]{ { 4, 6, 7 }, { 1, 2, 3 }, { 4, 5, 6 }, { 10, 12, 32 } };//h, w, d
        }
    }
}
