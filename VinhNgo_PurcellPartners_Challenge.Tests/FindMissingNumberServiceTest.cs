using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinhNgo_PurcellPartners_Challenge.Interfaces;
using VinhNgo_PurcellPartners_Challenge.Services;
using VinhNgo_PurcellPartners_Challenge.Utils;

namespace VinhNgo_PurcellPartners_Challenge.Tests
{
    public class FindMissingNumberServiceTest
    {
        private readonly IFindMissingNumber _findMissingNumberService;
        public FindMissingNumberServiceTest()
        {
            _findMissingNumberService = new FindMissingNumberService();
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 2, 3, 5 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 0)]
        [InlineData(new int[] { 0, 1, 2, 4, 5 }, 3)]
        [InlineData(new int[] { 0, 2, 3, 4, 5 }, 1)]
        [InlineData(new int[] { 0, 1, 2, 3, 4, 5 }, 6)]
        [InlineData(new int[] { 0, 1, 2, 3, 4 }, 5)]
        public void FindMissingNumber_ValidInput_ReturnsCorrectMissingNumber(int[] numbers, int expected)
        {
            // Act
            int result = _findMissingNumberService.FindMissingNumber(numbers);
            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[] { })]
        public void FindMissingNumber_EmptyOrNullInput_ThrowsInvalidInputException(int[] numbers)
        {
            // Act & Assert
            Assert.Throws<InvalidInputException>(() => _findMissingNumberService.FindMissingNumber(numbers));
        }

        [Theory]
        [InlineData(new int[] { -1, 0, 1, 2, 3 })]
        [InlineData(new int[] { 0, 1, 2, -3, 5, 6 })]
        public void FindMissingNumber_InvalidInput_ThrowsInvalidInputException(int[] numbers)
        {
            // Act & Assert
            Assert.Throws<InvalidInputException>(() => _findMissingNumberService.FindMissingNumber(numbers));
        }
    }
}
