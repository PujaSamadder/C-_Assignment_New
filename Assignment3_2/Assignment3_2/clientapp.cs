using System;
using Assignment3_1;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack ms1 = new MyStack(4);
            ms1.Push(20);
            ms1.Push(25);
            ms1.Push(30);
            ms1.Push(35);

            ms1.Display();

            ms1.Push(90);

            Console.WriteLine(ms1.Pop());
            Console.WriteLine(ms1.Pop());

            Console.WriteLine("\n----------MS1----------");
            ms1.Display();


            MyStack ms2 = (MyStack)ms1.Clone();
            Console.WriteLine("\n----------MS2----------");
            ms2.Display();

            Console.ReadLine();

        }
    }
}
