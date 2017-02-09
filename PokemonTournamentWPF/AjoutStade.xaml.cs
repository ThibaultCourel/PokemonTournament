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
using System.Windows.Shapes;

using BusinessLayer;
using EntitiesLayer;

namespace PokemonTournamentWPF {
    /// <summary>
    /// Logique d'interaction pour AjoutStade.xaml
    /// </summary>
    public partial class AjoutStade : Window {
        public AjoutStade() {
            InitializeComponent();
            BManager = new BusinessManager();
        }

    private BusinessManager BManager;

    private void cancel_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void add_Click(object sender, RoutedEventArgs e) {
            if (String.IsNullOrWhiteSpace(nom.Text)) {
                MessageBox.Show("Formulaire incomplet : Nom manquant", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (cbElem_add.SelectedIndex < 1) {
                MessageBox.Show("Formulaire incomplet : Element manquant", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //Si ok, l'enregistrer
            else {
                BManager.getStades().Add(new Stade(nom.Text, (int)slider_place.Value, (ETypeElement)cbElem_add.SelectedIndex - 1,
                                         new Caracteristique((int)vie.Value, (int)force.Value, (int)agilite.Value, (int)intelligence.Value)));
                this.Close();
                ((MainMenu)DataContext).Refresh_DataGridStade();
            }
        }

        private void bg_nom_GotFocus(object sender, RoutedEventArgs e) {
            bg_nom.Visibility = Visibility.Collapsed;
            nom.Visibility = Visibility.Visible;
            nom.Focus();
        }

        private void nom_LostFocus(object sender, RoutedEventArgs e) {
            if (String.IsNullOrWhiteSpace(nom.Text)) {
                nom.Visibility = Visibility.Collapsed;
                nom.Visibility = Visibility.Visible;
            }
        }

        private void nom_TextChanged(object sender, TextChangedEventArgs e) {

        }
    }
}
