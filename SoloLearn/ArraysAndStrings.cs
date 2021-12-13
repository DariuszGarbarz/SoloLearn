using System;
using System.Collections.Generic;

namespace SoloLearn
{
    /* Problem Explanation
     * Words

The program you are given defines an array with 10 words and takes a letter as input.
Write a program to iterate through the array and output words containing the taken letter.
If there is no such word, the program should output "No match".

Sample Input
u

Sample Output
fun
Recall the Contains() method.
     * 
     * 
     * 
     */
    public class ArraysAndStrings
    {
        static void Main4(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            //your code goes here
            Sort(words, letter);
        }
        public static List<string> Sort(string[] words, string letter)
        {
            int count = 0;
            List<string> list = new List<string>();

            //your code goes here
            foreach (string element in words)
            {
                if (element.Contains(letter))
                {
                    Console.WriteLine(element);
                    list.Add(element); //testing purposes
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No match");
                list.Add("No match"); //testing
            }

            return list;
        }
    }
}