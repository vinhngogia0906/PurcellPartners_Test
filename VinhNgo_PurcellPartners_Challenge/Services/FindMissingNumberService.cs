using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinhNgo_PurcellPartners_Challenge.Interfaces;
using VinhNgo_PurcellPartners_Challenge.Utils;

namespace VinhNgo_PurcellPartners_Challenge.Services
{
    public class FindMissingNumberService : IFindMissingNumber
    {
        public int FindMissingNumber(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                throw new InvalidInputException("Input array cannot be null or empty.");
            }

            int fullSum = numbers.Length * (numbers.Length + 1) / 2; // Total sum of numbers from 0 to n
            int currentSum = 0;

            foreach (int number in numbers)
            {
                if(number < 0 || number > numbers.Length) // Include numbers.Length because the array is missing one number
                {
                    throw new InvalidInputException("Numbers must be in the range of 0 to n.");
                }
                currentSum += number; // Sum of the given numbers
            }
            // The difference between the total sum and the current sum will give us the missing number
            return fullSum - currentSum;
        }
    }
}
