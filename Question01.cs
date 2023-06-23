using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(5.0.GetType());        // System.Double
        Console.WriteLine((5 > 1).GetType());    // System.Boolean
        Console.WriteLine('5'.GetType());        // System.Char
        Console.WriteLine((5 * 2).GetType());    // System.Int32
        Console.WriteLine(('5' * 2).GetType());  // System.Int32 (implicit conversion from char to int)
        Console.WriteLine(('5' + '2').GetType());// System.Int32 (implicit conversion from char to int)
        Console.WriteLine((5 / 2).GetType());    // System.Int32
        Console.WriteLine((5 % 2).GetType());    // System.Int32
        Console.WriteLine(new int[] { 5, 2, 1 }.GetType()); // System.Int32[]
        Console.WriteLine((5 == 3).GetType());   // System.Boolean
        Console.WriteLine(Math.PI.GetType());    // System.Double
    }
}
