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

namespace LabWork38
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

        private void GetFilterFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(@"X:\МДК.01.01");
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
            var result = files
                       .Where(file => file.Name.Contains(SearchTextBox.Text))
                       .Select(file => new { file.Name, file.Extension, file.FullName, file.Length, file.CreationTime, file.LastWriteTime })
                       .ToList();

            if (result.Count() == 0)
                MessageBox.Show("Подходящих записей не найдено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                resultDataGrid.ItemsSource = result;
        }
    }
}