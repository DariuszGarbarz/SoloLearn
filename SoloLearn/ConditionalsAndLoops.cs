using System;

namespace SoloLearn
{
    /* Problem Explanation
     * Multiple of 3
You are an elementary school teacher and explaining multiplication to students.
You are going to use multiplication by 3 as your example.
The program you are given takes N number as input. Write a program to output all numbers from 1 to N, replacing all numbers that are multiples of 3 by "*".

Sample Input
7

Sample Output
12*45*7
The N number is a multiple of 3 if N%3==0.
     * 
     */
    public static class ConditionalsAndLoops
    {
        static void Main1(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            //your code goes here
            int multiple = 3;

            Console.WriteLine(Multiples(number, multiple));
        }
        public static string Multiples(int number, int multiple)
        {
            string result = null;
            for (int x = 1; x <= number; x++)
            {
                if (x % multiple == 0)
                {
                    result += "*, ";
                }
                else
                {
                    result += x + ", ";
                }
            }
            return result;
        }
    }
}

