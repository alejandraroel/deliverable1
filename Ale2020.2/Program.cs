using System;
using System.IO;

namespace Ale2020
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string vacationType;

            int groupSize;

            string travelSuggestion = null;

            string destination = null;

            string result;


            Console.WriteLine("What kind of trip would you like to go on musical,tropical, or adventurous? ");

            vacationType = Console.ReadLine();


            if (vacationType == "musical")
            {
                destination = "new orleans";

            }
            else if (vacationType == "tropical")
            {
                destination = "Beach Vacation in Mexico";
            }

            else if (vacationType == "adventurous")
            {
                destination = "Whitewater Rafting the Grand Canyon";
            }
            else
                Console.WriteLine("not a valid vacation type");



            Console.WriteLine("How Many are in your group?");



            groupSize = Convert.ToInt32(Console.ReadLine());


            if (groupSize > 0 && groupSize <= 2)
            {
                travelSuggestion = "first class";
            }

            else if (groupSize >= 3 && groupSize <= 5)
            {
                travelSuggestion = "Helicopter";
            }
            else
                travelSuggestion = "Charter flight";






            result = $" Since you are a group of {groupSize} going on a {vacationType} vacation, you should take a {travelSuggestion} to {destination}";

            Console.WriteLine(result);




        }
    }
}
