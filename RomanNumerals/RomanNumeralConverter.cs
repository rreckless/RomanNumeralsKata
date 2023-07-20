using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        public Dictionary<int,string> RomanNumerals = new()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 6, "VI" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };
        public string ConvertToRomanNumerals(int arabic)
        {
            /* Task 1

                Write a function that converts an integer (up to a max value of 3,999) into Roman Numerals
    
                I = 1
                V = 5
                X = 10
                L = 50
                C = 100
                D = 500
                M = 1000
                
            Example:
                
                2022 = MMXXII
                3999 = MMMCMXCIX
            
            */

            var roman = string.Empty;
            foreach (int value in RomanNumerals.Keys)
            {
                while (arabic >= value)
                {
                    roman += RomanNumerals[value];
                    arabic -= value;
                }
            }

            return roman;
        }

        public int ConvertFromRomanNumerals(string numeral)
        {
            /* Optional Task 2
               
                Write a function that converts a Roman numeral string back to it's integer value.

            Example:
                
                MMXXI = 2021
                MMMCMXCIX = 3999
             */
            return 0;
        }
    }
}
