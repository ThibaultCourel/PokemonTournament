using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
    public class Pokemon : EntityObject {
        public String Nom { get; set; }
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

        public Pokemon() {
            Nom = "SANS NOM";
            Element = ETypeElement.Incolore;
            _caract = new Caracteristique(0, 0, 0, 0);
        }

        public Pokemon(String nom, ETypeElement elem, Caracteristique caract) {
            Nom = nom;
            Element = elem;
            Caract = caract;
        }

        public override string ToString() {
            return "Pokemon : " + Nom + " | Element : " + Element;
        }
    }
}
