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
            int progress = 0;

            do
            {
                Console.WriteLine("\n1 - Take A Step\n2 - Count Progress\n3 - Stop Climbing");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            progress++;
                            if (progress == 4 || progress == 13) // 4 and 13 are considered unlucky numbers in certain cultures
                            {
                                Console.WriteLine("This step is unlucky and has been skipped over.");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"Step {progress} has been taken.");
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine($"You have taken {progress} steps.");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("You have stoped climbing the staircase.");
                            progress = goal;
                            break;
                        }
                }
                
            }
            while (progress < goal);
        }
    }
}
