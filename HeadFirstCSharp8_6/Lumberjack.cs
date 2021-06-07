using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstCSharp8_6
{
    class Lumberjack
    {

        public string Name { get; set; }
        private Stack<Flapjack> flapjackStack { get; set; } = new Stack<Flapjack>();


        public Lumberjack(string name)
        {
            Name = name;
        }

        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks.");
            while (flapjackStack.Count > 0)
            {
                Console.WriteLine($"Eating {flapjackStack.Pop()}.");
            }
        }

    }

    enum Flapjack
    {
        Crispy, 
        Soggy,
        Browned,
        Banana,
    }
}
