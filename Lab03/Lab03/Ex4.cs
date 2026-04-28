using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    internal class Ex4
    {
        public static void Main1()
        {
            // ++ => increase 1
            // -- => descrese 1
            // a++ => a = a+1;
            // a-- => a = a-1;
            //int a = 5;
            //Console.WriteLine(a++); //5 => print 5 => increase 6
            //Console.WriteLine(++a); //6 => incease 7 => print 7
            //Console.WriteLine(a++); //6 => print 7 => increase 8
            //Console.WriteLine(a--); //6 => print 8 => descrase 7
            //Console.WriteLine(--a); //5 => descrase 6 => print 6

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
