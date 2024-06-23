string directoryName = @"C:\Temp\ISPP-21\МДК.01.01";
Console.WriteLine($"Имя папки: {directoryName}");

DirectoryInfo directory = new DirectoryInfo(directoryName);
var files = directory.GetFiles();

foreach (var file in files)
{
    string newDirectoryName = Path.Combine(directoryName,
        file.CreationTime.Year.ToString(),
        file.CreationTime.Month.ToString(),
        file.CreationTime.Day.ToString());
    Console.WriteLine(newDirectoryName);
    if (!Directory.Exists(newDirectoryName))
    {
        Directory.CreateDirectory(newDirectoryName);
        file.MoveTo(newDirectoryName);
        return;
    }
    Directory.Move(file.FullName, newDirectoryName);


}


//C:\Temp\ISPP-21\PractWork1