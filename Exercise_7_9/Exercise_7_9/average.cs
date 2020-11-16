/* A program that calculates the average of a set of marks, until the user types
“end”. */

using System;
public class Average
{
    public static void Main()
    {
        double markSum = 0, markValue, counter = 0, average;
        string mark;

        Console.Write("Insert a mark: ");
        mark = Console.ReadLine();

        while (mark != "end")
        {
            markValue = Convert.ToDouble(mark);
            counter++;   
            markSum += markValue;  
            Console.Write("Insert a mark: ");
            mark = Console.ReadLine();
        }
        if (counter != 0)
        {
            average = markSum / counter;  
            Console.WriteLine("The average is {0}.", average);
        }
    }
}
