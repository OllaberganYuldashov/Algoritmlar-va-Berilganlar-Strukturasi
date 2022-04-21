using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prim_algoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph = new int[6, 6] {{ 0, 5, 3, 1, 0, 0 },
                          {5,0,0,6,2,0},
                          {3,0,0,0,0,4},
                          { 1,6,0,0,0,5 },
                          { 0,2,0,0,0,2 },
                          { 0,0,4,5,2,0}};
            int[] weight = new int[6];
            bool[] visiable = new bool[6];
            for (int k = 0; k < 6; k++)
            {
                weight[k] = int.MaxValue;
            }
            weight[0] = 0;
            visiable[0] = true;
            int i = 0;

            while (true)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (graph[i, j] > 0)
                    {
                        weight[j] = graph[i, j];
                    }
                }
                int min = int.MaxValue;
                int index = -1;
                for (int j = 0; j < 6; j++)
                {
                    if (weight[j] < min && !visiable[j])
                    {
                        min = weight[j];
                        index = j;
                    }
                }
                if (index == -1) break;
                Console.WriteLine(i + " - " + index);
                i = index;
                visiable[i] = true;
            }
        }
    }
}
