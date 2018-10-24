using System;

namespace Lab1b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user 
            Console.WriteLine("Hello user, what are you in the mood for?");

            //Select activity
            Console.WriteLine("Here are your options:  1)Action 2) Chill 3)Danger 4)Good food");
            string activity = Console.ReadLine();
            int act = Convert.ToInt32(activity);

            string sActivity = null;

            if (act == 1)
            {
                Console.WriteLine("You have selected action.");
                sActivity = "Action";
            }
            if (act == 2)
            {
                Console.WriteLine("You have selected chill.");
                sActivity = "Chilling";
            }
            if (act == 3)
            {
                Console.WriteLine("You have selected danger.");
                sActivity = "Danger";
            }
            if (act == 4)
            {
                Console.WriteLine("You have selected good food.");
                sActivity = "Good Food";
            }

            //Accept how many people from user
            Console.WriteLine("How many people are you bringing with you?");
            string people = Console.ReadLine();
            int peop = Convert.ToInt32(people);
            Console.WriteLine("You have {0} people in your party.", peop);

            //Give final recommendation
            string final1 = null;
            string final2 = null;
            if (act == 1)
            {
                final1 = "Stock Car Racing";
            }
            if (act == 2)
            {
                final1 = "Hiking";
            }
            if (act == 3)
            {
                final1 = "Skydiving";
            }
            if (act == 4)
            {
                final1 = "To Taco Bell";
            }

            if (peop == 0)
            {
                final2 = "sneakers";
            }
            if (peop >= 1 && peop <= 4)
            {
                final2 = "a sedan";
            }
            if (peop >= 5 && peop <= 10)
            {
                final2 = "a Volkswagen bus";
            }
            if (peop >= 11)
            {
                final2 = "an airplane";
            }

            Console.WriteLine("Okay, if you're in the mood for {0}, then you should go {1} and travel with {2}.", sActivity, final1, final2);

        }
    }
}

