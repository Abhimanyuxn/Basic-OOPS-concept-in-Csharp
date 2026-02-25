using System;
namespace Setgo
{
   class Program
    {
        static void Main(string[]args)
        {
            Run s1= new Run(50);
            s1.Speed=150;
            s1.Display();
        }
    }

    class Run
    {
        public int speed;
        public Run(int speed)
        {
            this.Speed=speed;
        }

        public void Display()
        {
            Console.WriteLine(speed);
        }
        public int Speed
        {
            get{return speed;}
            set { 
                if(value>100)
                speed=100;
                else
                {
                speed = value;
                }
                }
        }
        

    }
}