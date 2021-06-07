using System;
using System.Collections.Generic;

namespace HeadFirstCSharp8_6
{
    class Program
    {
        private static Random RNG = new Random();
        private static Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();
        static void Main(string[] args)
        {
                Console.WriteLine("Enter name of lumberjack to add. Enter 'Done' to finish.");
                string name = Console.ReadLine();
                if (name != "")
                {
                    while ((name = Console.ReadLine().ToLower()) != "done")
                    {
                        Console.WriteLine("Enter the number of flapjacks to give.");
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            Lumberjack lumberjack = new Lumberjack(name);
                            for (int i = 1; i <= number; i++)
                            {
                                lumberjack.TakeFlapjack((Flapjack)RNG.Next(0, 5));  
                            }
                            lumberjacks.Enqueue(lumberjack);
                        }
                    }
                   
                    
                        while (lumberjacks.Count > 0)
                        {
                            lumberjacks.Dequeue().EatFlapjacks();
                        }
                    

                }
                
        }
    }
}
