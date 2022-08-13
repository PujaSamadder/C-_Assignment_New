using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            char op;

            Console.WriteLine("Enter the operator( +, -, *, /): ");
            op = Console.ReadLine()[0];

            Console.WriteLine("Enter the First number: ");
            num1 =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter the Second number: ");
            num2 =Convert.ToInt32 (Console.ReadLine());

            switch(op)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2} ",num1,num2,( num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2} ",num1,num2, (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}",num1,num2,( num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2} ",num1,num2,( num1 / num2));
                    break;
                default:
                    Console.WriteLine("{0} is an invalid operator", op);
                    break;
            }
            Console.ReadKey();
        }
    }
}
