using System;
using HeadFirstCSharp8_1;

namespace Excercise2
{
    class Program
    {
        public static Random RNG = new Random();
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static Card RandomCard()
        {
            return new Card((Values)RNG.Next(1, 14), (Suits)RNG.Next(4));
        }

    }
}
