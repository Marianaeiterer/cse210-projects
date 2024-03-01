using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userNumber = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
             Console.Write(" Enter number: ");
             userNumber = int.Parse(Console.ReadLine());
             if(userNumber != 0)
             {
                numbers.Add(userNumber);
             }
             
        }

        int sum = 0;
        int length = numbers.Count;
        int max = 0;
    
        for (int i = 0; i < length; i++)
        {
            sum += numbers[i];
            if(numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        double average = (double)sum/length;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}