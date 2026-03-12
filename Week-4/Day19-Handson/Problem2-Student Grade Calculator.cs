using System;
class Student
{
    public double CalculateAverage(int m1, int m2, int m3)
    {
        double  average = (m1 + m2 + m3) /3.0;
        return average;

    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        Console.WriteLine("Enter Marks for Subject 1: ");
        int m1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Marks for Subject 2 :");
        int m2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Marks for Subject 3 : ");
        int m3 = int.Parse(Console.ReadLine());
        char grade;
        double average = s.CalculateAverage(m1, m2, m3);

        if (average >= 80)
        {
            grade='A';
        }
        else if (average >= 70)
        {
            grade = 'B'; 
        }
        else if (average >= 60)
        {
            grade = 'C';
        }
        else if (average >= 50)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }
        Console.WriteLine("Average = " + average);
        Console.WriteLine("Grade = " + grade);
    }
}
