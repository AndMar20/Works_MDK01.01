using System.Drawing;
using Task;

Pet pet1 = new("Рудольф", "Енот", 7);
Pet pet2 = new("Петя", "Медведь", 4);
Ellipse ellipse1 = new("Круг", 7);
Ellipse ellipse2 = new("Круг", 3);

#region Task1
Console.WriteLine("===============Task1===============");

pet1.Print();
#endregion

#region Task3
Console.WriteLine("===============Task3===============");

ellipse1.GetFigureInfo();
Console.WriteLine();

ellipse1.GetSquare();
Console.WriteLine();

ellipse1.GetPerimetr();
#endregion

#region Task4
Console.WriteLine("===============Task4===============");

Console.WriteLine("Информация о животном");
IPrinter printer1 = pet1;
printer1.Print();

Console.WriteLine("Информация о фигуре");
IPrinter printer2 = ellipse1;
printer2.Print();

Console.WriteLine("Массив\n");
IPrinter[] printers = [pet1, pet2, ellipse1, ellipse2];
foreach (IPrinter printer in printers)
{
   
    printer.Print();
    if (printer is IFigure figure)
        Console.WriteLine($"{ figure.Name} \n");
}

#endregion

