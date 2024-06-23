namespace Task2
{
    internal class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public static bool IsCorrectUserData(string login, string password, string confirmPassword)
        {
            bool isLoginCorrect = !string.IsNullOrEmpty(login);
            bool isPasswordCorrect = !string.IsNullOrEmpty(password);
            bool isConfirmCorrect = password == confirmPassword;

            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }
    }
}
