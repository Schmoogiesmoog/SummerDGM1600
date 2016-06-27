// Sample Program To Illustrate Debugger
// Calculates the gross pay for a Sales
// If a person's sales exceed $40,000 in one month, then their commission will be ten percent 
// of their sales for that month. If their sales is between $25,000 and $40,000, then their 
// commission is five percent of their sales for the month. Otherwise, their commission is 
// three percent of their sales for the month. Their gross pay is equal to a base salary of
// $1,000 each month plus their commission.

// File Prologue
// CS 1400-002
// Dustin Porter
// Lab #20
// March 2011
// 'Did not copy'

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab20DP
{
    class Program
    {
        // declare constants - no magic numbers
        const int BIG = 40000;
        const int SMALL = 25000;
        // Right here I changed both into the percentage 0.10 and 0.5.
        const double BIG_BONUS = 0.10;
        const double SMALL_BONUS = 0.5;

        static void Main(string[] args)
        {
            Console.WriteLine("Dustin Porter, CS1400-002");

        double sales;
        double salary = 1000.0;
        double commission;
        // Right here I am declaring pay as a double instead of an int.
        double pay;
        char response = 'y';

        do
        {
            Console.Write("Please enter the person's Sales: ");
            sales = double.Parse(Console.ReadLine());

            if (sales < BIG)
            {
                // Right here I switched th c to a lower case.
                commission = sales * BIG_BONUS; 
            }
            else
            {
                // Right here I added the ; at the end
                commission = sales * SMALL_BONUS;
            }

            pay = salary + commission;

            Console.WriteLine("This person's gross pay will be {0}", pay);
            Console.Write("Do you want to do another (y or n)? ");
            response = char.Parse(Console.ReadLine());

        } while (response != 'y');

        Console.WriteLine("Thanks ... goodbye");
        Console.ReadLine();

        }
    }
}
