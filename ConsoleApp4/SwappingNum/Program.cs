using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingNum
{
     class Program
    {
        int Num1, Num2, Temp;
        public void swap()
        {

         Console.WriteLine("Enter the First Number: ");
         Num1=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the Second Number: ");
         Num2 = Convert.ToInt32(Console.ReadLine());
            Temp = Num1;
            Num1 = Num2;
            Num2 = Temp;
            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number is: " + Num1);
            Console.WriteLine("Second Number is: " + Num2);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            try
            {
                Program obj = new Program();
                obj.swap();
                Console.ReadLine();
            }
            catch (Exception e )
            {
                Console.WriteLine("Some error occurred");
            }

        }
    }
}
