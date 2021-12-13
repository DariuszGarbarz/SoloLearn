using System;
using System.Collections.Generic;

namespace SoloLearn
{
    /* Problem Explanation
 * Level Points


Passing the first level of a video game awards the player 1 point. For each subsequent level passed, the points awarded increment by 1 (2 for the 2nd level, 3 for the 3rd, and so on).
The program you are given takes the number of passed levels as input. Complete the given function to take that number as an argument, and recursively calculate and return the total number of points given for all passed levels.

Sample Input
3

Sample Output
6

Explanation
Level 1: 1 point
Level 2: 2 points
Level 3: 3 points
Total: 1+2+3 = 6 points.
Don't forget about the base case.
 * 
 * 
 */
    public class Methods
    {
        static void Main2(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }


        public static int Points(int levels)
        {
            //your code goes here
            int sum = 0;

            for (int i = levels; i > 0; i--)
            {
                sum += i;
            }
            return sum;

        }

    }

}