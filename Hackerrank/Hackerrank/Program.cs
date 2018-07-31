using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(rotLeft(new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13));
            Console.ReadKey();
        }
        public static int[] rotLeft(int[] a, int d)
        {
            if (d == a.Length)
            {
                return a;
            }
            //create new array with same length 
            var newArr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i + d > a.Length - 1)
                {
                    newArr[i] = a[i + d - a.Length];
                }
                else
                {
                    newArr[i] = a[i + d];
                }
            }

            return newArr;
        }
         
    }
}
