using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graf_BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph = { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                           { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                           { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                           { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                           { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                           { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                           { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                           { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                           { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };

            int n = (int)Math.Sqrt(graph.Length);

            Queue<int> myQueue = new Queue<int>();
            bool[] visited = new bool[n];
            int vert1;
            int start_index = 0;
            string s = start_index.ToString();

            visited[start_index] = true;
            myQueue.Enqueue(start_index);

            while (myQueue.Count>0)
            {
                vert1 = myQueue.Dequeue();

                for (int j = 0; j < n; j++)
                {
                    if (graph[vert1, j] >0 && !visited[j])
                    {
                        visited[j] = true;
                        s += "-"+j.ToString();
                        myQueue.Enqueue(j);
                        
                    }
                }

            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
