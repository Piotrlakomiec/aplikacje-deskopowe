using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismConsoleApp;

internal class Square : Rectangle
{
    public Square(string name, int a) : base(name, a, a)
    {

    }

    public new void ShowInfo()
    {
        Console.WriteLine($"Obiekt {name}:");
        Console.WriteLine($"Bok a = {sideA}");
        Console.WriteLine($"Obwód = {GetPerimeter()}");
        Console.WriteLine($"Pole = {GetArea()}");
        Console.WriteLine();
    }
}


/*

        ---------------
        |             |
  a     |             |
        |             |
        ---------------
                a


*/