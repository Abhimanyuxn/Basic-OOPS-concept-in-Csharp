using System;
class method
{
    static void Main(string[]args)

    {
        Console.Write("enter your name : ");
        string name =Console.ReadLine();
        if(name=="Abhimanyu"|| name=="Rohit")
        {
        hill(name);
        }
        else 
        Console.Write("Invalid name ");
    }
    static void hill(string name )
    {
        Console.WriteLine("you won " + name);
    }
}