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
    /// Logique d'interaction pour AjoutDresseur.xaml
    /// </summary>
    public partial class AjoutDresseur : Window {
        public AjoutDresseur() {
            InitializeComponent();
            BManager = new BusinessManager();
            dataGrid_ajout_dresseur.ItemsSource = BManager.getPokemon();
            if (dataGrid_ajout_dresseur != null) {
                label_grid_gotPokemon.Visibility = Visibility.Visible;
                dataGrid_ajout_dresseur.Visibility = Visibility.Visible;

                label_grid_noPokemon.Visibility = Visibility.Collapsed;
                fg_nom_pokemon.Visibility = Visibility.Collapsed;
                bg_nom_pokemon.Visibility = Visibility.Collapsed;

                cb_Elem.Visibility = Visibility.Collapsed;
                caract.Visibility = Visibility.Collapsed;
                life.Visibility = Visibility.Collapsed;
                life2.Visibility = Visibility.Collapsed;
                vie.Visibility = Visibility.Collapsed;

                str.Visibility = Visibility.Collapsed;
                str2.Visibility = Visibility.Collapsed;
                force.Visibility = Visibility.Collapsed;

                dex.Visibility = Visibility.Collapsed;
                dex2.Visibility = Visibility.Collapsed;
                agilite.Visibility = Visibility.Collapsed;

                intel.Visibility = Visibility.Collapsed;
                intel2.Visibility = Visibility.Collapsed;
                intelligence.Visibility = Visibility.Collapsed;
            }
        }
        private BusinessManager BManager;

        private void nom_dresseur_LostFocus(object sender, RoutedEventArgs e) {
            if (String.IsNullOrWhiteSpace(nom_dresseur.Text)) {
                nom_dresseur.Visibility = Visibility.Collapsed;
                bg_nom_dresseur.Visibility = Visibility.Visible;
            }
        }

        private void bg_nom_dresseur_GotFocus(object sender, RoutedEventArgs e) {
            bg_nom_dresseur.Visibility = Visibility.Collapsed;
            nom_dresseur.Visibility = Visibility.Visible;
            nom_dresseur.Focus();
        }

        private void cancel_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void add_Click(object sender, RoutedEventArgs e) {
            //Cas d'erreurs, pop-up dans l'ordre descendant : nom, puis elem, pas les deux en meme temps
            if (String.IsNullOrWhiteSpace(nom_dresseur.Text)) {
                MessageBox.Show("Formulaire incomplet : Nom manquant", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            //Si ok, l'enregistrer
            else {
                
                if ((bool)radioYes.IsChecked) {
                    if (dataGrid_ajout_dresseur.SelectedItem == null) {
                        MessageBox.Show("Veuillez sélectionner un Pokemon.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else {
                        BManager.getDresseur().Add(new Dresseur(nom_dresseur.Text, (Pokemon)dataGrid_ajout_dresseur.SelectedItem));
                        ((MainMenu)DataContext).Refresh_DataGridDresseur();
                        this.Close();
                    }
                } else {
                    if (fg_nom_pokemon.Text == null) {
                        MessageBox.Show("Veuillez préciser le nom du Pokemon.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    } else if (cb_Elem.SelectedIndex < 1) {
                        MessageBox.Show("Veuillez préciser l'élément du Pokemon.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    } else {
                        Pokemon p = new Pokemon(fg_nom_pokemon.Text, (ETypeElement)cb_Elem.SelectedIndex - 1,
                                    new Caracteristique((int)vie.Value, (int)force.Value, (int)agilite.Value, (int)intelligence.Value));
                        BManager.getPokemon().Add(p);
                        BManager.getDresseur().Add(new Dresseur(nom_dresseur.Text, p));
                        ((MainMenu)DataContext).Refresh_DataGridDresseur();
                        ((MainMenu)DataContext).Refresh_DataGridPokemon();
                        this.Close();
                    }
                }
            }
        }

        private void radioYes_Checked(object sender, RoutedEventArgs e) {
            if (dataGrid_ajout_dresseur != null) {
                label_grid_gotPokemon.Visibility = Visibility.Visible;
                dataGrid_ajout_dresseur.Visibility = Visibility.Visible;

                label_grid_noPokemon.Visibility = Visibility.Collapsed;
                fg_nom_pokemon.Visibility = Visibility.Collapsed;
                bg_nom_pokemon.Visibility = Visibility.Collapsed;

                cb_Elem.Visibility = Visibility.Collapsed;
                caract.Visibility = Visibility.Collapsed;
                life.Visibility = Visibility.Collapsed;
                life2.Visibility = Visibility.Collapsed;
                vie.Visibility = Visibility.Collapsed;

                str.Visibility = Visibility.Collapsed;
                str2.Visibility = Visibility.Collapsed;
                force.Visibility = Visibility.Collapsed;

                dex.Visibility = Visibility.Collapsed;
                dex2.Visibility = Visibility.Collapsed;
                agilite.Visibility = Visibility.Collapsed;

                intel.Visibility = Visibility.Collapsed;
                intel2.Visibility = Visibility.Collapsed;
                intelligence.Visibility = Visibility.Collapsed;
            }
        }

        private void radioNo_Checked(object sender, RoutedEventArgs e) {
            if (dataGrid_ajout_dresseur != null) {
                label_grid_gotPokemon.Visibility = Visibility.Collapsed;
                dataGrid_ajout_dresseur.Visibility = Visibility.Collapsed;

                label_grid_noPokemon.Visibility = Visibility.Visible;
                fg_nom_pokemon.Visibility = Visibility.Visible;
                bg_nom_pokemon.Visibility = Visibility.Visible;
                
                cb_Elem.Visibility = Visibility.Visible;
                caract.Visibility = Visibility.Visible;
                life.Visibility = Visibility.Visible;
                life2.Visibility = Visibility.Visible;
                vie.Visibility = Visibility.Visible;

                str.Visibility = Visibility.Visible;
                str2.Visibility = Visibility.Visible;
                force.Visibility = Visibility.Visible;

                dex.Visibility = Visibility.Visible;
                dex2.Visibility = Visibility.Visible;
                agilite.Visibility = Visibility.Visible;

                intel.Visibility = Visibility.Visible;
                intel2.Visibility = Visibility.Visible;
                intelligence.Visibility = Visibility.Visible;
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
