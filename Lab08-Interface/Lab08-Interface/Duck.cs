using System;
using System.Collections.Generic;
using System.Text;

public class Duck : Animal, ISwimmable, IFlyable
{

    public Duck(string name, int age) : base(name, age)
    {
    }
    public void Fly()
    {
        Console.WriteLine($"{name} the duck flies awkwardly.");
    }

    public void Swim()
    {
        Console.WriteLine($"{name} the duck paddles on the lake.");
    }
}

