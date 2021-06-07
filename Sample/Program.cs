using System;
using System.Collections.Generic;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> myList = new List<String>();
            myList.Add("Poopy");
            myList.Add("Pretty");
            foreach (string item in myList)
            {
                myList.Add("Dark");
                Console.WriteLine(item + " " + "Butthole");
            }
        }
    }
}
