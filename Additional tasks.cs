using System; 
using System.Linq; 
 
class Program 
{ 
    static void Main() 
    { 
        List<int> integerList = new List<int> { 10, 20, 30, 40, 50 }; 
 
        Console.WriteLine("Elements in the list:"); 
        foreach (int num in integerList) 
        { 
            Console.WriteLine(num); 
        } 
 
        int threeDigitNumber = 124; 
        int largestDigit = threeDigitNumber.ToString().Max(c => int.Parse(c.ToString())); 
        Console.WriteLine($"\nLargest digit in {threeDigitNumber}: {largestDigit}"); 
 
        int smallestDigit = threeDigitNumber.ToString().Min(c => int.Parse(c.ToString())); 
        Console.WriteLine($"Smallest digit in {threeDigitNumber}: {smallestDigit}"); 
 
        int[] integerArray = { 11, 22, 33, 44, 55, 66 }; 
        int evenSum = integerArray.Where(n => n % 2 == 0).Sum(); 
        Console.WriteLine("\nSum of even values in the array: " + evenSum); 
 
        double average = integerArray.Average(); 
        Console.WriteLine("Average of all elements in the array: " + average); 
    } 
}
