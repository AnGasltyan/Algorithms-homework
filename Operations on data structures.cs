using System; 
using System.Collections.Generic; 
 
class Program 
{ 
    static void Main() 
    { 
        List<int> integerList = new List<int> { 10, 20, 30, 40, 50 }; 
 
        int sumList = 0; 
        foreach (int num in integerList) 
        { 
            sumList += num; 
        } 
        Console.WriteLine("Sum of all elements in the list: " + sumList); 
 
        Dictionary<string, int> stringIntegerDict = new Dictionary<string, int> 
        { 
            { "One", 1 }, 
            { "Two", 2 }, 
            { "Three", 3 }, 
            { "Four", 4 }, 
            { "Five", 5 } 
        }; 
 
        int sumDict = 0; 
        foreach (KeyValuePair<string, int> entry in stringIntegerDict) 
        { 
            sumDict += entry.Value; 
        } 
        Console.WriteLine("Sum of all values in the dictionary: " + sumDict); 
 
        Queue<int> integerQueue = new Queue<int>(); 
        integerQueue.Enqueue(100); 
        integerQueue.Enqueue(200); 
        integerQueue.Enqueue(300); 
        integerQueue.Enqueue(400); 
        integerQueue.Enqueue(500); 
 
        integerQueue.Dequeue(); 
        integerQueue.Dequeue(); 
 
        Console.WriteLine("\nRemaining elements in the queue:"); 
        foreach (int num in integerQueue) 
        { 
            Console.WriteLine(num); 
        } 
 
        Stack<int> integerStack = new Stack<int>(); 
        integerStack.Push(1000); 
        integerStack.Push(2000); 
        integerStack.Push(3000); 
        integerStack.Push(4000); 
        integerStack.Push(5000); 
 
        integerStack.Pop(); 
        integerStack.Pop(); 
 
        Console.WriteLine("\nRemaining elements in the stack:"); 
        foreach (int num in integerStack) 
        { 
            Console.WriteLine(num); 
        } 
    } 
}
