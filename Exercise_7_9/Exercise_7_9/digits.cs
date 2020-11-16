/* A program that calculates how many numbers of 1, 2, 3 or more digits are
entered by the user until he/she types “end”. */

using System;

class Digits
{
    static void Main()
    {
        int oneDigitCount = 0, twoDigitCount = 0, threeDigitCount = 0, otherDigitCount = 0;

        Console.Write("Insert a number: ");
        string number = Console.ReadLine();

        while (number != "end")
        {
            int input = Convert.ToInt32(number);
            if (input != 0)
            {
                if (input / 10 == 0)
                {
                    oneDigitCount++;
                }
                else if (input / 100 == 0)
                {
                    twoDigitCount++;
                }
                else if (input / 1000 == 0)
                {
                    threeDigitCount++;
                }
                else
                {
                    otherDigitCount++;
                }
            }
            number = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigitCount, twoDigitCount, threeDigitCount, otherDigitCount);


    }
}

