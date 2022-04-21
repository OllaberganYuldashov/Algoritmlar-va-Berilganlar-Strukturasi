using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Search
{
    class Program
    {
        public static int Binary(int[] a, int key, int index1, int index2)
        {
            int midl = (index1 + index2) / 2;

            if (key == a[midl]) {  return midl; }

            if (index1 <= index2)
            {
                     if (key > a[midl])
                        return Binary(a, key, midl + 1, index2);
                     else
                        return Binary(a, key, index1, midl - 1);
            
            }

            return 0;
            
                
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Binary(a, 7, 0, 8));
            Console.ReadKey();
        }
        
    }
}
