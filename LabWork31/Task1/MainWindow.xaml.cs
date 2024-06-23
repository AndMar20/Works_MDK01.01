using System.Windows;
using System.Windows.Controls;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BirthdayDatePicker.DisplayDateEnd = DateTime.Now;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == ConfirmPasswordBox.Password && LoginTextBox.Text != String.Empty && InfoTextBox.Text != String.Empty)
            {
                string login = LoginTextBox.Text;
                MessageBox.Show($"{login}, вы зарегистрированы");
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime birthdayDate = (DateTime)BirthdayDatePicker.SelectedDate;
            DateTime nowDate = DateTime.Now.Date;

            int age = nowDate.Year - birthdayDate.Year;
            if (nowDate.Month < birthdayDate.Month || (nowDate.Month == birthdayDate.Month && nowDate.Day < birthdayDate.Day))
            {
                age--;
            }
            AgeLabel.Content =$"Возраст: {age}";
        }
    }
}