using System;
using System.Collections.Generic;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string zilch = "zero";
            string first = "one";
            string second = "two";
            string third = "three";
            string fourth = "4.2";
            string twopointtwo = "2.2";

            List<string> a = new List<string>();

            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);


            if (a.Contains("three"))
                a.Add("four");

            a.RemoveAt(2);

            if (a.IndexOf("four") != 4)
                a.Add(fourth);

            if (a.Contains("two"))
                a.Add(twopointtwo);

            PppPppL(a);
        }

        static void PppPppL (List<string> a)
        {
            foreach (string element in a )
            {
                Console.WriteLine(element);
            }
        }
    }
}
