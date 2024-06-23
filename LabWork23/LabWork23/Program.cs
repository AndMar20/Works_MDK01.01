using LabWorkLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        double a = 10;
        double b = 5;
        
        Console.WriteLine($"Константа: {Maths.BINARY_FACTORY}");
        Console.WriteLine($"Сумма: {Maths.GetSumm(a, b)}");
        Console.WriteLine($"Разность: {Maths.GetDifference(a, b)}");
        Console.WriteLine($"Произведение: {Maths.GetMultiply(a, b)}");
        Console.WriteLine($"Частное: {Maths.GetDivide(a, b)}");
        Console.WriteLine($"Площадь прямоугольника: {Maths.GetRectangleSquare(a, b)}");
        Console.WriteLine($"Модуль числа: {Maths.GetAbs(a) }");

        
    }
}