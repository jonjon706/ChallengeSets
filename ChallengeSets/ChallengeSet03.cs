using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool val = false;
            if(val == false)
            {
                return true;
            }
            else
            {
                return false;
            }
            
  
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            
            if(numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            string s = "some-password";
            int upcaseCount = 0;
            int numbersCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i])) upcaseCount++;
                if (char.IsDigit(s[i])) numbersCount++;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {

            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend % divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }
        public int[] GetOddsBelow100()
        {
            var numbers = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
        
            {
                numbers.Add(i);
            }
        }
            return numbers.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
