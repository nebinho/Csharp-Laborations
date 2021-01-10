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

namespace Uppgift3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btn1.Content = "Oklickad";
            btn2.Content = "Oklickad";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = "Klickad";
            btn2.Content = "Oklickad";
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            btn2.Content = "Klickad";
            btn1.Content = "Oklickad";
        }

    }

}