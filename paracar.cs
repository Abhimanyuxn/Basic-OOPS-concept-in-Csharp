using System;
namespace Aston
{
    class Program
    {
        static void Main(string[]args)
        {
           Car c1= new Car("Aston martin",3 );
           c1.Display(); 

           Car c2= new Car("AMG Merceds",5 );
           c2.Display(); 
        }
    }
    class Car
    {
        string name;
        int year;

        public Car(string n, int y)
        {
            name=n;
            year=y;
        }

        public void Display()
            {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Years:" + year);
        }
        
    }
}