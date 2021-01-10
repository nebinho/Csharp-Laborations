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

namespace Uppgift9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCtrl_Click(object sender, RoutedEventArgs e)
        {
            string name;
            int age;
            bool medvuxen = rbtnWith.IsChecked.Value;
            bool utanvuxen = rbtnWithout.IsChecked.Value;
            
            name = txtName.Text;
            age = int.Parse(txtAge.Text);

            if (age >= 15 && medvuxen)
            {
                txtMessage.Text = $"Hej {name}. Du är {age} år gammal och får se alla filmer.";
            }
            else if (age >= 11 && medvuxen)
            {
                txtMessage.Text = $"Hej {name}. Du är {age} år gammal och får se filmer med åldersgräns upp till 11 år. Det spelar ingen roll att du går tillsammans med en vuxen.";
            }
            else if (age >= 7 && medvuxen)
            {
                txtMessage.Text = $"Hej {name}. Du är {age} år gammal och får se filmer med åldersgräns upp till 11 år eftersom du har en vuxen med dig.";
            }

            else if (age >= 15 && utanvuxen)
            {
                txtMessage.Text = $"Hej {name}. Du är {age} år gammal och får se alla filmer.";
            }
            else if (age >= 11 && utanvuxen)
            {
                txtMessage.Text = $"Hej {name}. Du är {age} år gammal och får se filmer med åldersgräns upp till 11 år.";
            }
            else if (age >= 7 && utanvuxen)
            {
                txtMessage.Text = $"Hej {name}. Du är {age} år gammal och får se filmer med åldersgräns upp till 7 år.";
            }

        }

    }
}
