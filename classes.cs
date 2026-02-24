using System;

namespace Myprogram
{
class Progam
{
    static void Main(string[]args)
    {
        Mess.Hello();
        Name.Nam();
    }
}

class Mess
{
    public static void Hello()
    {
    Console.WriteLine("hello");
    }
  }

class Name
    {
        public static void Nam()
        {
            Console.Write(" enter your name : ");
            string name =Console.ReadLine();
        }
    }
}