using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoyMinorasi
{
    class Program
    {

        static void Hanoy(int n, char A, char B, char C) 
        {
            
            if (n == 1)
            {
                Console.WriteLine(A.ToString() + " dan " + B.ToString() + " ga.");
            }
            else {
                Hanoy(n - 1, A, C, B);

                Console.WriteLine(A.ToString() + " dan " + B.ToString() + " ga.");
                Hanoy(n - 1, C, B, A);
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Hanoy(n, 'A', 'B', 'C');
            Console.ReadKey();

        }
    }
}
