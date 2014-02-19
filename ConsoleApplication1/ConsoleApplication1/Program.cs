﻿using System; // for the console object
using System.Collections.Generic;
using System.Linq;
using System.Text;

  

class addtwonumbers
{
    public static int addIntegers(int a, int b)
    {
        return (a + b);
    }

    public static void Main()
    {
        try
        {
            // output to the console
            Console.Write("Please enter value 1 : ");
            // readin the console input, and then convert to a integer value
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter value 2 : ");
            int val2 = Convert.ToInt32(Console.ReadLine());
            // write out the answer 
            Console.WriteLine("Answer = " + addIntegers(val1, val2));
        }
        catch (Exception e)
        {
            // any errors. Like converting a string to a integer value
            Console.WriteLine("Error : " + e.ToString());
        }
    }
}