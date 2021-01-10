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

namespace Uppgift10
{
    public partial class MainWindow : Window
    {
        private static readonly Random slump = new Random();
        
        int slumptal, gissning, count = 0;
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSlump_Click(object sender, RoutedEventArgs e)
        {
            slumptal = slump.Next(1001);

            btnGuess.IsEnabled = true;
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            gissning = int.Parse(txtNumber.Text);
            count++;

                if (gissning == slumptal)
                {
                    txtFeedback.Text = $"Grattis du gissade rätt på {count} försök!";
                }

                else if (gissning >= (slumptal + 100))
                {
                    txtFeedback.Text = "Oh, du är inte ens nära. Du gissade alldeles för högt.";
                }

                else if (gissning <= (slumptal - 100))
                {
                    txtFeedback.Text = "Oh, du är inte ens nära. Du gissade alldeles för lågt.";
                }

                else if (gissning > slumptal)
                {
                    txtFeedback.Text = "Du gissade tyvärr för högt";
                }

                else if (gissning < slumptal)
                {
                    txtFeedback.Text = "Du gissade tyvärr för lågt";
                }
        }
    }
}
