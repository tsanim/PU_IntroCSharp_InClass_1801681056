using System;
using System.Text;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine((int)5000);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\fmi\Desktop\WorkFolderTsM\PU_IntroCSharp_InClass_1801681056\PUInClassW3\CandyShop\files\Students.txt");
           
           
            System.Console.WriteLine("Contents of Students.txt = ");
            int tStudents = 0;
            foreach (string line in lines)
            {
                string[] elements = line.Split(" ");
                              
                string firstName = elements[1];
                string name = $"{firstName} {elements[3]}";

                int sum = 0;
                for (int i = 0; i < firstName.Length; i++)
                {
                    sum += (int)firstName[i];
                }

                if (sum>9000)
                {
                    tStudents += 1;
                    Console.WriteLine($"Candy for {name} => {firstName.Length}");
                }



         
            }

            Console.WriteLine($"Total Lines {lines.Length}");
            Console.WriteLine($"Total candy students:{tStudents}");

        }
    }
}
