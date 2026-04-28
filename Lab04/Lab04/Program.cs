using System.Collections;
using System.Collections.Generic;

public class MyClass
{
    public static void Main()
    {
        //ArrayList list = new ArrayList();

        //list.Add(1);
        //list.Add("a");
        //list.Add(3.14);
        //list.Add(true);

        //for(int i=0; i<list.Count; i++)
        //{
        //    Console.WriteLine(list[i]);
        //    //list[i] = fal] = 1;
        //}

        //foreach(object o in list)
        //{
        //    Console.WriteLine(o);
        //}

        ArrayList a = new ArrayList();
        a.Add(9);
        a.Add(8);
        a.Add(10);
        a.Add(50);
        a.Add(10);
        a.Add(99);
        foreach (int i in a)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        a.Sort();
        a.Reverse();
        foreach (int i in a)
        {
            Console.Write(i + " ");
        }

        List<string> l1 = new List<string>();

        List<int> l2 = new List<int>();
    }
}