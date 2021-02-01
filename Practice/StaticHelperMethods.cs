using System;

namespace Practice
{
    public static class StaticHelperMethods
    {
        public static bool IsStringPalindrome(string givenString)
        {
            if (string.IsNullOrWhiteSpace(givenString))
            {
                return true;
            }
            var charArray = givenString.ToCharArray();
            Array.Reverse(charArray);

            string reverseString = new String(charArray);

            if (reverseString.ToLower() == givenString.ToLower())
            {
                return true;
            }

            return false;
        }

        public static bool IsAbcPythagoreanAndSums1000(uint[] abc)
        {
            if (abc.Length != 3)
            {
                throw new InvalidOperationException("This should not be generic, still though why feed in either less" +
                    "or more than 3 numbers?");
            }

            uint a = abc[0];
            uint b = abc[1];
            uint c = abc[2];

            if (a + b + c != 1000)
            {
                return false;
            }

            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                return true;
            }

            return false;
        }
    }
}
