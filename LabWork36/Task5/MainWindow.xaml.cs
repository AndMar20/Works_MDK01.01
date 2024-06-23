using System.Drawing;
using System.Runtime.CompilerServices;
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
        }

        private void ChangeBackgroundColor_Click(object sender, RoutedEventArgs e)
        {
            ChengeBackgroungDialog dialog = new();
            if (dialog.ShowDialog() == true)
                window.Background = new SolidColorBrush(dialog.CurrentColor);
        }
    }
}