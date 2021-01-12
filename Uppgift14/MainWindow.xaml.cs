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

namespace Uppgift14
{
    public partial class MainWindow : Window
    {
        string[] input;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCountAge_Click(object sender, RoutedEventArgs e)
        {
            txtBirthAge.Text

            IsStringCorrect(input);

        }

        
        private bool IsStringCorrect(string[] input)
        {
            int i = 0;

            
                if (!Char.IsLetter(input[i], input.Length))
                {
                    return true;
                }
          
            
                return false;
        }

        
    }
}
