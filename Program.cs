using System;
using System.Collections.Generic;

namespace LargestSibling
{
    internal static class Siblings
    {
        private static void Main()
        {
            GetLargestSibling(123);
        }

        private static void GetLargestSibling(int number)
        {   
            var digits = new List<int>();
            
            for ( ; number != 0; number /= 10)
                digits.Add(number % 10);
            
            for (var num = 0; num < digits.Count; num++)
            {
                for (var sort = 0; sort < digits.Count - 1; sort++)
                {
                    if (digits[sort] >= digits[sort + 1])
                        continue;

                    var temp = digits[sort + 1];
                    digits[sort + 1] = digits[sort];
                    digits[sort] = temp;
                }
            }

            foreach (var t in digits)
                Console.Write(t + "");

            Console.ReadKey();
        }
    }
}
