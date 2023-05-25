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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(TbNumberA.Text);
            string description;

            if (number == 0)
            {
                description = "нулевое число";
            }
            else if (number > 0)
            {
                if (number % 2 == 0)
                {
                    description = "положительное четное число";
                }
                else
                {
                    description = "положительное нечетное число";
                }
            }
            else
            {
                if (number % 2 == 0)
                {
                    description = "отрицательное четное число";
                }
                else
                {
                    description = "отрицательное нечетное число";
                }
            }

            TextBlockAnswer.Text = description;
        }
    }
}
