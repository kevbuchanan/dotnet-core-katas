using System.Collections.Generic;
using System.Linq;

namespace Katas {
    public class RomanNumerals {
        private static IDictionary<int, string> NUMERALS = new Dictionary<int, string> {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },

        };

        public string Convert(int number) {
            var remaining = number;
            var roman = string.Empty;
            while (remaining > 0) {
                var largest = NUMERALS.Keys.Where(k => k <= remaining).Last();
                remaining = remaining - largest; 
                roman +=  NUMERALS[largest];
            }
            return roman;
        }
    }
}