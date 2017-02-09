using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
    public class Match : EntityObject {
        public int IdPokemonVainqueur { get; set; }
        public EPhaseTournoi PhaseTournoi { get; set; }
        public Dresseur Dresseur1 { get; set; }
        public Dresseur Dresseur2 { get; set; }
        public Stade Arene { get; set; }

        public Match() {
            IdPokemonVainqueur = -1;
            PhaseTournoi = EPhaseTournoi.HuitiemeFinale;
            Dresseur1 = null;
            Dresseur2 = null;
            Arene = null;
        }

        public Match(int idWinner, EPhaseTournoi phase, Dresseur d1, Dresseur d2, Stade stade) {
            IdPokemonVainqueur = idWinner;
            PhaseTournoi = phase;
            Dresseur1 = d1;
            Dresseur2 = d2;
            Arene = stade;
        }

        public override string ToString() {
            return "Match : " + Dresseur1.Nom + " VS " + Dresseur2.Nom;
        }
    }
}
