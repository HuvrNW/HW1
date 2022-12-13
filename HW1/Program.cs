using System;

namespace HW1
{
    internal class Program
    {
        static void PrintName(string _name)
        {
            Console.WriteLine("Hello, ");
                for (int i = 0; i < _name.Length; i += 2)
                {
                    Console.Write(_name[i] + "\n");
                }
            Console.WriteLine("!");
        }

        static void Main(string[] args)
        {
            string name = "";
           
                Console.WriteLine("Как вас зовут?");
                name = Console.ReadLine();
                PrintName(name);

            Console.ReadKey();
        }
    }
}
