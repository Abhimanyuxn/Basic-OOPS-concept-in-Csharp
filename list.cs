using System;
using System.Collections.Generic;
namespace Lists
{
    class Program
    {
        static void Main(string[]args)
        {
            List<string> name = new List<string>();
            name.Add("John");
                        name.Add("ban");
                                    name.Add("ray");

                                    foreach(string item in name)
            {
                Console.WriteLine(item);
            }



        }
    }
}