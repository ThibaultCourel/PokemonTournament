using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using StubDataAccessLayer;
using EntitiesLayer;

namespace BusinessLayer
{
    public class BusinessManager {
        //Stub
        static private StubDataAccessLayer.DalManager Manager = new StubDataAccessLayer.DalManager();

        //BDD
        //static private BDDAccessLayer.DalManager Manager = new BDDAccessLayer.DalManager();
        public BusinessManager() {}

        public bool CheckConnexion(String login, String password) {
            Utilisateur user = Manager.GetUtilisateurByLogin(login);
            if (user != null && user.Password == password) {
                return true;
            }
            return false;
        }

        public List<Pokemon> getPokemon() {
            return Manager.ListPokemon;
        }

        public List<Pokemon> getPokemonByElem(ETypeElement elem) {
            return Manager.ListPokemon.Where(x => x.Element == elem).ToList();
        }

        public List<Dresseur> getDresseur() {
            return Manager.ListDresseur;
        }

        public List<Match> getMatchs() {
            return Manager.ListMatch;
        }

        public List<Stade> getStades() {
            return Manager.ListStade;
        }

        public List<Stade> getStadeByPlaceMinimum(int mini) {
            return Manager.ListStade.Where(x => x.NbPlace >= mini).ToList();
        } 

        public List<Stade> getStadeByPlaceMaximum(int maxi) {
            return Manager.ListStade.Where(x => x.NbPlace <= maxi).ToList();
        }
    }
}
