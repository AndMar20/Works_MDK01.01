using Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        User user = new();
        Console.Write("Введите логин: ");
        user.Login = Console.ReadLine();
        Console.Write("Введите пароль: ");
        user.Password = Console.ReadLine();
        Console.Write("Подтверждение пароля: ");
        string confirmPassword = Console.ReadLine();

        if (User.IsCorrectUserData(user.Login, user.Password, confirmPassword))
        {
            Console.WriteLine("Регистрация пройдена успешно");
        }
        else
            Console.WriteLine("Не удалось зарегистрироваться");
    }
}