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
                {5, "V" },
                {10, "X" },
                {50, "L" }
            };

            foreach (var uniqueCharacter in uniqueCharacters.Keys)
            {
                if (arabic == uniqueCharacter)
                    return uniqueCharacters[uniqueCharacter];

                // when one less...

            }

            if (arabic == 2)
                return "II";

            if (arabic == 4)
                return "IV";

            if (arabic == 9)
                return "IX";

            return "";
        }

    }
}