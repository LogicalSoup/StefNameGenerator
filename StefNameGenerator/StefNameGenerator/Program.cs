using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefNameGenerator
{
    public class MakeNames
    {
        int firstvalue, secondvalue, thirdvalue, check;
        System.Random rand = new System.Random();
        //List names here, broken in "Stef" "Stock""all"
        List<string> first = new List<string>
            {
                "Jeff",
                "Beth",
                "Stefano",
                "Stef",
                "Steaf",
                "Steafanie",
                "Chefanie",
                "Gosh",
                "Gregg",
                "Mash",
                "Willian",
                "Jesus"
            };

        List<string> second = new List<string>()
            {
                "Stock",
                "Step",
                "Sock",
                "Sponge",
                "Knock",
                "Gazzad",
                "Berry",
                "Gizzard",
                "Plender",
                "Lizzard",
                "Goddard",
                "Bait",
                "Almond"
            };

        List<string> third = new List<string>()
            {
                "well",
                "all",
                "ball",
                "wall",
                "room",
                "call",
                "bob",
                "fool",
                "cube",
                "sleigh",
                "leith",
                "zone"
            };

        public void Name()
        {
            //Randomise name based on random value in list index
            firstvalue = rand.Next(0, first.Count);
            secondvalue = rand.Next(0, second.Count);
            thirdvalue = rand.Next(0, third.Count);
            //Have 1/10 chance of having 'Chef' as middle name
            check = rand.Next(0, 10);

            //Construct and display name
            if (check == 5)
            {
                Console.WriteLine(first[firstvalue] + " Chef" + " " + second[secondvalue] + third[thirdvalue]);
            }
            else
            {
                Console.WriteLine(first[firstvalue] + " " + second[secondvalue] + third[thirdvalue]);
            }
            Console.WriteLine("Press Enter to change");
            Console.ReadLine();
            Name();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            Console.WriteLine("Stef Stockall");
            Console.WriteLine("Press Enter to change");
            Console.ReadLine();
            MakeNames Here = new MakeNames();
            Here.Name();
        }
    }
}
