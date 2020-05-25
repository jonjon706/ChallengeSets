using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        { 
            string CollectionContainsWord = "Together we can do so much!";

            if (CollectionContainsWord.Contains("much") == true)
            {
                Console.WriteLine("Word found!");
            }
            else
            {
                Console.WriteLine("Word not found!");
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            if (num == 2)
            {
                return true;
            }
            if (num %2 == 0)
            {
                return false;
            }

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
                if (num % i == 0)
                {
                    return false;
                }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            string st = "Hello";

            int last = st.LastIndexOf('l');
            if (last != - 1)
            {
                Console.WriteLine(st.Substring(last));
            }
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            int previousNumber = numbers[0];
            int firstCount = 1;
            int maxCount = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == previousNumber)
                {
                    firstCount++;
                }
                if(firstCount > maxCount)
                {
                    maxCount = firstCount;
                }
                if (numbers[i] != previousNumber)
                {
                    firstCount = 1;
                }
                previousNumber = numbers[i];
            }
            return maxCount;
        }

        public IEnumerable<double> GetEveryNthElement(List<double> elements, int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException("n");
            if (n > 0)
                for (int c = 0; c < elements.Count; c += n)
                    yield return elements[c];
        }
    }
}
