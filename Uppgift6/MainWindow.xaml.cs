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

namespace Uppgift6
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            lblResult.Content = "Resultat";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double tal1 = 0, tal2 = 0, result = 0;

            tal1 = double.Parse(tbNum1.Text);
            tal2 = double.Parse(tbNum2.Text);
            result = tal1 + tal2;
            result = Math.Round(result, 2);
            tbRes.Text = result.ToString();
            lblResult.Content ="Summa";
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            double tal1 = 0, tal2 = 0, result = 0;

            tal1 = double.Parse(tbNum1.Text);
            tal2 = double.Parse(tbNum2.Text);
            result = tal1 - tal2;
            result = Math.Round(result, 2);
            tbRes.Text = result.ToString();
            lblResult.Content = "Differens";
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            double tal1 = 0, tal2 = 0, result = 0;

            tal1 = double.Parse(tbNum1.Text);
            tal2 = double.Parse(tbNum2.Text);
            result = tal1 * tal2;
            result = Math.Round(result, 2);
            tbRes.Text = result.ToString();
            lblResult.Content = "Produkt";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            double tal1 = 0, tal2 = 0, result = 0;

            tal1 = double.Parse(tbNum1.Text);
            tal2 = double.Parse(tbNum2.Text);
            result = tal1 / tal2;
            result = Math.Round(result, 2);
            tbRes.Text = result.ToString();
            lblResult.Content = "Kvot";
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            tbNum1.Clear();
            tbNum2.Clear();
            tbRes.Clear();
            lblResult.Content = "Resultat";
        }
    }
}
