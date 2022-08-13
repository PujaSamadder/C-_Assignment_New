using System;


namespace areaANDcircumference
{
     class Program
    {
        double r;

        public void Circle()
        {
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of Circle {0} is {1}", r, 3.14 * r * r);
            Console.WriteLine("Circumference of Circle {0} is {1}", r, 2 * 3.14 * r);

        }
        static void Main(string[] args)
        {
            try
            {
                Program  obj = new Program();
                obj.Circle();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Some error occurred");
            }
        }
    }
}
