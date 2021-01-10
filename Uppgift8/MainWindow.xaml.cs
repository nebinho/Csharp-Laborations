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

namespace Uppgift8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            double galleoner, siklar, knutingar, output;

            galleoner = double.Parse(txtCurrency1.Text);
            siklar = double.Parse(txtCurrency2.Text);
            knutingar = double.Parse(txtCurrency3.Text);
                        
            output = galleoner * 62.02 + siklar * (62.02/17) + knutingar * (62.02/493);
            output = Math.Round(output, 0);

            lblOutput.Content = output.ToString();             
        }
    }
}
