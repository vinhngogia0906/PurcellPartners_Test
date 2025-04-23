using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinhNgo_PurcellPartners_Challenge.Interfaces
{
    // Open/Closed Principle: This interface can be implemented by any class that generates a random input number array.
    // Open: The interface is open for extension, meaning
    //      that new classes can implement this interface to provide different implementations of the GenerateRandomArray method.
    // Closed: The interface is closed for modification, meaning
    //      that existing classes that implement this interface do not need to be modified
    public interface INumberArrayGenerator
    {
        // Interface Segregation Principle: This interface is focused on a single responsibility,
        // which is to generate a random input number array.
        public int[] GenerateRandomArray(int size);
    }
}
