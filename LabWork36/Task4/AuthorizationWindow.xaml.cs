using System.Windows;

namespace Task4
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            if (login == "admin" && password == "qwerty")
            {
                OpenWindow(new AdminWindow());
            }
            else if (login == "manager" && password == "12345")
            {
                OpenWindow(new ManagerWindow());
            }
            else
            {
                MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OpenWindow(Window window)
        {
            Hide();
            window.ShowDialog();
            Show();
        }
    }
}
