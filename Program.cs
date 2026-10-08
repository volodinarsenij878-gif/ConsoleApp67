using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static bool Foo()
    {
        Console.WriteLine("Foo() вызван!");
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Проверка false && Foo():");
        bool r1 = false && Foo();      // Foo() НЕ вызовется
        Console.WriteLine($"Результат: {r1}\n");

        Console.WriteLine("Проверка false & Foo():");
        bool r2 = false & Foo();       // Foo() ВЫЗОВЕТСЯ
        Console.WriteLine($"Результат: {r2}");
    }
}





