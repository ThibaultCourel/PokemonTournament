﻿using System;
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

namespace PokemonTournamentWPF {
    /// <summary>
    /// Logique d'interaction pour CtrlStade.xaml
    /// </summary>
    public partial class CtrlStade : UserControl {
        public CtrlStade() {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e) {
            this.Visibility = Visibility.Collapsed;
        }

    }
}
