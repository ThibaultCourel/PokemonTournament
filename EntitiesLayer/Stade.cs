using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
    public class Stade : EntityObject {
        public String Nom { get; set; }
        public int NbPlace { get; set; }
        public ETypeElement Element { get; set; }
        private Caracteristique _caract;
        public Caracteristique Caract {
            get {
                return _caract;
            }
            set {
                _caract = value;
            }
        }

        public Stade() {
            Nom = "SANS NOM";
            NbPlace = 1000;
            _caract = new Caracteristique(0, 0, 0, 0);
        }

        public Stade(String nom, int nbPlace) {
            Nom = nom;
            //Intervalle nombre de place
            if (nbPlace < 1000) {
                NbPlace = 1000;
            } else if (nbPlace > 25000) {
                NbPlace = 25000;
            } else {
                NbPlace = nbPlace;
            }
            Element = ETypeElement.Incolore;
            _caract = new Caracteristique(0, 0, 0, 0);
        }

        public Stade(String nom, int nbPlace, ETypeElement elem, Caracteristique caract) {
            Nom = nom;
            NbPlace = nbPlace;
            Element = elem;
            _caract = caract;
        }

        public override string ToString() {
            return "Stade : " + Nom;
        }
    }
}
