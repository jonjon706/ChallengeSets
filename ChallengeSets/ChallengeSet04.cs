using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int i = 0;

            for (int i = 0; i < 9; i++)
            {
                if (num[] % 2 == 0)
                {
                   return i = i + num[i];
                }
                else
                {
                    return i = i - num[i];
                }
            }

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (str1.Length != str2.Length || str3.Length != str4.Length)
            {
                throw new Exception("Strings are not equal");
            }

            int distance =
                str1.ToCharArray()
                .Zip(str2.ToCharArray(), (c1, c2) => new { c1, c2 })
                .Count(m => m.c1 != m.c2);

            return distance;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 < number2 || number1 < number3 || number1 < number4)
            {
                return number1;
            }
            else if (number2 < number1 || number2 < number3 || number2 < number4)
            {
                return number2;
            }
            else if (number3 < number1 || number3 < number2 || number3 < number4)
            {
                return number3;
            }
            else
            {
                return number4;
            }

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            string name = "TrueCoders";
            {
                name = biz.Name;
            }
            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 == sideLength2 && sideLength3 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            int[] intput = { 1, 2, 3, 4, 5, 6, 7 };

            string num = new string(input);
            string x = 0;

            if (x == num.All());
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            int[] num = { 23, 22, 44, 23, 54 };

            double average = numbers.Average();

            if (average % 2 == 0)
            {
                return average;
            }
            else
            {
                return null;
            }
        }

        public int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
