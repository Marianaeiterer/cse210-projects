using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string userGradePercentage = Console.ReadLine();
        int grade = int.Parse(userGradePercentage);

        string letter = "";

        if(grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if(grade >= 70)
        {
            letter = "C";
        }
        else if(grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if(grade >= 70){
            Console.WriteLine("Congratulations! You passed the class!");
        }else{
            Console.WriteLine("I'm sorry! You will pass next time!");
        }

    }
}