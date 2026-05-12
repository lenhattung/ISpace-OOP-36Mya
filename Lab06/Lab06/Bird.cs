using System;
using System.Collections.Generic;
using System.Text;

public class Bird : Animal{
    private string color;

    public Bird() : base()
    {
        this.color = "N/A";
    }

    public Bird(string name, int age, string color) : base(name, age)
    {
        this.color = color;
    }

    public override void MakeSound()
    {
        Console.WriteLine("chirp! chirp!");
    }

}