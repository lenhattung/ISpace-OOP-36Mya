using System;
using System.Collections.Generic;
using System.Text;

public class Circle : Shape
{
    private double radius;

    public Circle(string color, double radius) : base(color)
    {
        if (radius <= 0) throw new ArgumentException("Radius must be positive.");
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

}