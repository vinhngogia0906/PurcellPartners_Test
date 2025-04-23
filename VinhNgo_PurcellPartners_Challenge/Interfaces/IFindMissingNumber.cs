using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinhNgo_PurcellPartners_Challenge.Interfaces
{
    // Open/Closed Principle: This interface can be implemented by any class that finds a missing number in an array.
    // Open: The interface is open for extension, meaning
    //      that new classes can implement this interface to provide different implementations of the FindMissingNumber method.
    // Closed: The interface is closed for modification, meaning
    //      that existing classes that implement this interface do not need to be modified
    public interface IFindMissingNumber
    {
        // Interface Segregation Principle: This interface is focused on a single responsibility,
        // which is to find the missing number in an array.
        int FindMissingNumber(int[] numbers);
    }
}
