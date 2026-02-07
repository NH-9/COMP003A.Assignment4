using System;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is used to contextualize the program and to seperate the the loop condition from the saftey limit condition
            // if the initial number of steps is static then only one of those 2 conditions would ever stop the program making it redundant
            Console.WriteLine("---Stair Climbing Simulator---");
            Console.Write("How many steps would you like to climb?: ");
            int goal = int.Parse(Console.ReadLine());

            for (int i = 0; i < goal; i++)
            {
                Console.WriteLine("\n1 - Take A Step\n2 - Count Progress\n3 - Stop Climbing");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
            }
        }
    }
}
