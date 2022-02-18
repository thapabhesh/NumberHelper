using System;
using System.Collections.Generic;

namespace NumberHelper
{
    public class NumberHelper
    {
        public static int[] Digits(int number)
        {
            number = Math.Abs(number);

            if (number < 10)
                return new[] { number };

            var remainder = number % 10;

            var result = new List<int>();
            result.AddRange(Digits(number / 10));
            result.Add(remainder);

            return result.ToArray();
        }

        public static object Reverse(int number)
        {
            var reverse = 0;

            var multiplier = number < 0 ? -1 : 1;
            number = Math.Abs(number);

            while (number > 0)
            {
                var remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }

            return reverse * multiplier;
        }
    }
}
