using System;

public class Program
{
    public static void Main()
    {
        // Student is a CLASS
        // s1 is an OBJECT
        Console.WriteLine("S1: ");
        Student s1 = new Student();
        s1.Input();
        s1.Display();
        Console.WriteLine("\n\n");

        // s2 is an OBJECT
        Console.WriteLine("S2: ");
        Student s2 = new Student(); // Default Constructor
        s2.Display();
        Console.WriteLine("\n\n");

        // s3 is an OBJECT
        Console.WriteLine("S3: ");
        Student s3 = new Student("S0003", "Nguyen Van A", 2009, "Ho Chi Minh City"); // Parameterized Constructor
        s3.Display();
        Console.WriteLine("\n\n");


    }

}
