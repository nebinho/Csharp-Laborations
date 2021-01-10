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

namespace Uppgift11
{
    public partial class MainWindow : Window
    {
        private static readonly Random slump = new Random();
        int amount, randomnr, rightSide, wrongSide;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMore_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Value += 5;
            lblPercentage.Content = progressBar.Value + "%";
        }

        private void btnLess_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Value -= 5;
            lblPercentage.Content = progressBar.Value + "%";
        }       
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            amount = int.Parse(txtAmount.Text);

            for (int i = 0; i < amount; i++)
            {
                randomnr = slump.Next(100);

                if (randomnr > progressBar.Value)
                {
                    rightSide++;
                }
                else if (randomnr <= progressBar.Value)
                {
                    wrongSide++;
                }
            }

            tbResult.Text = $"Antal åt rätt håll {rightSide} \r\nAntal åt fel håll {wrongSide}";

            rightSide = 0;
            wrongSide = 0;
        }

    }

}
