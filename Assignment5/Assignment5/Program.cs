using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1
{
    internal class Program
    {
        #region Fields & Properties
        private static int[] arrayInt;
        private static string[] arrayString;

        public static int[] ArrayInt 
        { 
            get 
            { 
                return arrayInt; 
            } 
            set 
            { 
                arrayInt = value; 
            } 
        }
        public static string[] ArrayString 
        { 
            get 
            { 
                return arrayString;
            } 
            set 
            { 
                arrayString = value; 
            } 
        }
        #endregion

        #region Get Valid Integer
        public static int GetValidInteger(string msg = null)
        {
            int validInteger = 0;
            try
            {
                do
                {
                    if (msg != null)
                        Console.Write(msg);
                    if (!int.TryParse(Console.ReadLine(), out validInteger))
                    {
                        Console.WriteLine("\nEnter a valid Integer");
                        continue;
                    }
                    break;
                } 
                while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return validInteger;
        }
        #endregion

        #region User Input
        public static void UserInput()
        {
            ArrayInt = new int[Program.GetValidInteger("Enter Integer Array Size: ")];
            ArrayString = new string[Program.GetValidInteger("Enter String Array Size: ")];

            Console.WriteLine();

            for (int i = 0; i < ArrayInt.Length; i++)
            {
                ArrayInt[i] = Program.GetValidInteger("Enter a Integer: ");
            }

            Console.WriteLine();

            for (int i = 0; i < ArrayString.Length; i++)
            {
                Console.Write("\nEnter a String: ");
                ArrayString[i] = Console.ReadLine();
            }

            Console.WriteLine();
        }
        #endregion

        #region Display
        public static void Display<T>(T[] arr)
        {
            Console.Write("Elements are: ");
            foreach (T t in arr)
            {
                Console.Write("{0},  ", t);
            }
            Console.WriteLine("\n");
        }
        #endregion

        #region Main
        static void Main(string[] args)
        {
            Program.UserInput();

            Console.WriteLine("\n---------Copy----------");

            #region Copy
            Console.WriteLine("Original array String");
            Program.Display<string>(Program.ArrayString);

            Console.WriteLine("\nOriginal array Int");
            Program.Display<int>(Program.ArrayInt);

            string[] arrJ = new string[Program.ArrayString.Length];
            Array.Copy(Program.arrayString, arrJ, Program.ArrayString.Length);

            int[] arrP = new int[Program.ArrayInt.Length];
            Array.Copy(Program.arrayInt, arrP, Program.ArrayInt.Length);

            Console.WriteLine("Coppied array String");
            Program.Display<string>(arrJ);

            Console.WriteLine("\nCoppied array Int");
            Program.Display<int>(arrP);
            #endregion

            #region Sort
            Console.WriteLine("\n---------Sort----------");
            Array.Sort(Program.ArrayInt);
            Array.Sort(Program.ArrayString);

            Console.WriteLine("\n---------After Sort Integer Array--------");
            Program.Display(Program.ArrayInt);

            Console.WriteLine("\n---------After Sort String Array--------");
            Program.Display(Program.ArrayString);
            #endregion

            #region Reverse
            Console.WriteLine("\n---------Reverse----------");
            Array.Reverse(Program.ArrayInt);
            Array.Reverse(Program.ArrayString);

            Console.WriteLine("\n---------After Reverse Integer Array--------");
            Program.Display(Program.ArrayInt);

            Console.WriteLine("\n---------After Reverse String Array--------");
            Program.Display(Program.ArrayString);
            #endregion

            #region Clear
            Console.WriteLine("\n---------Reverse----------");
            Array.Clear(Program.ArrayInt, 2, Program.ArrayInt.Length - 2);
            Array.Clear(Program.ArrayString, 1, Program.ArrayString.Length - 1);

            Console.WriteLine("\n---------After Clear from Index 2 Integer Array--------");
            Program.Display(Program.ArrayInt);

            Console.WriteLine("\n---------After Clear from index 1 String Array--------");
            Program.Display(Program.ArrayString);
            #endregion


            Console.ReadLine();
        }
        #endregion
    }
}
