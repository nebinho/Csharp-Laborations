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

namespace Uppgift12
{
    public partial class MainWindow : Window
    {
        int[] values = new int[5];
        int counter = 0, input = 0;
        double average = 0, sum = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (counter < values.Length)
            {
                input = int.Parse(txtInput.Text);

                values[counter] = input;
                counter++;
                listBoxValues.ItemsSource = null;
                listBoxValues.ItemsSource = values;

                txtInput.Clear();
            }
            if (counter == values.Length)
            {
                foreach (int number in values)
                {
                    sum += number;
                }
                
                average = sum / values.Length;
                txtAverage.Text = average.ToString();

                btnOk.IsEnabled = false;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Array.Clear(values, 0, values.Length);

            counter = 0;
            txtAverage.Clear();
            txtInput.Clear();
            listBoxValues.ItemsSource = null;
            sum = 0;

            btnOk.IsEnabled = true;
            txtInput.Focus();
        }        
    }
}
