
using PolymorphismConsoleApp;

Rectangle rectangle = new Rectangle("Prostokąt", 15, 4);
rectangle.ShowInfo();

Trapeze trapeze = new("Trapez", 1, 2, 3, 4, 5);
trapeze.ShowInfo();

Square square = new("Kwadrat", 15);
square.ShowInfo();

//Quadrangle q = new Quadrangle("dsf", 1,2,3,4,5);
//Console.WriteLine(q.GetArea());

//Test1(rectangle);
//Test2(trapeze);

Test3(rectangle);
Test3(trapeze);
Test3(square);

//void Test1(Rectangle r)
//{
//    Console.WriteLine($"Obwód: {r.GetPerimeter()}");
//    Console.WriteLine($"Pole: {r.GetArea()}");
//}

//void Test2(Trapeze t)
//{
//    Console.WriteLine($"Obwód: {t.GetPerimeter()}");
//    Console.WriteLine($"Pole: {t.GetArea()}");
//}

void Test3(Quadrangle q)
{
    Console.WriteLine($"Obwód: {q.GetPerimeter()}");
    Console.WriteLine($"Pole: {q.GetArea()}");
}


/*

KISS
DRY
YAGNI
SOLID
*/