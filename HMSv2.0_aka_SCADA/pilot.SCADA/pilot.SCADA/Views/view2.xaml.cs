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

namespace pilot.SCADA.Views
{
    /// <summary>
    /// view2.xaml 的交互逻辑
    /// </summary>
    public partial class view2
    {
        public view2()
        {
            InitializeComponent();
        }

        private void click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("11111");
        }
    }
}