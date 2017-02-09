using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
    public class Tournoi : EntityObject {
        public String Nom;
        public Match[] Matchs { get; set; }

        public Tournoi() {
            Nom = "SANS NOM";
        }

        public Tournoi(String nom) {
            Nom = nom;
        }
    }
}
