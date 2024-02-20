using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Count() % 2 == 0 ? true : false);
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0 ? true : false);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 == 0 ? false : true);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return (numbers == null ? 0 : (numbers.Count() > 0 ? numbers.Min() + numbers.Max() : 0));
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length > str2.Length ? str2.Length : str1.Length);
        }

        public int Sum(int[] numbers)
        {
            return (numbers != null ? numbers.Sum() : 0);
        }

        public int SumEvens(int[] numbers)
        {
            int evenSum = 0;
            if (numbers != null)
            {
                foreach (int number in numbers)
                {
                    evenSum += number % 2 == 0 ? number : 0;
                }
            }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers == null ? false : (numbers.Sum() % 2 == 0 ? false : true));
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //long pCount = 0;
            //if (number > 0)
            //{
            //    for (long x=1; x < number; x++)
            //    {
            //        if (x % 2 != 0)
            //        {
            //            pCount++;
            //        }
            //    }
            //}
            //return pCount;
            return (number > 0 ? number/2 : 0);
        }
    }
}
