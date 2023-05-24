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

namespace zadanie3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = 0, b = 0, c = 0;

            if (!double.TryParse(textBoxA.Text, out a))
            {
                ResultLabel.Content = "Некорректный ввод";
                return;
            }

            if (!double.TryParse(textBoxB.Text, out b))
            {
                ResultLabel.Content = "Некорректный ввод";
                return;
            }

            if (!double.TryParse(textBoxC.Text, out c))
            {
                ResultLabel.Content = "Некорректный ввод";
                return;
            }

            if (a < b && b < c)
            {
                a *= 2;
                b *= 2;
                c *= 2;

                ResultLabel.Content = "A: " + a + ", B: " + b + ", C: " + c;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;

                ResultLabel.Content = "A: " + a + ", B: " + b + ", C: " + c;
            }
        }
    }
}

