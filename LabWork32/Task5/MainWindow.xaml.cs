using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task3;

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> users = new List<User>
            {
                 new User{Id = 1, Login = "Admin", Password = "Admin"},
                 new User{Id = 2, Login = "User1", Password = "12345678"},
                 new User{Id = 3, Login = "User2", Password = "qwerty"},
                 new User{Id = 4, Login = "User3", Password = "1234"},
                 new User{Id = 5, Login = "Andrey", Password = "30.04.2003"},
            };

            ComboBox.ItemsSource = users;
            ListBox.ItemsSource = users;
            ListView.ItemsSource = users;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}