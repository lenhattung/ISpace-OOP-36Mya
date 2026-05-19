List<Shape> shapes = new List<Shape>();

shapes.Add(new Rectangle("red", 3, 4));
shapes.Add(new Circle("blue", 5));
shapes.Add(new Triangle("green", 6, 8));
shapes.Add(new Rectangle("yellow", 2, 10));


double total = 0.0;
foreach (Shape s in shapes)
{
    s.Describe();
    total += s.Area();
}
Console.WriteLine($"\nTotal area = {total:0.00}");
