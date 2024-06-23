using System.Formats.Tar;
using System.IO;
using System.Windows;
using static System.Net.WebRequestMethods;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<FileInfo> files;

        public MainWindow()
        {

            InitializeComponent();

            GetFiles();
        }

        private void GetFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(DirectoryTextBox.Text);
            files = directory.GetFiles("*", SearchOption.AllDirectories).ToList();
            FilterFiles("");
        }


        private void SearchTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            FilterFiles(SearchTextBox.Text);
        }

 
        private void FilterFiles(string searchText)
        {
            var result = files
                .Where(file => file.Name.ToLower().Contains(searchText.ToLower()))
                .ToList();

            if (result.Count > 0)
            {
                resultDataGrid.ItemsSource = result;
                recordCountLabel.Content = $"Показано {result.Count} из {files.Count} записей";
            }
            else
            {
                resultDataGrid.ItemsSource = null;
                recordCountLabel.Content = "Записей не найдено.";
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            SearchTextBox.Text = "";
            FilterFiles("");
        }
    }
}