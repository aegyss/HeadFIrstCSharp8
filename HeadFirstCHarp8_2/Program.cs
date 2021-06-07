using System;
using System.Collections.Generic;

namespace HeadFirstCSharp8_2
{
    class Program
    {
        static ShoeCloset shoeCloset = new ShoeCloset();
        static void Main(string[] args)
        {
            Shoe myShoe = new Shoe(Style.Sneaker, "Black");
            Console.WriteLine($"{myShoe.Description}");
        }
    }

    class Shoe
    {
        public Style Style { get; private set; }
        public string Color { get; private set; }
        public string Description { get { return $"A {Color} {Style}"; } }

        public Shoe(Style style, string color)
        {
            Style = style;
            Color = color;
        }

        
    }

    enum Style
    {
        Sneaker,
        Loafer,
        Sandal,
        FlipFlop,
        Wingtip,
        Clog,
    }

    class ShoeCloset
    {
        private readonly List<Shoe> shoes = new List<Shoe>();

        public void PrintShoes()
        {
            if (shoes.Count == 0)
                Console.WriteLine("\nThe shoe closet is empty.");
            else
                Console.WriteLine("\nThe shoe closet contains:");
            int i = 1;
            foreach (Shoe shoe in shoes)
            {
                Console.WriteLine($"Shoe #{i++}: {shoe.Description}.");
            }
        }

        public void AddShoe()
        {
            Console.WriteLine("\nAdd a shoe.");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Press {i} to add a {(Style)i}.");
            }
            Console.Write("Enter a style: ");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int style))
            {
                Console.Write("\nEnter the color: ");
                string color = Console.ReadLine();
                Shoe shoe = new Shoe((Style)style, color);
                shoes.Add(shoe);
            }
        }

        public void RemoveShoe()
        {
            Console.Write("\nEnter the number of the shoe to remove: ");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int shoeNumber) && (shoeNumber >= 1) && (shoeNumber <= shoes.Count))
            {
                Console.WriteLine($"\nRemoving {shoes[shoeNumber - 1].Description}");
                shoes.RemoveAt(shoeNumber - 1);
            }

        }
    }
}
