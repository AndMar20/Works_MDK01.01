using System.Windows;
using System.Windows.Media;

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

        byte red;
        byte green;
        byte blue;

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        private void ChangeColor()
        {
            red = (byte)RedSlider.Value;
            green = (byte)GreenSlider.Value;
            blue = (byte)BlueSlider.Value;
            Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }

        private void RedCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (RedCheckBox.IsChecked == false)
            {
                RedSlider.Value = 0;
                RedSlider.IsEnabled = false;
            }
            else
            {
                RedSlider.IsEnabled = true;
            }  
            ChangeColor();
        }

        private void GreenCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (GreenCheckBox.IsChecked == false)
            {
                GreenSlider.Value = 0;
                GreenSlider.IsEnabled = false;
            }
            else
            { 
                GreenSlider.IsEnabled = true;
            }    
            ChangeColor();
        }

        private void BlueCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (BlueCheckBox.IsChecked == false)
            {
                BlueSlider.Value = 0;
                BlueSlider.IsEnabled = false;
            }
            else
            {
                BlueSlider.IsEnabled = true;
            }
            ChangeColor();      
        }
    }
}