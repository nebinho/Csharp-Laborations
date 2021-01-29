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

namespace Harry_Potter
{

    public partial class MainWindow : Window
    {
        Hogwarts hogwarts;
        House house;
        public MainWindow()
        {
            InitializeComponent();
            hogwarts = new Hogwarts();

            cboHouses.ItemsSource = null;
            cboHouses.Items.Add(hogwarts.Gryffindor);
            cboHouses.Items.Add(hogwarts.Hufflepuff);
            cboHouses.Items.Add(hogwarts.Ravenclaw);
            cboHouses.Items.Add(hogwarts.Slytherin);
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            bool correctInput;

            if (cboHouses.SelectedItem.Equals(hogwarts.Gryffindor))
            {
                correctInput = hogwarts.Gryffindor.IsInputCorrect(txtNewPassword.Text, txtOldPassword.Text);
                hogwarts.Gryffindor.SetPassword(correctInput == true, txtNewPassword.Text);
                if (correctInput == false)
                {
                    MessageBox.Show($"Antingen matchar inte lösenorden varandra eller så har det nya lösenordet fel format");
                }
                else if (correctInput == true)
                {
                    MessageBox.Show($"Lösenordsbyte utfört! Ditt nya lösenord är: {txtNewPassword.Text}");
                }
            }            
            else if (cboHouses.SelectedItem.Equals(hogwarts.Hufflepuff))
            {
                correctInput = hogwarts.Hufflepuff.IsInputCorrect(txtNewPassword.Text, txtOldPassword.Text);
                hogwarts.Hufflepuff.SetPassword(correctInput == true, txtNewPassword.Text);
                if (correctInput == false)
                {
                    MessageBox.Show($"Antingen matchar inte lösenorden varandra eller så har det nya lösenordet fel format");
                }
                else if (correctInput == true)
                {
                    MessageBox.Show($"Lösenordsbyte utfört! Ditt nya lösenord är: {txtNewPassword.Text}");
                }
            }            
            else if (cboHouses.SelectedItem.Equals(hogwarts.Ravenclaw))
            {
                correctInput = hogwarts.Ravenclaw.IsInputCorrect(txtNewPassword.Text, txtOldPassword.Text);
                hogwarts.Ravenclaw.SetPassword(correctInput == true, txtNewPassword.Text);
                if (correctInput == false)
                {
                    MessageBox.Show($"Antingen matchar inte lösenorden varandra eller så har det nya lösenordet fel format");
                }
                else if (correctInput == true)
                {
                    MessageBox.Show($"Lösenordsbyte utfört! Ditt nya lösenord är: {txtNewPassword.Text}");
                }
            }            
            else if (cboHouses.SelectedItem.Equals(hogwarts.Slytherin))
            {
                correctInput = hogwarts.Slytherin.IsInputCorrect(txtNewPassword.Text, txtOldPassword.Text);
                hogwarts.Slytherin.SetPassword(correctInput == true, txtNewPassword.Text);
                if (correctInput == false)
                {
                    MessageBox.Show($"Antingen matchar inte lösenorden varandra eller så har det nya lösenordet fel format");
                }
                else if (correctInput == true)
                {
                    MessageBox.Show($"Lösenordsbyte utfört! Ditt nya lösenord är: {txtNewPassword.Text}");
                }
            }
        }

        private void btnSortingHat_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
