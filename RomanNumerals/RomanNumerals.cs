using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        Dictionary<int, string> _uniqueCharacters = new Dictionary<int, string>
            {
                {1000, "M" },
                {900, "CM" },
                {500, "D" },
                {100, "C" },
                {50, "L" },
                {40, "XL" },
                {10, "X" },
                {9, "IX" },
                {5, "V" },
                {4, "IV" },
                {1, "I" }
            };

        private int _remainder;

        public string ConvertToRomanNumeral(int arabic)
        {
            var romanNumeral = "";

            foreach (var uniqueCharacter in _uniqueCharacters.Keys)
            {
                if (arabic == uniqueCharacter)
                    return _uniqueCharacters[uniqueCharacter];
            }

            _remainder = arabic;

            foreach (var uniqueCharacter in _uniqueCharacters)
            {
                var workingNum = _remainder;

                if (uniqueCharacter.Key <= _remainder)
                {
                    while (workingNum > 0)
                    {
                        workingNum = workingNum - uniqueCharacter.Key;
                        if (workingNum >= 0)
                        {
                            _remainder -= uniqueCharacter.Key;
                            romanNumeral += uniqueCharacter.Value;
                        }
                    }
                }
            }

            return romanNumeral;
        }

    }
}
