using System;
using System.Collections.Generic;
using System.Text;

public class Animal
{
    protected string name;
    protected int age;

    public Animal() // default constructor
    {
        this.name = "No Name";
        this.age = 0;
    }

    public Animal(string name,  int age)
    {
        this.name = name;
        this.age=age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound ... ");
    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

}