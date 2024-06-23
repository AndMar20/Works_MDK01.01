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

namespace Task4
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

        private void PercentSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PercentLabel.Content = $"Процент: {Math.Round(PercentSlider.Value, 2)} %";
            ResultLabel.Content = $"Результат {CostSlider.Value * PercentSlider.Value / 100:C}";
        }

        private void CostSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CostLabel.Content = $"Цена: {Math.Round(CostSlider.Value, 2)} Р.";
            ResultLabel.Content = $"Результат: {CostSlider.Value * PercentSlider.Value / 100:C}";
        }
    }
}