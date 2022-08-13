using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = null;
                int j = 0;
                string path = @"C:\Users\RAJA\source\repos\Files";


                DirectoryInfo dir = new DirectoryInfo(path);


                if (!dir.Exists)
                {
                    dir.Create();
                    dir.CreateSubdirectory("Dir 1");
                    dir.CreateSubdirectory("Dir 2");
                }


                DirectoryInfo[] dirs = dir.GetDirectories();



                Console.WriteLine("------Sub Directories------");

                foreach (var d in dirs)
                {
                    Console.WriteLine(d.Name);

                }

                Console.WriteLine();

                foreach (var d in dirs)
                {

                    for (int i = 0; i < d.GetFiles().Length; i++)
                    {
                        reader = new StreamReader(new FileStream(d.GetFiles()[i].FullName, FileMode.Open, FileAccess.Read, FileShare.None));

                        Console.WriteLine("------File {0} Content------", j + 1);
                        Console.WriteLine(reader.ReadToEnd());
                        Console.WriteLine();

                        reader.Close();
                    }


                    j++;
                }

                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
