using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lee_algoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, x, y;
            
            m = int.Parse(Console.ReadLine());
            
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                var sql = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(sql[j]);
                    if (a[i, j] == 1)
                    {
                        a[i, j] = int.MaxValue;
                    }
                }

            }
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            a[x, y] = 0;
            Queue<int> satr = new Queue<int>();
            Queue<int> ustin = new Queue<int>();
            satr.Enqueue(x);
            ustin.Enqueue(y);
            while (satr.Count > 0)
            {
                x = satr.Dequeue();

                y = ustin.Dequeue();
                if (y < n - 1)
                {
                    if (a[x, y + 1] == int.MaxValue)
                    {
                        a[x, y + 1] = a[x, y] + 1;
                        satr.Enqueue(x);
                        ustin.Enqueue(y + 1);
                    }
                }

                if (x < m - 1)
                {
                    
                    if (a[x + 1, y] == int.MaxValue)
                    {
                        a[x+1, y] = a[x, y] + 1;
                        satr.Enqueue(x + 1);
                        ustin.Enqueue(y);
                    }
                }
                if (y > 0 )
                {
                    if (a[x, y - 1] == int.MaxValue)
                    {
                        a[x, y - 1] = a[x, y] + 1;
                        satr.Enqueue(x);
                        ustin.Enqueue(y - 1);
                    }
                }
                if (x > 0)
                {
                    if (a[x - 1, y] == int.MaxValue)
                    {
                        a[x - 1, y] = a[x, y] + 1;
                        satr.Enqueue(x - 1);
                        ustin.Enqueue(y);
                    }
                }

            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine();
            }

            /* 5
               6
              -1 1 1 1 1 1
              -1 1 1 -1 -1 1
              1 1 1 1 1 1
              1 -1 -1 -1 1 1
              1 1 1 1 1 1
              0
              3
              */

            Console.ReadKey();
        }
    }
}
