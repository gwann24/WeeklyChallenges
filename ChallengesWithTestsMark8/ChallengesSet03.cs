using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return (vals.Contains(false));
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                foreach (int number in numbers)
                {
                    sum += number % 2 == 0 ? 0 : number;
                };
            };
            return sum % 2 == 0 ? false : true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;
             foreach (char letter in password.ToCharArray())
            {
                if (letter >= '0' && letter <= '9')
                {
                    hasNumber = true;
                } else if (letter >= 'A' && letter <= 'Z')
                {
                    hasUpper = true;
                } else if (letter >= 'a' && letter <= 'z')
                {
                    hasLower = true;
                };
            };
            return hasUpper && hasLower && hasNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.ToCharArray()[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val.ToCharArray()[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(i);
                };
            };
            return result.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            };
        }
    }
}
