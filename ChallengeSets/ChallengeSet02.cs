using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public static bool CharacterIsALetter(char c)

        {
            if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
     
      
        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                {
                return true;
                }
            else
            {
                return false;
            }

        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double sum = 0;
            int count = 0;

            double min = double.MaxValue;
            double max = double.MinValue;
            double number;

            while ((number = Enter()) != 0 )
            {
                sum += number;

                ++count;

                if (min > number)
                {
                    min = number;
                }
                if (max < number)
                {
                    max = number;
                }

            }
        }

        private double Enter()
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {

            if (str1.Length != str2.Length)
            {
                throw new Exception("Strings are not equal");
            }

            int distance =
                str1.ToCharArray()
                .Zip(str2.ToCharArray(), (c1, c2) => new { c1, c2 })
                .Count(m => m.c1 != m.c2);

            return distance;

        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1; i <= 6; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                   sum = sum + numbers[i];
                }
            }
            return sum;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;

            if (number == 1 || number <= 0)
            {
                return 0;
            }

            for (long i = number; i > 0; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
