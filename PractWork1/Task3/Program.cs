Console.Write("Введите имя файла: ");
string filename = Console.ReadLine();
if (!File.Exists(filename))
{
    Console.WriteLine($"Файл {filename} не существует.");
    return;
}

Console.Write("Введите текст для поиска: ");
string searchText = Console.ReadLine();

var lines = File.ReadAllLines(filename);

for (int i = 0; i < lines.Length; i++)
{
    if (lines[i].Contains(searchText))
    {
        Console.WriteLine($"{i + 1}) {lines[i]}");
    }
}
//C:\Temp\ISPP-21\PractWork1\file.txt