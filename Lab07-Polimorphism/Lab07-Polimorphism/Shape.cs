using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

public class Shape
{
    private string color;

    public string Color
    {
        get => color;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Color cannot be empty");
            color = value;
        }
    }
    public Shape(string color)
    {
        Color = color;
    }

    public virtual double Area()
    {
        return 0.0;
    }

    public void Describe()
    {
        Console.WriteLine($"A {Color} shape with area {Area():0.00}");
    }

}