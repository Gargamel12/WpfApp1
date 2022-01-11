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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void Kruh_0_0_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Kruh_0_0.Fill.ToString() == "#FFF7F7F7")
            {
                Kruh_0_0.Fill = Brushes.Red;
            }
            else if (Kruh_0_0.Fill.ToString() == Brushes.Red.ToString())
                Kruh_0_0_.Fill = Brushes.Green;

            }
        }
    }
}
