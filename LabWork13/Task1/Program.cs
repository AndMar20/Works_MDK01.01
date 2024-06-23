Console.Write("Введите строку: ");
string text = Console.ReadLine();

int spaces = 0;
foreach (char c in text)
{
    if (char.IsWhiteSpace(c))
        spaces++;
}
Console.WriteLine($"Кол-во символов в строке(без пробелов): {text.Length - spaces}");

int letters = 0;
foreach (char c in text)
{
    if (char.IsLetter(c))
        letters++;
}
Console.WriteLine($"Кол-во символов в строке: {letters}");

Console.Write("Введите символ для поиска: ");
char searchChar = Console.ReadKey().KeyChar;
Console.WriteLine();
Console.WriteLine();
for (int i = 0; i < text.Length; i++)
{
    if (text[i] == searchChar)
        Console.WriteLine($"Символ {searchChar} найден на позиции: {i + 1}");
}

if (!text.Contains(searchChar))
    Console.WriteLine("Совпадений не найдено");

