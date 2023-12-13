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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Math_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(AA.Text);
            int b = int.Parse(BB.Text);
            int c = int.Parse(CC.Text);
            int AC = Math.Abs(c - a);
            int BC = Math.Abs(b - c);
            int prog = AC * BC;
            MessageBox.Show($"произведение = {prog}", "Ответ");
        }
    }
}
