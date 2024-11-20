using System;

namespace Program_to_calculate_Total_no_of_ICS_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the ICS count
            int totICS = 0;
            int cnt = 1;

            // Loop to get input from 5 students
            while (cnt <= 5)
            {
                Console.WriteLine("From which background (Pre-Engineering, Pre-Medical, Computer Science) do you belong?");
                string input = Console.ReadLine();

                // Check if the input matches "Computer Science"
                if (input.Equals("Computer Science", StringComparison.OrdinalIgnoreCase)) // Case-insensitive comparison
                {
                    totICS++; // Increment total ICS students
                }
                cnt++;
            }

            // Output the total number of ICS students
            Console.WriteLine("Total no of ICS students = {0}", totICS);
        }
    }
}
