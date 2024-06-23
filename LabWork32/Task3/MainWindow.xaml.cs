using System.Windows;
using System.Windows.Controls;

namespace Task3
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

            UsersComboBox.ItemsSource = users;
            UsersListBox.ItemsSource = users;
            UsersListView.ItemsSource = users;
        }

        private void UsersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = (User)UsersComboBox.SelectedItem;
            ComboBoxLabel.Content = $"ID: {user.Id}, Логин: {user.Login}, Пароль: {user.Password}";
        }

        /*   
         *   Вариант c дублированием кода
         *   Он позволяет нам выделять несколько несвязных объектов (не в промежутке)
         */

        private void UsersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxLabel.Content = "";
            foreach (User user in UsersListBox.SelectedItems)
            {
                ListBoxLabel.Content += $"Логин: {user.Login}\n";
            }
        }

        private void UsersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListViewLabel.Content = "";
            foreach (User user in UsersListView.SelectedItems)
            {
                ListViewLabel.Content += $"Логин: {user.Login}\n";
            }
        }

        
        /*   
         *   Вариант без дублирования кода
         *   Но он не позволяет нам выделять несколько несвязных объектов (не в промежутке)
         */

        //private void UsersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    SelectionChanged(UsersListBox, ListBoxLabel);
        //}

        //private void UsersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    SelectionChanged(UsersListView, ListViewLabel);
        //}

        //private void SelectionChanged(ListBox listBox, Label label)
        //{
        //    label.Content = "";
        //    foreach (User user in listBox.SelectedItems)
        //    {
        //        label.Content += $"Логин: {user.Login}\n";
        //    }
        //}
        


    }
}
