using VinhNgo_PurcellPartners_Challenge.Interfaces;
using VinhNgo_PurcellPartners_Challenge.Services;

namespace VinhNgo_PurcellPartners_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            // Dependency Inversion Principle: The main program depends on abstractions (interfaces) rather than concrete implementations

            // Liskov Substitution Principle: FindMissingNumberService can be replaced with any class that implements IFindMissingNumber
            IFindMissingNumber findMissingNumberService = new FindMissingNumberService();
            //  Liskov Substitution Principle: The NumberArrayGenerator class can be replaced with any class that implements INumberArrayGenerator
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