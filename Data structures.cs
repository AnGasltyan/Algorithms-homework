using System; 
using System.Collections.Generic; 
 
class Program 
{ 
    static void Main() 
    { 
        
        List<int> integerList = new List<int>(); 
        integerList.Add(10); 
        integerList.Add(20); 
        integerList.Add(30); 
        integerList.Add(40); 
        integerList.Add(50); 
 
        Console.WriteLine("List of integers:"); 
        foreach (int num in integerList) 
        { 
            Console.WriteLine(num); 
        } 
 
        
        Dictionary<string, int> stringIntegerDict = new Dictionary<string, int>(); 
        stringIntegerDict.Add("One", 1); 
        stringIntegerDict.Add("Two", 2); 
        stringIntegerDict.Add("Three", 3); 
        stringIntegerDict.Add("Four", 4); 
        stringIntegerDict.Add("Five", 5); 
 
        Console.WriteLine("\nDictionary of string keys and integer values:"); 
        foreach (KeyValuePair<string, int> entry in stringIntegerDict) 
        { 
            Console.WriteLine($"{entry.Key}: {entry.Value}"); 
        } 
 
        
        Queue<int> integerQueue = new Queue<int>(); 
        integerQueue.Enqueue(100); 
        integerQueue.Enqueue(200); 
        integerQueue.Enqueue(300); 
        integerQueue.Enqueue(400); 
        integerQueue.Enqueue(500); 
 
        Console.WriteLine("\nQueue of integers:"); 
        while (integerQueue.Count > 0) 
        { 
            Console.WriteLine(integerQueue.Dequeue()); 
        } 
 
        
        Stack<int> integerStack = new Stack<int>(); 
        integerStack.Push(1000); 
        integerStack.Push(2000); 
        integerStack.Push(3000); 
        integerStack.Push(4000); 
        integerStack.Push(5000); 
 
        Console.WriteLine("\nStack of integers:"); 
        while (integerStack.Count > 0) 
        { 
            Console.WriteLine(integerStack.Pop()); 
        } 
    } 
}
