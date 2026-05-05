using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml.Linq;

public class StudentV2
{
    private string studentId; // HIDE THE FIELD.
    private string name;
    private int birthYear;
    private string address;

    // EXPOSE A CONTROLLED GATE.
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }
    }

    public string StudentId
    {
        get; set;
    }

    public int BirthYear
    {
        get
        {
            return birthYear;
        }
        set
        {
            if (value>=1900 && value <= DateTime.Now.Year)
            {
                birthYear = value;
            }
        }
    }

    public string Address
    {
        get
        {
            return address;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                address = value;
            }
        }
    }

    // Default constructor
    public StudentV2()
    {
        StudentId = "00000";
        Name = "Unknown";
        BirthYear = 2010;
        Address = "N/A";
    }

    // Parameterized Constructor
    public StudentV2(string studentId, string name, int birthYear, string address)
    {
        StudentId = studentId;
        Name = name;
        BirthYear = birthYear;
        Address = address;
    }

    public StudentV2(string studentId, string name, int birthYear)
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