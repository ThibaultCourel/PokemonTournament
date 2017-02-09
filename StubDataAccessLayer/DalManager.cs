using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace StubDataAccessLayer
{
    public class DalManager {
        public List<Pokemon> ListPokemon { get; set; }
        public List<Dresseur> ListDresseur { get; set; }
        public List<Match> ListMatch { get; set; }
        public List<Caracteristique> ListCaractéristique { get; set; }
        public List<Stade> ListStade { get; set; }
        public List<Utilisateur> ListUtilisateur { get; set; }

        public DalManager() {
            ListPokemon = new List<Pokemon>();
            ListDresseur = new List<Dresseur>();
            ListMatch = new List<Match>();
            ListCaractéristique = new List<Caracteristique>();
            ListStade = new List<Stade>();
            ListUtilisateur = new List<Utilisateur>();

            //Ajout stub
            ListPokemon.Add(new Pokemon("Pikachu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Carapute", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Samlaleche", ETypeElement.Feu, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Vulvizard", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Dracaufeu", ETypeElement.Feu, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Reichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Pichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Racaillou", ETypeElement.Terre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Psychokwak", ETypeElement.Psy, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Tortank", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Majykarp", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Roucoul", ETypeElement.Air, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Ximun", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Fuyuchu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Jojo l'Aspicot", ETypeElement.Insecte, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon());
            ListPokemon.Add(new Pokemon("Vulvizard", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Dracaufeu", ETypeElement.Feu, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Reichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Pichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Racaillou", ETypeElement.Terre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Psychokwak", ETypeElement.Psy, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Tortank", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Majykarp", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Roucoul", ETypeElement.Air, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Ximun", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Fuyuchu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Vulvizard", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Dracaufeu", ETypeElement.Feu, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Reichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Pichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Racaillou", ETypeElement.Terre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Psychokwak", ETypeElement.Psy, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Tortank", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Majykarp", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Roucoul", ETypeElement.Air, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Ximun", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Fuyuchu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Jojo l'Aspicot", ETypeElement.Insecte, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Vulvizard", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Dracaufeu", ETypeElement.Feu, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Reichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Pichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Racaillou", ETypeElement.Terre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Psychokwak", ETypeElement.Psy, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Tortank", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Majykarp", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Roucoul", ETypeElement.Air, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Ximun", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Fuyuchu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Vulvizard", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Dracaufeu", ETypeElement.Feu, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Reichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Pichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Racaillou", ETypeElement.Terre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Psychokwak", ETypeElement.Psy, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Tortank", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Majykarp", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Roucoul", ETypeElement.Air, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Ximun", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Fuyuchu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Jojo l'Aspicot", ETypeElement.Insecte, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Vulvizard", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Dracaufeu", ETypeElement.Feu, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Reichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Pichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Racaillou", ETypeElement.Terre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Psychokwak", ETypeElement.Psy, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Tortank", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Majykarp", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Roucoul", ETypeElement.Air, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Ximun", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Fuyuchu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Jojo l'Aspicot", ETypeElement.Insecte, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Vulvizard", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Dracaufeu", ETypeElement.Feu, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Reichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Pichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Racaillou", ETypeElement.Terre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Psychokwak", ETypeElement.Psy, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Tortank", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Majykarp", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Roucoul", ETypeElement.Air, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Ximun", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Fuyuchu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Jojo l'Aspicot", ETypeElement.Insecte, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Vulvizard", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Dracaufeu", ETypeElement.Feu, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Reichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Pichu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Racaillou", ETypeElement.Terre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Psychokwak", ETypeElement.Psy, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Tortank", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Majykarp", ETypeElement.Eau, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Roucoul", ETypeElement.Air, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Ximun", ETypeElement.Plante, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Fuyuchu", ETypeElement.Tonnerre, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Jojo l'Aspicot", ETypeElement.Insecte, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Jojo l'Aspicot", ETypeElement.Insecte, new Caracteristique(10, 10, 10, 10)));
            ListPokemon.Add(new Pokemon("Jojo l'Aspicot", ETypeElement.Insecte, new Caracteristique(10, 10, 10, 10)));

            ListStade.Add(new Stade("Isima", 2000));
            ListStade.Add(new Stade("Sigma", 500));
            ListStade.Add(new Stade("Randomland", 6666));
            ListStade.Add(new Stade("Bubulle", 4242));
            ListStade.Add(new Stade("Nagrand", 12500));
            ListStade.Add(new Stade("Polytech", 17200));

            ListDresseur.Add(new Dresseur("Sacha", ListPokemon[0]));
            ListDresseur.Add(new Dresseur("Pierre", ListPokemon[1]));
            ListDresseur.Add(new Dresseur("Paul", ListPokemon[2]));
            ListDresseur.Add(new Dresseur("Ondine", ListPokemon[3]));
            ListDresseur.Add(new Dresseur("Sacha", ListPokemon[4]));
            ListDresseur.Add(new Dresseur("Pierre", ListPokemon[5]));
            ListDresseur.Add(new Dresseur("Paul", ListPokemon[6]));
            ListDresseur.Add(new Dresseur("Ondine", ListPokemon[7]));
            ListDresseur.Add(new Dresseur("Sacha", ListPokemon[8]));
            ListDresseur.Add(new Dresseur("Pierre", ListPokemon[9]));
            ListDresseur.Add(new Dresseur("Paul", ListPokemon[10]));
            ListDresseur.Add(new Dresseur("Ondine", ListPokemon[11]));
            ListDresseur.Add(new Dresseur("Sacha", ListPokemon[12]));
            ListDresseur.Add(new Dresseur("Pierre", ListPokemon[13]));
            ListDresseur.Add(new Dresseur("Paul", ListPokemon[14]));
            ListDresseur.Add(new Dresseur("Ondine", ListPokemon[15]));

            ListUtilisateur.Add(new Utilisateur("aaa", "aaa"));
            ListUtilisateur.Add(new Utilisateur("Thibault", "Courel", "a", "a"));

            ListMatch.Add(new Match(-1, EPhaseTournoi.Finale, ListDresseur[0], ListDresseur[1], ListStade[0]));
            ListMatch.Add(new Match(-1, EPhaseTournoi.DemiFinale, ListDresseur[2], ListDresseur[3], ListStade[1]));
            ListMatch.Add(new Match(-1, EPhaseTournoi.QuartFinale, ListDresseur[4], ListDresseur[5], ListStade[2]));
            ListMatch.Add(new Match(-1, EPhaseTournoi.HuitiemeFinale, ListDresseur[6], ListDresseur[7], ListStade[3]));
        }

        public Utilisateur GetUtilisateurByLogin(String login) {
            return ListUtilisateur.Where(x => x.Login.ToLower() == login.ToLower()).FirstOrDefault();
        }
    }
}
