using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
    public class Dresseur : EntityObject {
        public String Nom { get; set; }
        public int ID_Pokemon { get; set; }
        public String Nom_Pokemon { get; set; }
        public ETypeElement Element_Pokemon { get; set; }

        public Dresseur() {
            Nom = "SANS NOM";
            ID_Pokemon = -1;
            Nom_Pokemon = "NO_POKEMON";
            Element_Pokemon = ETypeElement.Incolore;
        }

        public Dresseur(String nom, Pokemon pokemon) {
            Nom = nom;
            ID_Pokemon = pokemon.ID;
            Nom_Pokemon = pokemon.Nom;
            Element_Pokemon = pokemon.Element;
        }

        public override string ToString() {
            return "Dresseur : " + Nom + " de Pokemon : " + Nom_Pokemon + " (" + Element_Pokemon + ")";
        }
    }
}
