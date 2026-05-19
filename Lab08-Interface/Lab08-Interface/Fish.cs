using System;
using System.Collections.Generic;
using System.Text;

public class Fish : Animal, ISwimmable
{

    public Fish(string name, int age) : base(name, age)
    {
    }
    public void Swim()
    {
        Console.WriteLine($"{name} the fish swims in the water.");
    }
}

