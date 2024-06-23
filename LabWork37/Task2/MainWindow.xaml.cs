using System.Diagnostics;
using System.IO;
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

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<FileInfo> files;
        public RadioButton selectedRadioButton;

        public MainWindow()
        {
            InitializeComponent();

            
            GetCheckedRadioButton();
            GetFiles();
        }
        private void GetFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(DirectoryTextBox.Text);
            files = directory.GetFiles("*", SearchOption.AllDirectories).ToList();
            FilterFiles("");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            SearchTextBox.Text = "";
            FilterFiles("");
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetCheckedRadioButton();
            FilterFiles(SearchTextBox.Text);
        }
        
        private void FilterFiles(string searchText)
        {
            List<FileInfo> result = files;

            switch (selectedRadioButton.Content.ToString())
            {
                case "Больше или равно":
                    result = files.Where(file => file.Length >= GetSize()).ToList();
                    break;
                case "Меньше или равно":
                    result = files.Where(file => file.Length <= GetSize()).ToList();
                    break;
                case "Все файлы":
                    break;
            }

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

        private void GetCheckedRadioButton()
        {
            if (greaterOrEqualRadioButton.IsChecked == true)
            {
                selectedRadioButton = greaterOrEqualRadioButton;
            }
            else if (lessOrEqualRadioButton.IsChecked == true)
            {
                selectedRadioButton = greaterOrEqualRadioButton;
            }
            else
            {
                selectedRadioButton = allFilesRadioButton;
            }
        }

        private long GetSize()
        {
            if (long.TryParse(SearchTextBox.Text, out long size))
            {
                return size;
            }
            else
            {
                return 0;
            }
        }
    }
}