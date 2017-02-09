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
    /// Logique d'interaction pour AjoutPokemon.xaml
    /// </summary>
    public partial class AjoutPokemon : Window {
        public AjoutPokemon() {
            InitializeComponent();
            BManager = new BusinessManager();
        }

        private BusinessManager BManager;

        private void cancel_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void add_Click(object sender, RoutedEventArgs e) {
            //Cas d'erreurs, pop-up dans l'ordre descendant : nom, puis elem, pas les deux en meme temps
            if (String.IsNullOrWhiteSpace(fg_nom_pokemon.Text)) {
                MessageBox.Show("Formulaire incomplet : Nom manquant", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (cbElem.SelectedIndex <= 0) {
                MessageBox.Show("Formulaire incomplet : Element manquant", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            //Si ok, l'enregistrer
            else {
                BManager.getPokemon().Add(new Pokemon(fg_nom_pokemon.Text, (ETypeElement)cbElem.SelectedIndex - 1, 
                                          new Caracteristique((int)vie.Value, (int)force.Value, (int)agilite.Value, (int)intelligence.Value)));
                this.Close();
                ((MainMenu)DataContext).Refresh_DataGridPokemon();
            }
        }

        private void fgNom_LostFocus(object sender, RoutedEventArgs e) {
            if (String.IsNullOrWhiteSpace(fg_nom_pokemon.Text)) {
                fg_nom_pokemon.Visibility = Visibility.Collapsed;
                bg_nom_pokemon.Visibility = Visibility.Visible;
            }
        }

        private void bgNom_GotFocus(object sender, RoutedEventArgs e) {
            bg_nom_pokemon.Visibility = Visibility.Collapsed;
            fg_nom_pokemon.Visibility = Visibility.Visible;
            fg_nom_pokemon.Focus();
        }
    }
}
