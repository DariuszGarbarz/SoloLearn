using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    public class StructsEnumsExceptionsAndFiles
    {
        /* Problem Explanation
         * 
        Robot-barman


You have a robot-barman and his goal is to neatly arrange drinks on the shelves of the bar. He is very smart and takes as many drinks as are necessary to evenly distribute them on the shelves, but he still has problems with division.

The program installed in the robot takes the number of drinks and the number of the shelves as input.
Complete the program to evenly distribute the drinks on shelves: by dividing the number of drinks by the number of shelves and outputting the result.
The program must also, handle those two possible problems:
1. the divider (the number of shelves) should never be zero
2. both inputs should be integers.
For the first exception, the program should output "At least 1 shelf" and for the second, "Please insert an integer".

Sample Input
6
two

Sample Output
Please insert an integer
Use DivideByZeroException for the first exception and FormatException for the second one. * 
         * 
         * 
         */

        public static string Main7(string drinks, string shelves)
        {

            try
            {
                int drinks1 = Convert.ToInt32(drinks);
                int shelves1 = Convert.ToInt32(shelves);

                //your code goes here
                Console.WriteLine(drinks1 / shelves1);
                string result = (drinks1 / shelves1).ToString(); // testing purposes
                return result;
            }
            /*
             * 1. DivideByZeroException => "At least 1 shelf"
             * 2. FormatException => "Please insert an integer"
            */
            catch (DivideByZeroException e)
            {
                Console.WriteLine("At least 1 shelf");
                string result = "At least 1 shelf"; // testing purposes
                return result;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please insert an integer");
                string result = "Please insert an integer"; // testing purposes
                return result;
            }
            
        }
    }
}
