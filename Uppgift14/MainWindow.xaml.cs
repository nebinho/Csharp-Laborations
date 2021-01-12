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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCountAge_Click(object sender, RoutedEventArgs e)
        {
            string input;
            input = txtBirthAge.Text;
            
            if (IsStringCorrect(input) == false)
            {
                MessageBox.Show($"Du måste mata in enbart siffror");
            }
            else
            {
                int age = DateTime.Now.Year - int.Parse(txtBirthAge.Text);

                MessageBox.Show($"Du är {age} år gammal");
            }
        }


        private bool IsStringCorrect(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input, i))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
