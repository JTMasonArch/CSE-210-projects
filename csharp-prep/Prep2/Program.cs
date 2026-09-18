using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentResponse = Console.ReadLine();
        int gradePercent = int.Parse(percentResponse);

        string letterGrade;
        string gradeSign;

        if (gradePercent >= 90) {
            letterGrade = "A";

        } else if (gradePercent >= 80) {
            letterGrade = "B";

        } else if (gradePercent >= 70) {
            letterGrade = "C";
            
        } else if (gradePercent >= 60 ) {
            letterGrade = "D";
            
        } else {
            letterGrade = "F";
        }

        if (gradePercent < 97 && gradePercent >= 60) {
            int onesPlace = gradePercent % 10;
            if (onesPlace >= 7) {
                gradeSign = "+";
            } else if (onesPlace < 3)
            {
                gradeSign = "-";
            } else
            {
                gradeSign = "";
            }
        } else
        {
            gradeSign = "";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}{gradeSign}.");
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        } else {
            Console.WriteLine("You have not passed the class. Keep trying though! You can do better next time.");
        };

    }
}