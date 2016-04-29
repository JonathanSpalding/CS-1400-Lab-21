// Author: Jonathan Spalding
// Assignment: Lab 21
// Instructor: Roger deBry
// Class: CS 1400
// Date Written: 3/24/2016
//
// I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I a found in violation of this policy.
//-----------------------------

using System;

class Program
{
    // some  class level constants
    const int HALVES = 50;
    const int QUARTERS = 25;
    const int DIMES = 10;
    const int NICKELS = 5;
    const int PENNIES = 1;

    static void Main()
    {
        int money;  // the value we want to count change for

        Console.WriteLine("I will make change for you.");
        Console.Write("Enter in an amount between 1 and 99: ");
        money = int.Parse(Console.ReadLine());

        Console.WriteLine("For {0} you get:", money);

        Console.WriteLine("{0} halves", ComputeChange(ref money, HALVES));
        Console.WriteLine("{0} quarters", ComputeChange(ref money, QUARTERS));
        Console.WriteLine("{0} dimes", ComputeChange(ref money, DIMES));
        Console.WriteLine("{0} nickels", ComputeChange(ref money, NICKELS));
        Console.WriteLine("{0} pennies\n", ComputeChange(ref money, PENNIES));
        Console.ReadLine();
    }

    // The ComputeChange Method
    // Add your method prologue here
    static int ComputeChange(ref int changeValue, int coinValue)
    {
        // you provide the method to compute change here
        {
            // check to see if the money is large enough to have any .50 cent pieces taken out.
            if (coinValue >= HALVES)
            {
                // find out how many .50 cent pieces you can take out.
                coinValue = changeValue / HALVES;
                // subtract the 50 cent pieces from the reference value
                changeValue = changeValue - (coinValue * HALVES);
            }
            // check to see if the money is large enough to have any quarters taken out.
            else if (coinValue >= QUARTERS)
            {
                // Find out how many quarters you can take out.
                coinValue = changeValue / QUARTERS;
                // remove the quarters from reference value
                changeValue = changeValue - (coinValue * QUARTERS);
            }
            // Check to see if the money is large enough to have any dimes taken out.
            else if (coinValue >= DIMES)
            {
                // Find out how many dimes you can take out.
                coinValue = changeValue / DIMES;
                // Remove the dimes from the reference value.
                changeValue = changeValue - (coinValue * DIMES);
            }
            // Check to see if the money is large enough to have any Nickles taken out.
            else if (coinValue >= NICKELS)
            {
                // Find out how many nickles you can take out.
                coinValue = changeValue / NICKELS;
                // Remove the nickles from the reference value.
                changeValue = changeValue - (coinValue * NICKELS);
            }
            else
            {
                //Find the remainder pennies
                coinValue = changeValue / PENNIES;
            }
            //compute the value after .01 pieces
            return coinValue;
        }
    }
}