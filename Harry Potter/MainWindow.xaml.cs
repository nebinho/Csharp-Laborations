using System;
using System.Collections.Generic;
using System.IO;
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
        House house;
        Hogwarts hogwarts;
        Wizard wizard;

        public MainWindow()
        {
            InitializeComponent();
            hogwarts = new Hogwarts();

            #region Adds houses to combobox
            cboHouses.Items.Add(hogwarts.gryffindor);
            cboHouses.Items.Add(hogwarts.hufflepuff);
            cboHouses.Items.Add(hogwarts.ravenclaw);
            cboHouses.Items.Add(hogwarts.slytherin);
            #endregion

            #region Sets mascots to houses
            lblGryffindorMascot.Content = hogwarts.gryffindor.Mascot;
            lblHufflepuffMascot.Content = hogwarts.hufflepuff.Mascot;
            lblRavenclawMascot.Content = hogwarts.ravenclaw.Mascot;
            lblSlytherinMascot.Content = hogwarts.slytherin.Mascot;
            #endregion
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            string newPass, oldPass;
            newPass = txtNewPassword.Text;
            oldPass = txtOldPassword.Text;           

            if (cboHouses.SelectedItem.Equals(hogwarts.gryffindor) && hogwarts.gryffindor.SetPassword(newPass, oldPass))
            {               
                MessageBox.Show($"Lösenordsbyte utfört! Ditt nya lösenord är: {hogwarts.gryffindor.Password}");

                ClearPasswordBoxes();
            }
            else if (cboHouses.SelectedItem.Equals(hogwarts.hufflepuff) && hogwarts.hufflepuff.SetPassword(newPass, oldPass))
            {
                MessageBox.Show($"Lösenordsbyte utfört! Ditt nya lösenord är: {hogwarts.hufflepuff.Password}");

                ClearPasswordBoxes();
            }
            else if (cboHouses.SelectedItem.Equals(hogwarts.ravenclaw) && hogwarts.ravenclaw.SetPassword(newPass, oldPass))
            {
                MessageBox.Show($"Lösenordsbyte utfört! Ditt nya lösenord är: {hogwarts.ravenclaw.Password}");

                ClearPasswordBoxes();
            }
            else if (cboHouses.SelectedItem.Equals(hogwarts.slytherin) && hogwarts.slytherin.SetPassword(newPass, oldPass))
            {
                MessageBox.Show($"Lösenordsbyte utfört! Ditt nya lösenord är: {hogwarts.slytherin.Password}");

                ClearPasswordBoxes();
            }
            else
            {
                MessageBox.Show($"Antingen matchar inte lösenorden varandra eller så har det nya lösenordet fel format");
            }
        }

        private void ClearPasswordBoxes()
        {
            txtNewPassword.Clear();
            txtOldPassword.Clear();
        }

        private void btnSortingHat_Click(object sender, RoutedEventArgs e)
        {
            wizard = new Wizard();
            wizard.Name = txtNewWizardName.Text;

            ShowWizardInfo(wizard);

            house = hogwarts.SortingHat(wizard);
            UpdateUI();
            txtNewWizardName.Clear();
            
            MessageBox.Show($"{wizard} är numera medlem nummer {house.Members.Count} i {house}. Spöket {house.HouseGhost} kommer ta väl hand om dig.");
        }

        public void ShowWizardInfo(Wizard wizard)
        {
            txtName.Text = wizard.Name;
            chkDeatheater.IsChecked = wizard.DeathEater;
            chkArmy.IsChecked = wizard.DumbledoresArmy;
        }

        private void UpdateUI()
        {
            lstGryffindor.ItemsSource = null;
            lstGryffindor.ItemsSource = hogwarts.gryffindor.Members;
            lstHufflepuff.ItemsSource = null;
            lstHufflepuff.ItemsSource = hogwarts.hufflepuff.Members;
            lstRavenclaw.ItemsSource = null;
            lstRavenclaw.ItemsSource = hogwarts.ravenclaw.Members;
            lstSlytherin.ItemsSource = null;
            lstSlytherin.ItemsSource = hogwarts.slytherin.Members;
        }

        #region lstMouseDoubleClick controls
        private void lstHufflepuff_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstHufflepuff.SelectedItem;
            ShowWizardInfo(wizard);
        }

        private void lstRavenclaw_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstRavenclaw.SelectedItem;
            ShowWizardInfo(wizard);
        }

        private void lstGryffindor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstGryffindor.SelectedItem;
            ShowWizardInfo(wizard);
        }

        private void lstSlytherin_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstSlytherin.SelectedItem;
            ShowWizardInfo(wizard);
        }
        #endregion
    }
}
