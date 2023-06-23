using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the number of elements to be stored in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Input {0} elements in the array:", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int[] evenArray = GetEvenElements(arr);
        int[] oddArray = GetOddElements(arr);

        Console.WriteLine("The Even elements are:");
        PrintArray(evenArray);

        Console.WriteLine("The Odd elements are:");
        PrintArray(oddArray);
    }

    static int[] GetEvenElements(int[] arr)
    {
        int count = 0;

        foreach (int num in arr)
        {
            if (num % 2 == 0)
                count++;
        }

        int[] evenArray = new int[count];
        int index = 0;

        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                evenArray[index] = num;
                index++;
            }
        }

        return evenArray;
    }

    static int[] GetOddElements(int[] arr)
    {
        int count = 0;

        foreach (int num in arr)
        {
            if (num % 2 != 0)
                count++;
        }

        int[] oddArray = new int[count];
        int index = 0;

        foreach (int num in arr)
        {
            if (num % 2 != 0)
            {
                oddArray[index] = num;
                index++;
            }
        }

        return oddArray;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
