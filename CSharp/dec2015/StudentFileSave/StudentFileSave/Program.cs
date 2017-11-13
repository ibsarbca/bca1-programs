using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StudentFileSave
{
    class Program
    {
        class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public string Qualification { get; set; }
            public double Percentage { get; set; }

            public Student GetData()
            {
                StreamReader reader = new StreamReader(
                    "data.txt");

                Student retval = new Student();
                retval.StudentId = Int32.Parse(reader.ReadLine());
                retval.Name = reader.ReadLine();
                retval.Qualification = reader.ReadLine();
                retval.Percentage = Int32.Parse(reader.ReadLine());

                return retval;
                
            }

            public void ShowData()
            {
                Console.WriteLine("#############");
                Console.WriteLine("STUDENT DATA:");
                Student std = GetData();
                Console.WriteLine(std.StudentId);
                Console.WriteLine(std.Name);
                Console.WriteLine(std.Qualification);
                Console.WriteLine(std.Percentage);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Details");
            Student std = new Student();
            Console.WriteLine("ID:");
            std.StudentId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("NAME:");
            std.Name = Console.ReadLine();
            Console.WriteLine("QUALIFICATION");
            std.Qualification = Console.ReadLine();
            Console.WriteLine("PERCENTAGE:");
            std.Percentage = Int32.Parse(Console.ReadLine());


            StreamWriter writer = new StreamWriter("data.txt");

            writer.WriteLine(std.StudentId);
            writer.WriteLine(std.Name);
            writer.WriteLine(std.Qualification);
            writer.WriteLine(std.Percentage);

            writer.Close();
            std.ShowData();

            Console.ReadLine();
        }
    }
}
