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

namespace Uppgift7
{
     public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int nummer1, nummer2, heltal, rest;

            nummer1 = int.Parse(txtNumber1.Text);
            nummer2 = int.Parse(txtNumber2.Text);
            heltal = nummer1 / nummer2;
            rest = nummer1 % nummer2;
            txtWhole.Text = heltal.ToString();
            txtRest.Text = rest.ToString();
        }
    }
}
