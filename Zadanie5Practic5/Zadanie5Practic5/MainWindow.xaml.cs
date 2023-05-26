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

namespace Zadanie5Practic5
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
            int[] a = new int[15]; // массив для хранения последовательности a
             

            for (int i = 2; i <= 14; i++)
            {
                a[i] = a[i - 3] + a[i - 1] / (int)Math.Pow(2, i - 1); // вычисление очередного значения a[i]
            }

            int product = int.Parse(TbNumberA.Text); ; // переменная для хранения произведения a[0] * a[1] * ... * a[14]

            for (int i = 0; i <= 14; i++)
            {
                product *= a[i]; // перемножение всех значений a[i]
            }

            TextBlockAnswer.Text = Convert.ToString(product);
        }
    }
}
