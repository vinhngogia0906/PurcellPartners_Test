using VinhNgo_PurcellPartners_Challenge.Interfaces;
using VinhNgo_PurcellPartners_Challenge.Services;

namespace VinhNgo_PurcellPartners_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            IFindMissingNumber findMissingNumberService = new FindMissingNumberService();
            INumberArrayGenerator numberArrayGenerator = new NumberArrayGenerator();
            try
            {
                // Generate a random array of numbers
                Random random = new Random();
                int size = random.Next(5, 15); // Random size between 5 and 20
                int[] numbers = numberArrayGenerator.GenerateRandomArray(size);
                int missingNumber = findMissingNumberService.FindMissingNumber(numbers);
                // Output the generated array and the missing number
                Console.WriteLine("Generated array: [" + string.Join(", ", numbers)+"]");
                Console.WriteLine($"The missing number is: {missingNumber}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}