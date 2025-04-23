using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinhNgo_PurcellPartners_Challenge.Interfaces;

namespace VinhNgo_PurcellPartners_Challenge.Services
{
    // Single Responsibility Principle: This class is responsible for generating a random input number array.
    public class NumberArrayGenerator : INumberArrayGenerator
    {
        public int[] GenerateRandomArray(int size)
        {
            if (size <= 1)
            {
                throw new ArgumentException("Size must be greater than 1", nameof(size));
            }

            Random random = new Random();
            // Create an array of size n + 1 from 0 to n
            int[] array = Enumerable.Range(0, size + 1).ToArray();

            // Shuffle the array with Fisher-Yates shuffle algorithm
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                // Swap elements
                (array[i], array[j]) = (array[j], array[i]);
            }

            // Remove random element
            int missingIndex = random.Next(0, array.Length);
            int[] result = new int[array.Length - 1];

            // Copy all elements except the one at missingIndex
            Array.Copy(array, 0, result, 0, missingIndex);
            Array.Copy(array, missingIndex + 1, result, missingIndex, array.Length - missingIndex - 1);

            return result;
        }
    }
}
