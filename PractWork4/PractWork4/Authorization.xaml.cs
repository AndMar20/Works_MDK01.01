using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PractWork4
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
            
        }

        private void AuthorizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text == Properties.Settings.Default.Login && PasswordTextBox.Text == Properties.Settings.Default.Password)
            {
                Settings settings = new Settings();
                settings.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
