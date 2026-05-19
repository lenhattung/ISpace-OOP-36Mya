using System;
using System.Collections.Generic;
using System.Text;

public class Triangle : Shape
{
    private double baseLen;
    private double height;

    public Triangle(string color, double baseLen, double height) : base(color)
    {
        if (baseLen <= 0) throw new ArgumentException("Base must be positive.");
        if (height <= 0) throw new ArgumentException("Height must be positive.");
        this.baseLen = baseLen;
        this.height = height;
    }

    public override double Area()
    {
        return 0.5 * baseLen * height;
    }

}