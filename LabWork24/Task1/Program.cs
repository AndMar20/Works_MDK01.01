internal class Program
{
    private static string _login;
    private static string _password;

    private static void Main(string[] args)
    {
        Console.Write("Введите логин: ");
        string login = Console.ReadLine();
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();
        Console.Write("Подтверждение пароля: ");
        string confirmPassword = Console.ReadLine();

        if (IsCorrectUserData(login, password, confirmPassword))
        {
            Console.WriteLine("Регистрация пройдена успешно");
            _login = login;
            _password = password;
        }
        else
            Console.WriteLine("Не удалось зарегистрироваться");
    }

    static bool IsCorrectUserData(string login, string password, string confirmPassword)
    {
        bool isLoginCorrect = !string.IsNullOrEmpty(login);
        bool isPasswordCorrect = !string.IsNullOrEmpty(password);
        bool isConfirmCorrect = password == confirmPassword;

        return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
    }
}