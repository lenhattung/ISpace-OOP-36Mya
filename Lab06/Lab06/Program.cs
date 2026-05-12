Animal a = new Animal("AnimalX", 5);
a.Display();
a.MakeSound();

Console.WriteLine();

Dog d = new Dog("Rex", 3, "Alaska");
d.Display(); // super class methods
d.dogDisplay(); // sub class methods
d.MakeSound(); // override methods
Console.WriteLine();
Animal d2 = new Dog("Rex", 3, "Alaska");
d2.Display();
//d2.dogDisplay() => error

Console.WriteLine();
Animal b = new Bird("a", 2, "white");
b.Display();
b.MakeSound();