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

namespace Zadanie4Practic5
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
        private void BtnCancelClick(object sender, RoutedEventArgs e) { Close(); }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(TbNumberA.Text);
            int n = int.Parse(TbNumberB.Text);
            double result = x; 

            for (int i = 1; i <= n; i++)
            {
                double numerator = 1;
                double denominator = 1;

                for (int j = 1; j <= 2 * i; j++)
                {
                    if (j % 2 == 0)
                    {
                        denominator *= j;
                    }
                    else
                    {
                        numerator *= j;
                    }
                }

                double term = numerator * Math.Pow(x, 2 * i + 1) / (denominator * (2 * i + 1));
                result += term;
            }
            TextBlockAnswer.Text = Convert.ToString(result);

        }
    }
}
