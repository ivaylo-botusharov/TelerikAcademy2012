﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringOccurrenceCount
{
    class StringOccurrenceCount
    {
        //Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
       
        static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else. " + 
                @"Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine(text);
            string pattern = "in";
            int patternCount; 
            patternCount = CountStringOccurrences(text.ToLower(), pattern);
            
            /* Alternatively use: 
             * 1. Regex (Case-insensitive): patternCount = Regex.Matches(text.ToLower(), pattern).Count;
             * 2. Regex (Case-sensitive): patternCount = Regex.Matches(text, pattern).Count;
             */

            Console.WriteLine("The string \"{0}\" is contained {1} times", pattern, patternCount);           
        }

        public static int CountStringOccurrences(string text, string pattern)
        {
            // Loop through all instances of the string 'text'.
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }

    }
}
