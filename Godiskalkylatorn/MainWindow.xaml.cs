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

namespace Godiskalkylatorn
{
    public partial class MainWindow : Window
    {
        CandyCalculator candy;
        Person person;

        public MainWindow()
        {
            InitializeComponent();

            candy = new CandyCalculator();
            person = new Person();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            candy.AddPerson(txtFirstName.Text, txtLastName.Text, int.Parse(txtAge.Text));
            UpdateUI();
            ClearUI();            
        }

        private void btnDistribute_Click(object sender, RoutedEventArgs e)
        {
            int candies = int.Parse(txtCandies.Text);
            bool byLastName, byFirstName, byAge;

            byLastName = rbtnLastName.IsChecked.Value;
            byFirstName = rbtnFirstName.IsChecked.Value;
            byAge = rbtnAge.IsChecked.Value;

            candy.DistributeCandies(candies, byLastName, byFirstName, byAge);
            UpdateUI();
        }

        public void UpdateUI()
        {
            lstPersons.ItemsSource = null;
            lstPersons.ItemsSource = candy.personList;          
        }

        public void ClearUI()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
        }
    }
}
