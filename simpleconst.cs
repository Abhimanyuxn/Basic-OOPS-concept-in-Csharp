using System;
namespace Const
{
    class Program
    {
        static void Main(string[]args)
        {
            Student s1 =new Student();
            s1.Display();
        }
    }

    class Student
    {
        string name;
        public Student()

        {
            name= "Abhimanyu";
            Console.WriteLine("Constructor Called");

        }
        public void Display()
        {
            Console.Write("hello " +name);
        }
    }
}