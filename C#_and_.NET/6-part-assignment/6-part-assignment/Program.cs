using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_part_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //A one-dimensional array of strings.
            string[] countryArray = new string[] { "USA", "Brazil", "Ireland", "France", "Greece" };

            //Ask the user to input some text.
            Console.WriteLine("Input a name of country you know:");
            string countryNmae = Console.ReadLine();

            //A loop that iterates through each string in the array
            //and adds the user's text input to the end of each string.
            //This step will update each array element by appending the user's text.

            for (int i = 0; i < countryArray.Length; i++)
            {
                countryArray[i] += " " + countryNmae;
            }

            //A second loop that prints off each string in the array one at a time.

            foreach (string country in countryArray)
            {
                Console.WriteLine(country);
            }


            // An infinite loop.
            //int i = 0;
            //while (i < 9)
            //{
            //    Console.WriteLine(i);
            //}


            //Fix the infinite loop by adding i++; so that it will execute properly.
            int j = 0;
            while (j < 9)
            {
                Console.WriteLine(j);
                j++;
            }

            //A loop where the comparison that’s used to determine
            //whether to continue iterating the loop is a “<” operator.

            int g = 0;
            while (g < 8)
            {
                Console.WriteLine(g);
                g++;
            }

            // Loop where the comparison that’s used to determine
            // whether to continue iterating the loop is a “<=” operator.

            int h = 0;
            while (h <= 7)
            {
                Console.WriteLine(h);
                h++;
            }

            //CONSOLE APP PART FOUR ASSIGNMENT
            //A list of strings where each item in the list is unique.
            string[] color = { "blue", "yellow", "red", "pink", "purple", "green", "white", "orange", "brown" };
            List<string> colorlist = new List<string>(color);

            //Ask the user to input text to search for in the list.
            Console.WriteLine("Input your favorite color:");
            string colorNmae = Console.ReadLine();

            //A loop that iterates through the list and then displays
            //the index of the list item that contains matching text on the screen.
            int n = 0;
            for (int k = 0; k < colorlist.Count; k++)
            {
                if (colorlist[k] == colorNmae) 
                {
                    Console.WriteLine(k);
                    n++;
                    break; //Add code that stops the loop from executing once a match has been found.
                }
            }

            //Add code to check if the user put in text that isn't on the list and,
            //if they did, tell the user their input is not on the list. 
            if ( n == 0 )
            {
                Console.WriteLine("The color you choose is not on the list :( ");
            }


            //CONSOLE APP PART FIVE ASSIGNMENT
            //A list of strings that has at least two identical strings in the list.
            string[] city = { "Tampa", "Orlando", "Sarasota", "Miami", "Tallahassee", "Tampa", "Jacksonville", "Miami"};
            List<string> citylist = new List<string>(city);

            //Ask the user to select text to search for in the list.
            Console.WriteLine("Write a city name in Florida:");
            string cityNmae = Console.ReadLine();

            //Create a loop that iterates through the list and then displays the indices of
            //the items matching the user-selected text. Ensure to remove any break statements
            //that may prevent your code from returning multiple matches.
            int m = 0;
            for (int l = 0; l < citylist.Count; l++)
            {
                if(citylist[l] == cityNmae)
                {
                    Console.WriteLine(l);
                    m++;
                }
       
            }

            //Add code to the loop to check if the user put in text that isn't on the list and,
            //if they did, tells the user their input is not on the list. (You do not need
            //to provide any additional chances for the user to enter text.)
            if (m == 0)
            {
                Console.WriteLine("The city you choose is not on the list :( ");
            }



            //CONSOLE APP PART SIX SUBMISSION ASSIGNMENT
            //Create a list of strings that has at least two identical strings in the list.
            string[] animals = { "Elk", "Mosse", "Bison", "Beaver", "Eagle", "Bear", "Beaver", "Bear" };
            List<string> animalList = new List<string>(animals);

            // Temporary empty list, for checking duplicates.
            List<string> animalList2 = new List<string>();

            //Create a foreach loop that evaluates each item in the list, and displays
            //a message showing the string and whether or not it has already appeared in the list.

            foreach (string animal in animalList)
            {
                animalList2.Add(animal);
                int duplication = animalList2.Count(S => S == animal);
                if(duplication >= 2)
                {
                    Console.WriteLine(animal + " - this item is duplicate");
                }
                else
                {
                    Console.WriteLine(animal + " - this item is a unique");
                }

            }

                Console.ReadLine();
        }
    }
    
}
