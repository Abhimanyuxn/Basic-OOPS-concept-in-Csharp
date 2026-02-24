using System;
namespace Marks
{
    class Program
    {
        public static string name;
        public static int marks;
        static void Main(string[]args)
        {
            Student.child();
            Console.WriteLine("Hello "+name +" your marks are " +marks);

            if(marks<=33)
            {
                Console.WriteLine("FAIL");
            }
            else if (marks<0 || marks>100)
            {
            Console.WriteLine("Invalid Marks");
            }
            else
            {
            Console.WriteLine("PASS");
            }
        }
    }
    class Student
    {
        public static void child()
        {
            Console.Write("enter your name : ");
            Program.name = Console.ReadLine();

            Console.Write("enter your marks : ");
            Program.marks =int.Parse(Console.ReadLine());

            
        }
    }
}