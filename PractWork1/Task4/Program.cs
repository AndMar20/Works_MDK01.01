Console.Write("Введите имя папки: ");
string directoryName = Console.ReadLine();
if (!Directory.Exists(directoryName))
{
    Console.WriteLine($"Папки {directoryName} не существует.");
    return;
}

Console.Write("Введите имя файла: ");
string fileName = Console.ReadLine();
var files = Directory.GetFiles(directoryName, $"*{fileName}*", SearchOption.AllDirectories);
foreach (var file in files)
{
    Console.WriteLine($"Полное имя файла: {file}\nРазмер файла: {file.Length} Б");
}
//C:\Temp\ISPP-21\PractWork1