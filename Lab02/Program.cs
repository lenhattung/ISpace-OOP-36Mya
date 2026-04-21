public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");

        // LAB -02
        // Value type — each variable has its own copy
        int a = 10;
        int b = a;    // b is a separate copy
        b = 20;
        Console.WriteLine($"a = {a}, b = {b}");   // a = 10, b = 20

        // Reference type — both variables refer to the same array
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;   // arr2 references the same array
        arr2[0] = 99;
        Console.WriteLine(arr1[0]);   // 99


        int age = 20;
        long population = 8_000_000_000L;      // suffix L for long
        float pi = 3.14f;                      // suffix f for float
        double e = 2.71828;
        decimal salary = 15_000_000.50m;       // suffix m for decimal — best for money

        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"population: {population}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine(e.ToString("F2"));

        char letter = 'A';              // single quotes, exactly one character
        char newLine = '\n';            // escape sequence

        string name = "Nguyen Van A";  // double quotes
        string empty = string.Empty;    // same as ""
        string path = @"C:\Users\Data"; // verbatim string (no escape)

        // Common string methods
        Console.WriteLine(name.Length);          // 12
        Console.WriteLine(name.ToUpper());       // NGUYEN VAN A
        Console.WriteLine(name.Substring(0, 6)); // Nguyen
        Console.WriteLine(name.Replace("A", "B"));
        Console.WriteLine(name.Contains("Van")); // True

        bool isPassed = true;
        bool isEmpty = false;
        bool result = (10 > 5) && (20 < 30);   // true

        var count = 10;            // inferred as int
        var price = 19.99;         // inferred as double
        var name1 = "Claude";      // inferred as string


        int? a1 = null;

        int? age1 = null;
        age1 = 25;

        if (age1.HasValue)
            Console.WriteLine($"Age = {age1.Value}");
        else
            Console.WriteLine("Age is unknown");

        // Null-coalescing operator
        int actualAge = age1 ?? 0;   // if null, use 0


        int v1 = 5;
        int v2 = 2;
        Console.WriteLine($"{v1} / {v2} = {(double)v1/v2}");


        string input = "1";
        int n = int.Parse(input);    // throws FormatException if invalid

        // Safer approach — preferred for user input
        if (int.TryParse(input, out int value))
        {
            Console.WriteLine($"Parsed: {value}");
        }
        else
        {
            Console.WriteLine("Invalid number");
        }


        DateTime now = DateTime.Now;

        Console.WriteLine($"{now}");                         // default format
        Console.WriteLine($"{now:yyyy-MM-dd}");              // 2026-04-20
        Console.WriteLine($"{now:dd/MM/yyyy HH:mm:ss}");    // 20/04/2026 14:30:45
        Console.WriteLine($"{now:dddd, MMMM dd, yyyy}");    // Monday, April 20, 2026
        Console.WriteLine($"{now:t}");                       // short time
        Console.WriteLine($"{now:D}");                       // long date

    }

}