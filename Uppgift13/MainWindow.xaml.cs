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

namespace Uppgift13
{
    public partial class MainWindow : Window
    {
        string text;
        char certainLetter;
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            text = txtWriteText.Text;
            certainLetter = Convert.ToChar(txtLetterSearch.Text);

                foreach (char letter in text)
                {
                    if (letter == certainLetter)
                    {
                      count++;
                    }
                }

             tbResult.Text = $"Resultat:\r\nHittade bokstaven {certainLetter} {count} gånger.";
        }
    }
}
