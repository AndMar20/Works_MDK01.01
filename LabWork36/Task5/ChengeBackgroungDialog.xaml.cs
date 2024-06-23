using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task5
{
    /// <summary>
    /// Логика взаимодействия для ChengeBackgroungDialog.xaml
    /// </summary>
    public partial class ChengeBackgroungDialog : Window
    {
        public Color CurrentColor => Color.FromRgb(red, green, blue);

        byte red;
        byte green;
        byte blue;

        public ChengeBackgroungDialog()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            red = (byte)RedSlider.Value;
            green = (byte)GreenSlider.Value;
            blue = (byte)BlueSlider.Value;
            ColorRectangle.Fill = new SolidColorBrush(CurrentColor);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
