using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        internal String Convert(int arabic)
        {
            Dictionary<int, string> uniqueCharacters = new Dictionary<int, string>
            {
                {1, "I" },
                {4, "IV" },
                {5, "V" },
                {9, "IX" },
                {10, "X" },
                {50, "L" },
                {100, "C" },
                {500, "D" },
                {1000, "M" }
            };

            foreach (var uniqueCharacter in uniqueCharacters.Keys)
            {
                if (arabic == uniqueCharacter)
                    return uniqueCharacters[uniqueCharacter];

                // when one less...

            }

            if (arabic == 2)
                return "II";

            return "";
        }

    }
}