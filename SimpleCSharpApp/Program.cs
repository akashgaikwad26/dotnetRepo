using System;

class Program
{
    static void Main(string[] args)
    {
        MathOperations mathOps = new MathOperations();
        int sum = mathOps.Add(5, 3);
        int difference = mathOps.Subtract(10, 4);
        
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
    }
}
