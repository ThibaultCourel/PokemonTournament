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

using BusinessLayer;
using EntitiesLayer;

namespace PokemonTournamentWPF {
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private BusinessManager BManager;

        public MainWindow() {
            InitializeComponent();
            BManager = new BusinessManager();
        }
               

        private void connect_Click(object sender, RoutedEventArgs e) {
            if (BManager.CheckConnexion(fgLogin.Text, fgPassword.Password)) {
                MainMenu win = new MainMenu();
                win.Show();
                this.Close();
            } else {
                MessageBox.Show("Identifiants invalides.", "Echec de la connexion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void fgLogin_LostFocus(object sender, RoutedEventArgs e) {
            if (String.IsNullOrWhiteSpace(fgLogin.Text)) {
                fgLogin.Visibility = Visibility.Collapsed;
                bgLogin.Visibility = Visibility.Visible;
            }
        }

        private void bgLogin_GotFocus(object sender, RoutedEventArgs e) {
            bgLogin.Visibility = Visibility.Collapsed;
            fgLogin.Visibility = Visibility.Visible;
            fgLogin.Focus();
        }

        private void fgPassword_LostFocus(object sender, RoutedEventArgs e) {
            if (String.IsNullOrWhiteSpace(fgPassword.Password)) {
                fgPassword.Visibility = Visibility.Collapsed;
                bgPassword.Visibility = Visibility.Visible;
            }
        }

        private void bgPassword_GotFocus(object sender, RoutedEventArgs e) {
            bgPassword.Visibility = Visibility.Collapsed;
            fgPassword.Visibility = Visibility.Visible;
            fgPassword.Focus();
        }
    }
}
