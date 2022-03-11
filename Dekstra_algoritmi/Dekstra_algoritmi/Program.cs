using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dekstra_algoritmi
{
    class Graph {
        public static int [] weight;
        public static bool [] visited;
        public static int[] path;

        private void Dijkstra_algorithm(int[,] graph, int size, int start_index=0) {
            int n =size;
            
            weight = new int[n];
            visited = new bool[n];
            path = new int[n];

            for (int k = 0; k < n; k++)
            {
                weight[k] = int.MaxValue;
                visited[k] = true;
                path[k] = -1;
            }


            int i = start_index;
            weight[i] = 0;
            path[i] = 0;

            
            while (true)
            {
                for (int j = 0; j < n; j++)
                {
                    if (graph[i, j] > 0)
                    {

                        if (weight[i] + graph[i, j] < weight[j])
                        {
                            weight[j] = weight[i] + graph[i, j];
                            path[j] = i;
                        }

                    }
                }
                visited[i] = false;

                int min_weight = int.MaxValue;
                int min_i = i;
                
                for (int k = 0; k < n; k++)
                {
                    if (visited[k] && weight[k] < min_weight)
                    {
                        min_weight = weight[k];
                        min_i = k;
                    }
                }

                if (min_i != i) i = min_i;
                else break;

            }
        
        }

        public void Dijkstra_weights_show( int [,] graph, int start_index) {
            int n = (int)Math.Sqrt(graph.Length);
            Dijkstra_algorithm(graph, n, start_index);
            for (int i = 0; i < n; i++)
            {

                Console.Write(weight[i] + " ");
            }
        }

        public void Dijkstra_paths_show(int[,] graph, int start_index)
        {
            int n = (int)Math.Sqrt(graph.Length);
            Dijkstra_algorithm(graph, n, start_index);
            for (int i = 0; i < n; i++)
            {

                Console.Write(path[i] + " ");
            }
        }
        public string Dijkstra_way(int[,] graph, int start_index, int finish_index) {
            string way = "";
            int n = (int)Math.Sqrt(graph.Length);
            Dijkstra_algorithm(graph, n, start_index);
            int i=finish_index;
            while (i != start_index)
            {
                way = path[i].ToString()+"->"+way;
                i = path[i];
            }
            way =way+ finish_index.ToString();
            return way;
        }
    }
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

            Graph gr = new Graph();

            Console.WriteLine(gr.Dijkstra_way(graph, 0, 5));
            Console.ReadKey();
            

        }
    }
}
