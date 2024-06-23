using System.Text.RegularExpressions;

Console.Write("Введите пароль: ");
string input = Console.ReadLine();
string pattern = @"^(?=.+[a-zA-Z])(?=.+[0-9])(?=.+[?!.]).{6,}$";

Regex regex = new(pattern);
while (!regex.IsMatch(input))
{
    Console.WriteLine("\nТребования к паролю не выполнены.");
    Console.WriteLine("ТРЕБОВАНИЯ \n1)длина пароля от 6 символов\n2)обязательна цифра\n3)строчная и прописная латинская буква\n4)знак препинания (.?!))");
    Console.Write("Введите пароль: ");
    input = Console.ReadLine();
}
Console.WriteLine("Пароль введён корректно");
