using System;
using System.Collections.Generic;
using System.Text;
public class Bird : Animal, IFlyable
{

    public Bird(string name, int age) : base(name, age)
    {
        this.color = color;
    }


    public void Fly()
    {
        Console.WriteLine($"{name} the bird flaps its wings and flies.");
    }
}
