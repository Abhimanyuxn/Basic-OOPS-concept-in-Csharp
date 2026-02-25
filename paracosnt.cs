using System;
namespace Para
{
    class Program
    {
        static void Main(string[]args)
        {
           Student s1 = new Student("Abhimanyu", 20);
           s1.Display(); 
        }
    }
    class Student
    {
        string name;
        int age;
        public Student(string n , int a)
        {
            name =n;
            age =a;

        }
        public void Display()
        {
            Console.WriteLine("name " + name +"age "+age);
        }
    }
}