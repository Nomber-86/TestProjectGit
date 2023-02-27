using System;

public class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        LinkedList<int> numbers = new LinkedList<int>();
        for (int i = 0; i < n; i++)
        {
            numbers.AddLast(Convert.ToInt32(Console.ReadLine()));
        }

        var array1 = numbers.Where(number => number % 2 == 0)
            .Select(number => number * 2);
        
        Console.WriteLine(string.Join(" " , array1));

    }
}