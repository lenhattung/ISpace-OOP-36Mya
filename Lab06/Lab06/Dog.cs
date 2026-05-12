using System;
using System.Collections.Generic;
using System.Text;

public class Dog : Animal
{
    private string dogBreed;

    public Dog() : base()
    {
        this.dogBreed = "N/A";
    }

    public Dog(string name, int age, string dogBreed) : base(name, age)
    {
        this.dogBreed = dogBreed;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }

    public void dogDisplay()
    {
        Console.WriteLine($"dogBreed: {dogBreed}");
    }

}