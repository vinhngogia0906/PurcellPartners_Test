using VinhNgo_PurcellPartners_Challenge.Interfaces;
using VinhNgo_PurcellPartners_Challenge.Services;

namespace VinhNgo_PurcellPartners_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            int[] numbers = { 0, 1, 2, 3, 5 }; // Missing number is 4
            IFindMissingNumber findMissingNumberService = new FindMissingNumberService();
            try
            {
                int missingNumber = findMissingNumberService.FindMissingNumber(numbers);
                Console.WriteLine($"The missing number is: {missingNumber}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}