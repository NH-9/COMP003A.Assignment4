using System;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Stair Climbing Simulator---");
            Console.Write("How many steps would you like to climb?: ");
            int goal = int.Parse(Console.ReadLine());
        }
    }
}
