using Library;
using System.Data.SqlClient;
using System.Windows;

namespace LabWorks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            QueryTextBox.Text = "";
        }

        private void Task2RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            QueryTextBox.Text = "INSERT INTO Games (name, Price, category) VALUES ('Приколы', 100, 'RPG')";
        }

        private void Task3RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            QueryTextBox.Text = "";
        }

        private void Task4RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            QueryTextBox.Text = "";
        }

        private void SendQueryButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Task1RadioButton.IsChecked == true)
                    ResultTextBox.Text = $"Количество книг с ценой меньше {PriceTextBox.Text}: {DataAccessLayer.GetCountLowerPrice(Convert.ToInt32(PriceTextBox.Text))}";
                if (Task2RadioButton.IsChecked == true)
                    ResultTextBox.Text = $"Id добавленной записи: {DataAccessLayer.AddRow(QueryTextBox.Text)}";
                if (Task3RadioButton.IsChecked == true)
                    TableDataGrid.ItemsSource = DataAccessLayer.GetGenreAndLowerPriceTable(Convert.ToInt32(Price3TextBox.Text), GenreTextBox.Text).DefaultView;
                if (Task4RadioButton.IsChecked == true)
                    ResultTextBox.Text = $"Результат обновления: {DataAccessLayer.IsUpdateRow(Convert.ToInt32(IdTextBox.Text), NewNameTextBox.Text, Convert.ToInt32(NewPriceTextBox.Text))}";
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Ошибка выполнения SQL-запроса: " + exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message);
            }
        }
    }
}