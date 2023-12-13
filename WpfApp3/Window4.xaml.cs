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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Math_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(AA.Text);
            double a = double.Parse(BB.Text);
            double p = 1 / Cos(x) + Log(Abs(Tan(x / 2))) + x / (1 + (x / (1 + x)));
            double alfa = (Pow(p, 5) * Sqrt(a * Pow(x, 3) + 2)) / 2 * Cos(x);
            MessageBox.Show($"alfa={alfa}", "Ответ");
        }

        private int Sqrt(double v)
        {
            throw new NotImplementedException();
        }

        private int Pow(double p, int v)
        {
            throw new NotImplementedException();
        }

        private object Tan(double v)
        {
            throw new NotImplementedException();
        }

        private object Abs(object p)
        {
            throw new NotImplementedException();
        }

        private int Log(object p)
        {
            throw new NotImplementedException();
        }

        private int Cos(double x)
        {
            throw new NotImplementedException();
        }
    }
}
