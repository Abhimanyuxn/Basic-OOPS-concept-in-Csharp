using System;
namespace Data
{
    class Program
    {
        public static string name;
        public static string age;
        static void Main(string[]args)
        {
            Name.Nam();  
            Age.Ag();
            Console.WriteLine("Hello " + name + ", your age is " + age);

        }
    }
    class Name
    {
        public static void Nam()
        {
            Console.Write("enter your name ");
            Program.name=Console.ReadLine();

         }
    }

    class Age
        {
            public static void Ag()
        {
            Console.Write("enter your name ");
            Program.age=Console.ReadLine();
        }
        }
}