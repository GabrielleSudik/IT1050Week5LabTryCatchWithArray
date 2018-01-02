using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5LabTryCatchWithArray
{
    /*  Define an array of integers, 7 elements in length. This will store a temperature for each day
·         Create a for loop that asks user what the temperature is for each day and save that value into the array.
·         Wrap the input with a try/catch block. If the user enters erroneous data (such as POTATO instead of 34), force the user to re-enter the same data point until correct
·         HINT, you may need to use a loop AND a try/catch block, or you can decrement your counter value and use a continue statement
·         HINT, write pseudocode before you do this
·         Create another loop, a foreach loop this time, that grabs the values out of the array and saves them into a total variable
·         Divide that value by 7 and display the average temperature to the user */

    class Program
    {
        private const int numberOfDays = 7; 

        static void Main(string[] args)
        {
            int[] temps = new int[numberOfDays]; //set array length to 7 (or "numberOfDays")

            for (int counter = 0; counter < numberOfDays; counter++) //7 times, get temp for each day.
                try
            {
                
                {
                    Console.WriteLine($"What's the temperature on day {counter + 1}?");
                    temps[counter] = int.Parse(Console.ReadLine());
                }
            }

                
                    catch (Exception ex)
                    {
                    Console.WriteLine("Sorry that's an inappropriate response. Try again.");
                    } 
            

            int total = 0; //initialize total temps for week

            foreach (int temp in temps) //add each element to total
            {
                total += temp;
            }

            int average = total / numberOfDays;  //finds average

            Console.WriteLine($"\nThe average temperature over the last 7 days was {average}."); //prints average
            Console.ReadLine();
        }
    }
}
