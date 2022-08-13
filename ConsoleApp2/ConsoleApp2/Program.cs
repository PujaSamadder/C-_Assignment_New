using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static int add(params int[ ] arr )
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        static void Main(string[]args)
        {
            int[] arr = { 5, 12, 99, 20 };
            int n = arr.Length;
            Console.Write("Sum of given Array is " + add(arr));
            Console.ReadLine();
        }
    }
}
