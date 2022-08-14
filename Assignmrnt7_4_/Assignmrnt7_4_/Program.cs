using System;
using EmployeeManagement;

namespace Assignment7_4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                MiddleConnect.SetData(001, "Rahul Sharma", 17000);
                MiddleConnect.SetData(002, "Bibek Saha", 30000);
                MiddleConnect.SetData(003, "Priyanka Roy", 40000);
                MiddleConnect.SetData(004, "Aman Manak", 20000);
                MiddleConnect.SetData(005, "Jasspreet Singh", 50000);

                List<Manager> manager = MiddleConnect.Managers;
                string path = @"C:\Users\RAJA\C_Sharp_Assignment\Files\Manager\Manager.txt";
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);


                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, manager);

                manager.Clear();
                fs.Close();
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                List<Manager> man = (List<Manager>)bf.Deserialize(fs);

                foreach (Manager m in man)
                {
                    m.PrintDetails();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }

}
