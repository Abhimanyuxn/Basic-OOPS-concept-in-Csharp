using System;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Stud();
            s1.Display();

            Student s2 = new Student();
            s2.Stud();
            s2.Display();
        }
    }

    class Student
    {
        public string name;
        public int age;

        public void Stud()
        {
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            age = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Hello! " + name + " your age is " + age);
        }
    }
}