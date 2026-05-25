using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1 - Ввести A");
        Console.WriteLine("2 - Ввести B");
        Console.WriteLine("3 - Выполнить операцию +");
        Console.WriteLine("4 - Выполнить операцию -");
        Console.WriteLine("5 - Выполнить операцию *");
        Console.WriteLine("6 - Выполнить операцию /");
    }
    static double InputA()
    {
        Console.Write("Введите A: ");
        return double.Parse(Console.ReadLine());
    }
    static double InputB()
    {
        Console.Write("Введите B: ");
        return double.Parse(Console.ReadLine());
    }
    static double Add(double a, double b)
    {
        return a + b;
    }
    static double Sub(double a, double b)
    {
        return a - b;
    }
}
