Console.Write("Введиет имя файла: ");
string filename = Console.ReadLine();

if (!File.Exists(filename))
{
    Console.WriteLine($"Файл {filename} создан.");
}
else
{
    Console.WriteLine($"Файл {filename} открыт на дозапись.\n");
}

Console.WriteLine("Для выхода введите end.\nВведите текст: ");
while (true)
{
    string line = Console.ReadLine();
    if (line == "end")
    {
        Console.WriteLine("Запись в файл окончена.");
        break; 
    }
    File.AppendAllText(filename, $"{line}\n");
}
