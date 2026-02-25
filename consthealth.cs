using System;

namespace Health
{
    class Program
    {
        static void Main(string[] args)
        {
            Health h1 = new Health(28);
            h1.Display();
        }
    }

    class Health
    {
        public string name;
        public int heal;

        public Health(int heal)
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            this.heal = heal;
        }

        public void Display()
        {
            Console.WriteLine("Name " + name + " health is " + heal);
        }
    }
}