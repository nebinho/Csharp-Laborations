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
        string input;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCountAge_Click(object sender, RoutedEventArgs e)
        {
            IsStringCorrect();

        }

        /*
        private bool IsStringCorrect(string input, int number)
        {
            input = "";
            
            foreach (int item in string)
            {

            }

            return false;
        }
        */


        private bool IsStringCorrect()
        {
            input = txtBirthAge.Text;

            if (!Char.IsLetter(input, input.Length))
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }

        /*
        private string FalseInput(string inputText)
        {
            IsStringCorrect(txtBirthAge.Text);

            if (IsStringCorrect())
            {
                true;
            }
            string messageWrong = "¨Du måste mata in enbart siffror";

            return messageWrong;
        }
        */


    }
}
