using System;

namespace HeadFirstCSharp8_1
{
    class Program
    {
        private static Random RNG = new Random();
        static void Main(string[] args)
        {
            Card aceOfSpades = new Card(Values.Ace, Suits.Spades);
            Console.WriteLine(aceOfSpades.Name);
            while (true)
            {   
            Card randomCard = new Card((Values)RNG.Next(1, 14), (Suits)RNG.Next(0, 4));
            Console.WriteLine(randomCard.Name);
                Console.ReadKey(true);
            }
        }
    }


}
