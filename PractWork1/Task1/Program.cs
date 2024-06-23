Console.Write("Введиет имя файла: ");
string filename = Console.ReadLine();
if (File.Exists(filename))
{
    string text = File.ReadAllText(filename);
    Console.WriteLine($"Содержимое файла:\n{text}");
}
else
{
    Console.WriteLine($"Файл {filename} не существует.");
}

//C:\Temp\ISPP-21\PractWork1\file.txt