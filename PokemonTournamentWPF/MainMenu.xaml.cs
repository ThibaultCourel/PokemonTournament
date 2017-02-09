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
using System.IO;
using System.Xml.Serialization;

namespace PokemonTournamentWPF {
    /// <summary>
    /// Logique d'interaction pour MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window {
        private BusinessManager BManager;

        public MainMenu() {
            BManager = new BusinessManager();
            InitializeComponent();

            dataGridPokemon.ItemsSource = BManager.getPokemon();
            dataGridStade.ItemsSource = BManager.getStades();
            dataGridDresseur.ItemsSource = BManager.getDresseur();
            dataGridMatch.ItemsSource = BManager.getMatchs();

            fiche_pokemon.Visibility = Visibility.Collapsed;
            fiche_stade.Visibility = Visibility.Collapsed;
            fiche_dresseur.Visibility = Visibility.Collapsed;
        }

        private void deco_Click(object sender, RoutedEventArgs e) {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }
        #region button_pokemon
        private void rmPokemon_Click(object sender, RoutedEventArgs e) {
            if (dataGridPokemon.SelectedItem != null) {
                if (MessageBox.Show("Confirmer la suppression ?", "Confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK) {
                    foreach (Pokemon p in dataGridPokemon.SelectedItems) {
                        BManager.getPokemon().Remove(p);
                    }
                    //Actualisation
                    this.Refresh_DataGridPokemon();
                }
            }
        }

        private void addPokemon_Click(object sender, RoutedEventArgs e) {
            AjoutPokemon win = new AjoutPokemon() {
                DataContext = this
            };
            win.Show();
        }

        private void export_pokemon_Click(object sender, RoutedEventArgs e) {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Pokemons";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents |*.xml";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true) {
                string filename = dlg.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Pokemon>));
                TextWriter tw = new StreamWriter(filename);
                serializer.Serialize(tw, BManager.getPokemon());
                tw.Close();
            }
        }

        private void import_pokemon_Click(object sender, RoutedEventArgs e) {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Pokemons";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents |*xml";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true) {
                string filename = dlg.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Pokemon>));
                TextReader tr = new StreamReader(filename);
                try {
                    List<Pokemon> ls = (List<Pokemon>)serializer.Deserialize(tr);
                    tr.Close();

                    BManager.getPokemon().Clear();
                    BManager.getPokemon().AddRange(ls);
                }
                catch (InvalidOperationException err) {
                    MessageBox.Show("Fichier invalide.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                //Actualisation
                this.Refresh_DataGridPokemon();
            }
        }

        private void print_pokemon_Click(object sender, RoutedEventArgs e) {
            PrintDialog pDialog = new PrintDialog();
            pDialog.PageRangeSelection = PageRangeSelection.AllPages;
            pDialog.UserPageRangeEnabled = true;

            Nullable<Boolean> print = pDialog.ShowDialog();
            if (print == true) {
                FlowDocument doc = new FlowDocument();
                doc.ColumnWidth = 99999;
                doc.FontFamily = new FontFamily("Arial");
                //Titre
                Paragraph par = new Paragraph(new Bold(new Underline(new Run("Rapport : liste des Pokemons"))));
                par.TextAlignment = TextAlignment.Center;
                par.FontSize = 24;
                doc.Blocks.Add(par);
                //Données
                //doc.LineHeight = 1; //Pourquoi ça colle le texte à gauche...
                foreach (Pokemon p in BManager.getPokemon()) {
                    Paragraph tmp = new Paragraph();                    
                    tmp.TextAlignment = TextAlignment.Left;
                    tmp = new Paragraph(new Run(p.ID + "  -  " + p.Nom));
                    doc.Blocks.Add(tmp);
                    tmp = new Paragraph(new Run(p.Element + "  -  " + p.Caract.ToString()));
                    doc.Blocks.Add(tmp);
                    doc.Blocks.Add(new Paragraph(new Run("")));
                }
                IDocumentPaginatorSource idpSource = doc;
                pDialog.PrintDocument(idpSource.DocumentPaginator, "Rapport Pokemon");
            }
        }
    #endregion
        private void cbElem_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (cbElem_pokemon != null && search_pokemon != null) {
                this.Refresh_DataGridPokemon();
            }
        }

        #region placeholder_pokemon
        private void search_TextChanged(object sender, TextChangedEventArgs e) {
            this.Refresh_DataGridPokemon();
        }

        private void bg_search_GotFocus(object sender, RoutedEventArgs e) {
            bg_search_pokemon.Visibility = Visibility.Collapsed;
            search_pokemon.Visibility = Visibility.Visible;
            search_pokemon.Focus();
        }

        private void search_LostFocus(object sender, RoutedEventArgs e) {
            if (String.IsNullOrWhiteSpace(search_pokemon.Text)) {
                search_pokemon.Visibility = Visibility.Collapsed;
                bg_search_pokemon.Visibility = Visibility.Visible;
            }
        }
        #endregion

        public void Refresh_DataGridPokemon() {
            dataGridPokemon.ItemsSource = null;
            if (!String.IsNullOrWhiteSpace(search_pokemon.Text) && cbElem_pokemon.SelectedIndex < 1) {
                dataGridPokemon.ItemsSource = BManager.getPokemon().Where(x => x.Nom.ToLower().Contains(search_pokemon.Text.ToLower()));
            }
            else if (!String.IsNullOrWhiteSpace(search_pokemon.Text) && cbElem_pokemon.SelectedIndex > 0) {
                dataGridPokemon.ItemsSource = BManager.getPokemonByElem((ETypeElement)cbElem_pokemon.SelectedIndex - 1).Where(x => x.Nom.ToLower().Contains(search_pokemon.Text.ToLower()));
            }
            else if (String.IsNullOrWhiteSpace(search_pokemon.Text) && cbElem_pokemon.SelectedIndex > 0) {
                dataGridPokemon.ItemsSource = BManager.getPokemonByElem((ETypeElement)cbElem_pokemon.SelectedIndex - 1);
            }
            else {
                dataGridPokemon.ItemsSource = BManager.getPokemon();
            }
        }
        #region placeholder_dresseur
        private void search_dresseur_TextChanged(object sender, TextChangedEventArgs e) {
            this.Refresh_DataGridDresseur();
        }

        private void search_dresseur_LostFocus(object sender, RoutedEventArgs e) {
            if (String.IsNullOrWhiteSpace(search_dresseur.Text)) {
                search_dresseur.Visibility = Visibility.Collapsed;
                bg_search_dresseur.Visibility = Visibility.Visible;
            }
        }

        private void bg_search_dresseur_GotFocus(object sender, RoutedEventArgs e) {
            bg_search_dresseur.Visibility = Visibility.Collapsed;
            search_dresseur.Visibility = Visibility.Visible;
            search_dresseur.Focus();
        }


        private void search_d_pokemon_LostFocus(object sender, RoutedEventArgs e) {
            if (String.IsNullOrWhiteSpace(search_d_pokemon.Text)) {
                search_d_pokemon.Visibility = Visibility.Collapsed;
                bg_search_d_pokemon.Visibility = Visibility.Visible;
            }
        }

        private void search_d_pokemon_TextChanged(object sender, TextChangedEventArgs e) {
            this.Refresh_DataGridDresseur();
        }

        private void bg_search_d_pokemon_GotFocus(object sender, RoutedEventArgs e) {
            bg_search_d_pokemon.Visibility = Visibility.Collapsed;
            search_d_pokemon.Visibility = Visibility.Visible;
            search_d_pokemon.Focus();
        }
        #endregion

        public void Refresh_DataGridDresseur() {
            dataGridDresseur.ItemsSource = null;
            //Seulement element renseigné
            if (cb_dresseur.SelectedIndex > 0 && String.IsNullOrWhiteSpace(search_dresseur.Text) && String.IsNullOrWhiteSpace(search_d_pokemon.Text)) {
                dataGridDresseur.ItemsSource = BManager.getDresseur().Where(x => x.Element_Pokemon == (ETypeElement)cb_dresseur.SelectedIndex - 1);
            }
            //Seulement dresseur renseigné
            else if (cb_dresseur.SelectedIndex < 1 && !String.IsNullOrWhiteSpace(search_dresseur.Text) && String.IsNullOrWhiteSpace(search_d_pokemon.Text)) {
                dataGridDresseur.ItemsSource = BManager.getDresseur().Where(d => d.Nom.ToLower().Contains(search_dresseur.Text));
            }
            //Seulement pokemon renseigné
            else if (cb_dresseur.SelectedIndex < 1 && String.IsNullOrWhiteSpace(search_dresseur.Text) && !String.IsNullOrWhiteSpace(search_d_pokemon.Text)) {
                dataGridDresseur.ItemsSource = BManager.getDresseur().Where(p => p.Nom_Pokemon.ToLower().Contains(search_d_pokemon.Text));
            }
            //Pokemon non renseigné
            else if (cb_dresseur.SelectedIndex > 0 && !String.IsNullOrWhiteSpace(search_dresseur.Text) && String.IsNullOrWhiteSpace(search_d_pokemon.Text)) {
                dataGridDresseur.ItemsSource = BManager.getDresseur().Where(x => x.Element_Pokemon == (ETypeElement)cb_dresseur.SelectedIndex - 1).Where(d => d.Nom.ToLower().Contains(search_dresseur.Text));
            }
            //Dresseur non renseigné
            else if (cb_dresseur.SelectedIndex > 0 && String.IsNullOrWhiteSpace(search_dresseur.Text) && !String.IsNullOrWhiteSpace(search_d_pokemon.Text)) {
                dataGridDresseur.ItemsSource = BManager.getDresseur().Where(x => x.Element_Pokemon == (ETypeElement)cb_dresseur.SelectedIndex - 1).Where(p => p.Nom_Pokemon.ToLower().Contains(search_d_pokemon.Text));
            }
            //Element non renseigné
            else if (cb_dresseur.SelectedIndex < 1 && !String.IsNullOrWhiteSpace(search_dresseur.Text) && !String.IsNullOrWhiteSpace(search_d_pokemon.Text)) {
                dataGridDresseur.ItemsSource = BManager.getDresseur().Where(p => p.Nom_Pokemon.ToLower().Contains(search_d_pokemon.Text)).Where(d => d.Nom.ToLower().Contains(search_dresseur.Text));
            }
            //Tous les précisions
            else if (cb_dresseur.SelectedIndex > 0 && !String.IsNullOrWhiteSpace(search_dresseur.Text) && !String.IsNullOrWhiteSpace(search_d_pokemon.Text)) {
                dataGridDresseur.ItemsSource = BManager.getDresseur().Where(x => x.Element_Pokemon == (ETypeElement)cb_dresseur.SelectedIndex - 1).Where(d => d.Nom.ToLower().Contains(search_dresseur.Text)).Where(p => p.Nom_Pokemon.ToLower().Contains(search_d_pokemon.Text));
            }
            //Aucune précision
            else {
                dataGridDresseur.ItemsSource = BManager.getDresseur();
            }
        }

        private void cb_dresseur_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (cb_dresseur != null && search_dresseur != null && search_d_pokemon != null) {
                this.Refresh_DataGridDresseur();
            }
        }

        
        private void search_stade_TextChanged(object sender, TextChangedEventArgs e) {
            this.Refresh_DataGridStade();
        }

        #region placeholder_stade
        private void search_stade_LostFocus(object sender, RoutedEventArgs e) {
            if (String.IsNullOrWhiteSpace(search_stade.Text)) {
                search_stade.Visibility = Visibility.Collapsed;
                bg_search_stade.Visibility = Visibility.Visible;
            }
        }

        private void bg_search_stade_GotFocus(object sender, RoutedEventArgs e) {
            bg_search_stade.Visibility = Visibility.Collapsed;
            search_stade.Visibility = Visibility.Visible;
            search_stade.Focus();
        }
        #endregion

        public void Refresh_DataGridStade() {
            dataGridStade.ItemsSource = null;
            if (search_stade != null) {
                if (!String.IsNullOrWhiteSpace(search_stade.Text)) {
                    dataGridStade.ItemsSource = BManager.getStades().Where(s => s.NbPlace >= slider_min.Value * 1000).Where(x => x.NbPlace <= slider_max.Value * 1000).Where(k => k.Nom.ToLower().Contains(search_stade.Text));
                }
                else {
                    dataGridStade.ItemsSource = BManager.getStades().Where(s => s.NbPlace >= slider_min.Value * 1000).Where(x => x.NbPlace <= slider_max.Value * 1000);
                }
            }
        }

        private void slider_min_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
                this.Refresh_DataGridStade();
        }

        private void slider_max_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
                this.Refresh_DataGridStade();
        }

        #region button_dresseur
        private void export_dresseur_Click(object sender, RoutedEventArgs e) {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Dresseurs";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents |*.xml";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true) {
                string filename = dlg.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Dresseur>));
                TextWriter tw = new StreamWriter(filename);
                serializer.Serialize(tw, BManager.getDresseur());
                tw.Close();
            }
        }

        private void import_dresseur_Click(object sender, RoutedEventArgs e) {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Dresseurs";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents |*xml";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true) {
                string filename = dlg.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Dresseur>));
                TextReader tr = new StreamReader(filename);
                try {
                    List<Dresseur> ls = (List<Dresseur>)serializer.Deserialize(tr);
                    tr.Close();

                    BManager.getDresseur().Clear();
                    BManager.getDresseur().AddRange(ls);
                } catch (InvalidOperationException err) {
                    MessageBox.Show("Fichier invalide.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                //Actualisation
                this.Refresh_DataGridDresseur();
            }
        }

        private void print_dresseur_Click(object sender, RoutedEventArgs e) {
            PrintDialog pDialog = new PrintDialog();
            pDialog.PageRangeSelection = PageRangeSelection.AllPages;
            pDialog.UserPageRangeEnabled = true;

            Nullable<Boolean> print = pDialog.ShowDialog();
            if (print == true) {
                FlowDocument doc = new FlowDocument();
                doc.ColumnWidth = 99999; //triche :x
                doc.FontFamily = new FontFamily("Arial");
                //Titre
                Paragraph par = new Paragraph(new Bold(new Underline(new Run("Rapport : liste des Dresseurs"))));
                par.TextAlignment = TextAlignment.Center;
                par.FontSize = 24;
                doc.Blocks.Add(par);
                //Données
                //doc.LineHeight = 1; //Pourquoi ça colle le texte à gauche...
                foreach (Dresseur d in BManager.getDresseur()) {
                    Paragraph tmp = new Paragraph();
                    tmp.TextAlignment = TextAlignment.Left;
                    tmp = new Paragraph(new Run(d.ID + "  -  " + d.Nom));
                    doc.Blocks.Add(tmp);
                    tmp = new Paragraph(new Run(d.ID_Pokemon + "  -  " + d.Nom_Pokemon + "  -  " + d.Element_Pokemon));
                    doc.Blocks.Add(tmp);
                    doc.Blocks.Add(new Paragraph(new Run("")));
                }
                IDocumentPaginatorSource idpSource = doc;
                pDialog.PrintDocument(idpSource.DocumentPaginator, "Rapport Dresseur");
            }
        }

        private void addDresseur_Click(object sender, RoutedEventArgs e) {
            AjoutDresseur win = new AjoutDresseur() {
                DataContext = this
            };
            win.Show();
        }

        private void rmDresseur_Click(object sender, RoutedEventArgs e) {
            if (dataGridDresseur.SelectedItem != null) {
                if (MessageBox.Show("Confirmer la suppression ?", "Confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK) {
                    foreach (Dresseur d in dataGridDresseur.SelectedItems) {
                        BManager.getDresseur().Remove(d);
                    }
                    //Actualisation
                    this.Refresh_DataGridDresseur();
                }
            }
        }
        #endregion

        #region button_stade
        private void export_stade_Click(object sender, RoutedEventArgs e) {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Stades";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents |*.xml";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true) {
                string filename = dlg.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Stade>));
                TextWriter tw = new StreamWriter(filename);
                serializer.Serialize(tw, BManager.getStades());
                tw.Close();
            }
        }

        private void import_stade_Click(object sender, RoutedEventArgs e) {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Stades";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents |*xml";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true) {
                string filename = dlg.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Stade>));
                TextReader tr = new StreamReader(filename);
                try {
                    List<Stade> ls = (List<Stade>)serializer.Deserialize(tr);
                    tr.Close();

                    BManager.getStades().Clear();
                    BManager.getStades().AddRange(ls);
                }
                catch (InvalidOperationException err) {
                    MessageBox.Show("Fichier invalide.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                //Actualisation
                this.Refresh_DataGridStade();
            }
        }

        private void print_stade_Click(object sender, RoutedEventArgs e) {
            PrintDialog pDialog = new PrintDialog();
            pDialog.PageRangeSelection = PageRangeSelection.AllPages;
            pDialog.UserPageRangeEnabled = true;

            Nullable<Boolean> print = pDialog.ShowDialog();
            if (print == true) {
                FlowDocument doc = new FlowDocument();
                doc.ColumnWidth = 99999; //triche :x
                doc.FontFamily = new FontFamily("Arial");
                //Titre
                Paragraph par = new Paragraph(new Bold(new Underline(new Run("Rapport : liste des Stades"))));
                par.TextAlignment = TextAlignment.Center;
                par.FontSize = 24;
                doc.Blocks.Add(par);
                //Données
                //doc.LineHeight = 1; //Pourquoi ça colle le texte à gauche...
                foreach (Stade s in BManager.getStades()) {
                    Paragraph tmp = new Paragraph();
                    tmp.TextAlignment = TextAlignment.Left;
                    tmp = new Paragraph(new Run(s.ID + "  -  " + s.Nom + " : " + s.NbPlace + " places."));
                    doc.Blocks.Add(tmp);
                    tmp = new Paragraph(new Run(s.Element + "  -  " + s.Caract));
                    doc.Blocks.Add(tmp);
                    doc.Blocks.Add(new Paragraph(new Run("")));
                }
                IDocumentPaginatorSource idpSource = doc;
                pDialog.PrintDocument(idpSource.DocumentPaginator, "Rapport Stade");
            }
        }

        private void addStade_Click(object sender, RoutedEventArgs e) {
            AjoutStade win = new AjoutStade() {
                DataContext = this
            };
            win.Show();
        }

        private void rmStade_Click(object sender, RoutedEventArgs e) {
            if (dataGridStade.SelectedItem != null) {
                if (MessageBox.Show("Confirmer la suppression ?", "Confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK) {
                    foreach (Stade s in dataGridStade.SelectedItems) {
                        BManager.getStades().Remove(s);
                    }
                    //Actualisation
                    this.Refresh_DataGridStade();
                }
            }
        }
        #endregion

        private void MenuItemPokemon_Click(object sender, RoutedEventArgs e) {
            //cacher les autres use controls
            fiche_stade.Visibility = Visibility.Collapsed;
            fiche_dresseur.Visibility = Visibility.Collapsed;

            //Affiche le bon user control
            fiche_pokemon.Visibility = Visibility.Visible;
            fiche_pokemon.textBoxID.Text = ((Pokemon)dataGridPokemon.SelectedItem).ID.ToString();
            fiche_pokemon.textBoxNom.Text = ((Pokemon)dataGridPokemon.SelectedItem).Nom;
            fiche_pokemon.textBoxType.Text = ((Pokemon)dataGridPokemon.SelectedItem).Element.ToString();
            fiche_pokemon.textBoxVie.Text = ((Pokemon)dataGridPokemon.SelectedItem).Caract.Vie.ToString();
            fiche_pokemon.textBoxForce.Text = ((Pokemon)dataGridPokemon.SelectedItem).Caract.Force.ToString();
            fiche_pokemon.textBoxAgilite.Text = ((Pokemon)dataGridPokemon.SelectedItem).Caract.Agilite.ToString();
            fiche_pokemon.textBoxIntelligence.Text = ((Pokemon)dataGridPokemon.SelectedItem).Caract.Intelligence.ToString();
        }

        private void menuItemStade_Click(object sender, RoutedEventArgs e) {
            //cacher les autres use controls
            fiche_pokemon.Visibility = Visibility.Collapsed;
            fiche_dresseur.Visibility = Visibility.Collapsed;

            //Affiche le bon user control
            fiche_stade.Visibility = Visibility.Visible;
            fiche_stade.textBoxID.Text = ((Stade)dataGridStade.SelectedItem).ID.ToString();
            fiche_stade.textBoxNom.Text = ((Stade)dataGridStade.SelectedItem).Nom;
            fiche_stade.textBoxType.Text = ((Stade)dataGridStade.SelectedItem).Element.ToString();
            fiche_stade.textBoxVie.Text = ((Stade)dataGridStade.SelectedItem).Caract.Vie.ToString();
            fiche_stade.textBoxForce.Text = ((Stade)dataGridStade.SelectedItem).Caract.Force.ToString();
            fiche_stade.textBoxAgilite.Text = ((Stade)dataGridStade.SelectedItem).Caract.Agilite.ToString();
            fiche_stade.textBoxIntelligence.Text = ((Stade)dataGridStade.SelectedItem).Caract.Intelligence.ToString();
        }

        private void menuItemDresseur_Click(object sender, RoutedEventArgs e) {
            //cacher les autres use controls
            fiche_pokemon.Visibility = Visibility.Collapsed;
            fiche_stade.Visibility = Visibility.Collapsed;

            //Affiche le bon user control
            fiche_dresseur.Visibility = Visibility.Visible;
            fiche_dresseur.textBoxID.Text = ((Dresseur)dataGridDresseur.SelectedItem).ID.ToString();
            fiche_dresseur.textBoxNom.Text = ((Dresseur)dataGridDresseur.SelectedItem).Nom;

            Pokemon p = BManager.getPokemon().Where(x => x.ID == ((Dresseur)dataGridDresseur.SelectedItem).ID_Pokemon).FirstOrDefault();

            fiche_dresseur.pokemon.textBoxID.Text = p.ID.ToString();
            fiche_dresseur.pokemon.textBoxNom.Text = p.Nom;
            fiche_dresseur.pokemon.textBoxType.Text = p.Element.ToString();
            fiche_dresseur.pokemon.textBoxVie.Text = p.Caract.Vie.ToString();
            fiche_dresseur.pokemon.textBoxForce.Text = p.Caract.Force.ToString();
            fiche_dresseur.pokemon.textBoxAgilite.Text = p.Caract.Agilite.ToString();
            fiche_dresseur.pokemon.textBoxIntelligence.Text = p.Caract.Intelligence.ToString();
        }

        //private void dataGridMatch_Loaded(object sender, RoutedEventArgs e) {
        //    Binding binding = new Binding();
        //    binding.Path = new PropertyPath("Pokemon");
        //    binding.Source = typeof(Pokemon);
        //    BindingOperations.SetBinding(phase,null, binding);
        //}
    }
}
