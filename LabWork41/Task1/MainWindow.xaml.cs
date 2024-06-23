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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private bool menuIsOpen = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            menuIsOpen = !menuIsOpen;

            DoubleAnimation animation = new DoubleAnimation
            {
                From = SideMenu.ActualWidth,
                To = menuIsOpen ? 100 : 0,
                Duration = TimeSpan.FromSeconds(1),
            };

            SideMenu.BeginAnimation(WidthProperty, animation);
        }
    }
}
