using System;
using System.Collections.Generic;
using System.Linq;
using Garden;

namespace Garden
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to our garden!");
            List<Plant> Plants = new List <Plant>(0);
            addPlant(Plants);
           

        }
        public static void addPlant(List<Plant> Plants)
        {
            Console.WriteLine("Would you like to add a plant? y/n");
            string start = Console.ReadLine();
            if(start == "y" || start == "Y")
            {
                Console.WriteLine("What type of plant are you planting?");
                string type = Console.ReadLine();
                Console.WriteLine("What do you want to name it?");
                string name = Console.ReadLine();
                Plant newPlant = new Plant(name, type);
                Plants.Add(newPlant);
                addPlant(Plants);
            }
            else
            {
                careForPlant(Plants);
            }
            
            
        }

        public static void careForPlant(List<Plant> Plants)
        {
            Console.WriteLine("Which plant would you like to care for?");
            foreach(Plant item in Plants)
            {
                Console.WriteLine("-" + item.Name);
            }
            string plantChoice = Console.ReadLine();

            Console.WriteLine($"How would you like to care for your {plantChoice}? water/food/sunshine/no thanks");
            string careChoice = Console.ReadLine();

            foreach(Plant item in Plants)
            {
                if(item.Name == plantChoice)
                {
                    if(careChoice == "food" || careChoice == "Food")
                    {
                        Console.WriteLine(item.Name);
                        Console.WriteLine(item.Feed());  
                        careForPlant(Plants);
                    }
                    else if(careChoice == "water" || careChoice == "Water")
                    {   
                        Console.WriteLine(item.Name);
                        Console.WriteLine(item.Water());  
                        careForPlant(Plants);
                    }
                    else if(careChoice == "sunshine" || careChoice == "Sunshine")
                    {
                        Console.WriteLine(item.Name);
                        Console.WriteLine(item.Sunshine());  
                        careForPlant(Plants);
                    }
                    else
                    {
                        addPlant(Plants);
                    }
                }
            }   
        }
    }
}

