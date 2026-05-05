using System;

public class Program
{
    public static void Main()
    {
        /*
        // Student is a CLASS
        // s1 is an OBJECT
        Console.WriteLine("S1: ");
        Student s1 = new Student();
       // s1.Input();
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

        // Encapsulation
        s3.Address = "Thu Duc City";
        s3.BirthYear = -500; // 
        s3.BirthYear = 9999; //
        s3.Display();

        */

        StudentV2 student = new StudentV2();
        Console.WriteLine(student.Name); // => call get
        student.Name = "ABC"; // call => set
        student.Display(); // => ABC 
        Console.WriteLine("\n\n");

        student.Name = ""; // call => set
        student.Display(); // => "" 

        Console.WriteLine("\n\n");
        student.Name = "LE NHAT TUNG"; // call => set
        student.BirthYear = 2004;
        student.Display(); // => birthYear = 2004

        Console.WriteLine("\n\n");
        student.BirthYear = 2020;
        student.Display(); // => birthYear = 2020

    }

}
