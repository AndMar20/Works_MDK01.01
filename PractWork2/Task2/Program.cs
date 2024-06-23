using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

internal class Program
{
    private static void Main(string[] args)
    {
        //приложение
        var app = new Excel.Application();
        app.Visible = true;
        var workbook = app.Workbooks.Add(Path.Combine(Environment.CurrentDirectory, "шаблон.xlsx"));

        //путь
        string directoryName = @"E:\ОПБД";
        Console.WriteLine($"Имя папки: {directoryName}");

        //получаем файлы
        var files = GetFiles(directoryName);

        //заполняем првый лист
        var worksheet = workbook.Worksheets[1];
        for (int i = 0; i < files.Length; i++)
        {
            worksheet.Cells[1][i + 2] = i + 1;
            worksheet.Cells[2][i + 2] = files[i].Name;
            worksheet.Cells[3][i + 2] = files[i].Length;
        }
        worksheet.Columns.Autofit();
        Excel.Range range = worksheet.range(worksheet.Cells[1][2], worksheet.Cells[3][files.Length + 1]);
        range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

        //заполняет второй лист
        worksheet = workbook.Worksheets[2];
        var directories = Directory.GetDirectories(directoryName);
        for (int i = 0; i < directories.Length; i++)
        {
            FileInfo directory = new FileInfo(directories[i]);
            worksheet.Cells[1][i + 2] = i + 1;
            worksheet.Cells[2][i + 2] = directory.Name;
        }
        worksheet.Columns.Autofit();
        range = worksheet.range(worksheet.Cells[1][2], worksheet.Cells[2][directories.Length + 1]);
        range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
    }


    public static FileInfo[] GetFiles(string directoryName)
    {
        DirectoryInfo directory = new DirectoryInfo(directoryName);
        return directory.GetFiles("*", SearchOption.AllDirectories);
    }
}