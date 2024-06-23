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

            #region Task5
            List<string> categories = new List<string>
            {
                "головоломка",
                "платформер",
                "аркада"
            };
            DataBox.ItemsSource = categories;
            #endregion

            List<Game> games = new List<Game>
            {
                 new Game{IdGame = 1, Name = "Tetris", Site="igri.ru", Category = "головоломка", Price = 150},
                 new Game{IdGame = 2, Name = "Flappy Bird", Site="igri.ru", Category = "платформер", Price = 10},
                 new Game{IdGame = 3, Name = "Pac-man", Site="igri.ru", Category = "аркада", Price = 300},
                 new Game{IdGame = 4, Name = "Arkanoid", Site="igri.ru", Category = "аркада", Price = 400},
                 new Game{IdGame = 5, Name = "Mario", Site="igri.ru",Category = "платформер", Price = 1000},
            };
            Datagrid.ItemsSource = games;
        }

        #region Task4
        private void MoreButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Game gameInfo = (Game)button.DataContext;
            MessageBox.Show($"Название: {gameInfo.Name},\n Айди: {gameInfo.IdGame},\n Категория: {gameInfo.Category},\n Цена:{gameInfo.Price},\n Сайт: {gameInfo.Site}");
        }
        #endregion
    }
}
