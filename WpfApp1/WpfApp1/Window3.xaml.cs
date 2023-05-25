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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(vod.Text);
            int y = int.Parse(vod2.Text);
            int z = int.Parse(vod3.Text);
            int middle = (x + y + z) - Math.Max(Math.Max(x, y), z) - Math.Min(Math.Min(x, y), z);

            otv.Text=("Среднее число: " + middle);

        }
    }
}
