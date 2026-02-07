using System;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * This is used to contextualize the program and to seperate the the loop condition from the saftey limit condition.
             * If the initial number of steps is static then only one of those 2 conditions would ever stop the program making it redundant.
            */
            Console.WriteLine("---Stair Climbing Simulator---");
            Console.Write("How many steps would you like to climb?: ");
            int goal = int.Parse(Console.ReadLine());
            
            int progress = 0;
            string menu = "1 - Take A Step\n2 - Count Progress\n3 - Stop Climbing\n4 - Display Menu";
            Console.WriteLine($"\n{menu}");

            /*
             * The purpose of this loop is to let the user continously interact with the menu
             * while receiving feedback from each input.
             * It will run until either the user's goal is reached or the user manually exits the menu.
            */
            do
            {
                Console.Write("\nEnter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            // using the standard step height of 7 inches this would be about 10 feet high
                            // falling from this height would likely cause injury
                            if (progress >= 17)
                            {
                                Console.WriteLine("It is too dangerous to go any higher.");
                                continue;
                            }
                            
                            progress++;

                            // 4 and 13 are considered unlucky numbers in certain cultures
                            if (progress == 4 || progress == 13) 
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
                            continue;
                        }

                    case 4:
                        {
                            Console.WriteLine(menu);
                            break;
                        }
                }
                
                if (progress >= goal)
                {
                    Console.WriteLine("You have completed your climb!");
                }
            }
            while (progress < goal);
        }
    }
}
