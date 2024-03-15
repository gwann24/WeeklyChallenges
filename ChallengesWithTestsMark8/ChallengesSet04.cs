using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                } else
                {
                    result -= number;
                };
            };
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortest = str1.Length;
            if (str2.Length < shortest)
            {
                shortest = str2.Length;
            };
            if (str3.Length < shortest)
            {
                shortest = str3.Length;
            };
            if (str4.Length < shortest)
            {
                shortest = str4.Length;
            };
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallNbr = number1;
            if (number2 < smallNbr)
            {
                smallNbr = number2;
            };
            if (number3 < smallNbr)
            {
                smallNbr = number3;
            };
            if (number4 < smallNbr)
            {
                smallNbr = number4;
            };
            return smallNbr;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool formTriangle = true;
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                formTriangle = false;
            } else if ((sideLength1 + sideLength2) <= sideLength3 || (sideLength1 + sideLength3) <= sideLength2 || (sideLength2 + sideLength3) <= sideLength1)
            {
                formTriangle = false;
            };
            return formTriangle;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            bool result = false;
            int nullCount = 0;
            //for (int x = 0; x < objs.Length; x++)
            //{
            //    if (objs[x] == null)
            //    {
            //        nullCount++;
            //    };
            //};
            nullCount = objs.Where(x => x == null).Count();
            if (nullCount > objs.Length/2)
            {
                result = true;
            };
            return result;
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            try
            {
                sum = numbers.Where(number => (number % 2 == 0)).Average();
            }
            catch (Exception e)
            {

            };
            return sum;
        }

        public int Factorial(int number)
        {
            int result = number;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            } else if (number == 0)
            {
                result = 1;
            } else
            {
                for (int f = 1; f < number; f++)
                {
                    result *= f;
                };
            };
            return result;
        }
    }
}
