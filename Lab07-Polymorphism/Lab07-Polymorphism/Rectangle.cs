using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(string color, double width, double height) : base(color)
    {
        if (width <= 0) throw new ArgumentException("Width must be positive.");
        if (height <= 0) throw new ArgumentException("Height must be positive.");
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }
}

