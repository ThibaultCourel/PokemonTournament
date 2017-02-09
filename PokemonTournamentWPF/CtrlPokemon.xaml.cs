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

using EntitiesLayer;

namespace PokemonTournamentWPF {
    /// <summary>
    /// Logique d'interaction pour CtrlPokemon.xaml
    /// </summary>
    public partial class CtrlPokemon : UserControl {
        //public Pokemon pokemon { get; set; }

        public CtrlPokemon() {
            InitializeComponent();
            //pokemon = new Pokemon() { Caract = new Caracteristique() };
            //this.DataContext = pokemon;
        }

        //public CtrlPokemon(Pokemon poke) {
        //    InitializeComponent();
        //    pokemon = new Pokemon() { Caract = new Caracteristique() };
        //    this.DataContext = pokemon;
        //    pokemon = poke;
        //}

        private void close_Click(object sender, RoutedEventArgs e) {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
