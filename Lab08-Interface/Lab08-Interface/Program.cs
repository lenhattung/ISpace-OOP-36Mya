// A list of things that CAN-DO Fly. 
// A Bird and a Duck can go here. A Fish cannot.
List<IFlyable> flyingThings = new List<IFlyable>
        {
            new Bird("Tweety" , 2),
            new Duck("Donald", 3)
        };

// A list of things that CAN-DO Swim.
List<ISwimmable> swimmingThings = new List<ISwimmable>
        {
            new Fish("Nemo", 4),
            new Duck("Donald", 5) // The same Duck object can be in BOTH lists!
        };

Console.WriteLine("--- Flying Show ---");
foreach (IFlyable f in flyingThings)
{
    f.Fly(); // Polymorphism via interface!
}

Console.WriteLine("\n--- Swimming Show ---");
foreach (ISwimmable s in swimmingThings)
{
    s.Swim(); // Polymorphism via interface!
}


IFlyable ia = new Duck("Donald", 5);
ia.Fly();  // can not call ia.swim();


ISwimmable ib = new Duck("Donald", 5);
ib.Swim();  // can not call ia.fly();

Duck d = new Duck("Donald", 5);
d.Fly();
d.Swim();
d.MakeSound();


