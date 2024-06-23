using System.Windows;

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
        }

        private void ConfirmCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SubcribeButton.IsEnabled = true;
        }

        private void ConfirmCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            SubcribeButton.IsEnabled = false;
        }
    }
}