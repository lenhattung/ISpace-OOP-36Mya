using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml.Linq;

public class Student
{
    private string StudentId; // HIDE THE FIELD.
    private string Name;
    private int BirthYear;
    private string Address;

    // Default constructor
    public Student()
    {
        StudentId = "00000";
        Name = "Unknown";
        BirthYear = 2010;
        Address = "N/A";
    }

    // Parameterized Constructor
    public Student(string studentId, string name, int birthYear, string address)
    {
        StudentId =studentId;
        Name =name;
        BirthYear=birthYear;
        Address =address;
    }

    public Student(string studentId, string name, int birthYear)
    {
        StudentId = studentId;
        Name = name;
        BirthYear = birthYear;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Birth year: {BirthYear}");
        Console.WriteLine($"Address: {Address}");
    }

    public void Input()
    {
        Console.Write("Enter Student Id: ");
        StudentId = Console.ReadLine();
        Console.Write("Enter Student Name: ");
        Name = Console.ReadLine();
        Console.Write("Enter Birth Year: ");
        BirthYear = int.Parse(Console.ReadLine());
        Console.Write("Enter Address: ");
        Address = Console.ReadLine();
    }

}