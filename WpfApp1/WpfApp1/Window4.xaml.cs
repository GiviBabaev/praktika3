﻿using System;
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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int k = int.Parse(vod.Text); 
            double x = int.Parse(vod2.Text); 

            double y;
            if (k == 3)
            {
                y = Math.Sin(x) + 2;
            }
            else if (k == 20)
            {
                y = 2;
            }
            else if (k == 10 || k == 15)
            {
                y = Math.Tan(x) + Math.Sin(x);
            }
            else
            {
                y = double.NaN;
            }

            otv.Text=("Значение функции: " + y);
        }
    }
}
