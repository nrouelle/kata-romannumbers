using System;
using System.Collections.Generic;
using System.Text;

namespace romannumbers
{
    public class Converter : IConverter
    {
        public Dictionary<int, string> values = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 500, "D" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };
        public string ConvertToRoman(int number)
        {
            if (number < 1)
                throw new ArgumentOutOfRangeException();

            var roman = new StringBuilder();

            foreach (var item in values)
            {
                while (number >= item.Key)
                {
                    roman.Append(item.Value);
                    number -= item.Key;
                }
            }
            
            return roman.ToString();
        }
    }
}