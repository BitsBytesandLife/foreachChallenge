using System;
using System.Collections.Generic;

namespace foreachChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"FOREACH CHALLENGE \n" +
                              "GOAL \n" +
                              "Create a Console app that has a List<string>populated \n" +
                              "with a set of names.Loop through the names using \n" +
                              "the foreach.For every name, print it to the console. \n");

          List<string> names = new List<string>();
            names.Add("Reed");
            names.Add("Ben");
            names.Add("Sue");
            names.Add("Johnny");

            foreach (var name in names)
            {
                Console.WriteLine($"First Name: {name}");
            }

            //Bonus:
            Console.WriteLine();
            Console.WriteLine("Bonus Section  \n" +
                "Instead of strings, make a class and create a set of \n" +
                "instances of that class instead. The class should store \n" +
                "first and last names.Use those properties when \n" +
                "printing out the message on the console.");

            person one = new person("Reed", "Richards");
            person two = new person("Sue", "Richards");
            person three = new person("Johnny", "Storm");
            person four = new person("Benjamin", "Grimm");
            person five = new person("Peter", "Parker");
            person six = new person("Scott", "Summmers");
            person seven = new person("Jean", "Grey");
            person eight = new person("Luke", "Cage");
            person nine = new person("Ororo", "Munroe");
            person ten = new person("Miles", "Morales");


            List<person> Marvel = new List<person>();
            Marvel.Add(one);
            Marvel.Add(two);
            Marvel.Add(three);
            Marvel.Add(four);
            Marvel.Add(five);
            Marvel.Add(six);
            Marvel.Add(eight);
            Marvel.Add(nine);
            Marvel.Add(ten);


            foreach (var item in Marvel)
            {
                Console.WriteLine($"Name: {item.lastName},{item.firstName}");

            }
        }
    }


}
