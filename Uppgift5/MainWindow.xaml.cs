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

namespace Uppgift5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn_sum_Click(object sender, RoutedEventArgs e)
        {
            int sum = int.Parse(tb_nmbr1.Text) + int.Parse(tb_nmbr2.Text);
            tb_sum.Text = sum.ToString();

        }

        private void btn_clr_Click(object sender, RoutedEventArgs e)
        {
            tb_nmbr1.Clear();
            tb_nmbr2.Clear();
            tb_sum.Clear();
                                      
        }
    }
}
