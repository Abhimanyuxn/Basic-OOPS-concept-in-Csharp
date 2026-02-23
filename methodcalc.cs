using System;
class Calc
{
    static void Main(string[]args)
    {
       Console.WriteLine("enter first number");
       int a = int.Parse(Console.ReadLine());

       Console.WriteLine("enter operator");
       string op=Console.ReadLine();

       Console.WriteLine("enter second number"); 
       int b = int.Parse(Console.ReadLine()); 

       if(op=="+")
       {
       Add(a,b);
       }

       else if(op=="-")
    {
       Diff(a,b);
    }

    }
    static void Add(int a , int b)
    {
     int sum=a+b;
        Console.WriteLine("sum is " +sum);
    }
    static void Diff(int a , int b)
    {
        int diff=a-b;
        Console.WriteLine("Difference is " +diff);
    }
}