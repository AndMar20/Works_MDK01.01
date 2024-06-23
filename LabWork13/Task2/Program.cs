using System.Text;

string text = "kdsj di    QEQEYQYUQW  fpdsifjpds p        posdf";
Console.WriteLine($"Строка: {text}");
String res = String.Join(" ", text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
Console.WriteLine(res);

Console.WriteLine( );
Console.WriteLine("1. Верхний регистр");
Console.WriteLine("2. Нижний регистр");
Console.WriteLine("3. Инвертированный регистр");
Console.Write("Укажите регистр:");
int choice = int.Parse(Console.ReadLine());

StringBuilder stringBuild = new StringBuilder();
switch (choice)
{
    case 1:
        foreach (char c in text)
            stringBuild.Append(char.ToUpper(c));
        Console.WriteLine(stringBuild);

        break;
    case 2:
        foreach (char c in text)
            stringBuild.Append(char.ToLower(c));
        Console.WriteLine(stringBuild);

        break;
    case 3:
        string invertedCase = string.Empty;
        foreach (var c in text)
            invertedCase += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
        Console.WriteLine(invertedCase);
        break;
}


