/*
 * Parking Ticket Console App
 * Copyright (C) 2025 Matthew Amorelli
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using System;

namespace CalculateChargesConsoleApp
{
    
    class Program
    {
        private static double money;
        static void Main(string[] args)
        {
            //declare variables
            int hours = 0;
           double money = 0;

            //display a welcome screen
            Console.WriteLine("Welcome to the parking pay station");

            //while the hours is not negtive(because that doesn’t make sense) ask the user to enter a amount of hours
            //and then call the CalcuateCharges method

            while (0 <= hours)
            {

                //ask the user for the number of hours
                Console.Write("enter the amount of hours that your car was parked: ");
                if(int.TryParse(Console.ReadLine(), out hours))

                {
                //call the calcuateCharges method
                money = CalculateCharges(hours);

                }


            }

            }



        /// <summary>
        /// CalcuateCharges method
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        private static double CalculateCharges(int hours)
        {

            //save the formal total
            double formaltotal = money;

            //if hours are more than 0 and less than 3 the minimal charge will be 2.00 dollars
            if (hours >= 0 && hours <= 3)
            {


                money += 2.00;
                double currentCharge = 2.00;
                //display the current charge and yesturdays total
                Console.WriteLine($"the charge is ${currentCharge} and yesterday it was ${formaltotal}");

            }

            //if hours are more than 3 and less than or equal to 23 the minimal charge is based on the hours times 50 cents
            //plus $2.00
            else if (hours > 0 && hours <= 23)
            {

                money += (hours * 0.50 + 2);
                double currentCharge = (hours * 0.50 + 2);

                //display the current charge and yesturdays total
                Console.WriteLine($"the charge is ${currentCharge} and yesterday it was ${formaltotal}");
            }
            //if hours is greater than or equal to 24 than the max charge is 10.00 dollars
            else if (hours > 0 && hours <= 24)
            {
                money += 10.00;
                double currentCharge = 10.00;
                //display the current charge and yesturdays total
                Console.WriteLine($"the charge is ${currentCharge} and yesterday it was ${formaltotal}");

            }

            //else statement that says to enter a number between 1 and 24 for the number of hours
            else
            {
                Console.WriteLine("Please enter a valid number");
            }

            //return the money variable
            return money;
        
        }
    }
}
