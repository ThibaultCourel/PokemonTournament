using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;
using System.Data;
using System.Data.SqlClient;

namespace BDDAccessLayer
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

            //Ajout BDD
            //STRING CONNEXION :Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\Thibault\Documents\Visual Studio 2015\Projects\PokemonTournamentConsole\BDD\bdd_pokemon.mdf";Integrated Security=True;Connect Timeout=30
            InitializeDataBase();
        }

        private ETypeElement ConvertStringToElem(String elem) {
            switch (elem) {
                case "Eau":
                    return ETypeElement.Eau;
                case "Feu":
                    return ETypeElement.Feu;
                case "Terre":
                    return ETypeElement.Terre;
                case "Tonnerre":
                    return ETypeElement.Tonnerre;
                case "Insecte":
                    return ETypeElement.Insecte;
                case "Plante":
                    return ETypeElement.Plante;
                case "Psy":
                    return ETypeElement.Psy;
                case "Air":
                    return ETypeElement.Air;
                case "Incolore":
                    return ETypeElement.Incolore;
                default:
                    return ETypeElement.Incolore;
            }
        }

        public DataTable Connexion(String request) {
            DataTable res = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Thibault\\Documents\\PokemonTournamentConsole\\BDD\\bdd_pokemon.mdf;Integrated Security=True;Connect Timeout=30")) {
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(res);
            }
            return res;
        }

        private void InitializeDataBase() {
            InitializePokemon();
            InitializeDresseur();
            InitializeMatch();
            InitializeStade();
            InitializeUtilisateur();
        }

        private void InitializePokemon() {
            DataTable resRequete = Connexion("SELECT * FROM dbo.POKEMON;");
            foreach(DataRow row in resRequete.Rows) {
                Object[] rowDetails = row.ItemArray;
                Pokemon p = new Pokemon((String)rowDetails[1], (ETypeElement)ConvertStringToElem((String)rowDetails[2]),
                                new Caracteristique((int)rowDetails[3], (int)rowDetails[4], (int)rowDetails[5], (int)rowDetails[6]));
                p.ID = (int)rowDetails[0]; //Permet d'avoir le meme id entre l'objet et la DB
                ListPokemon.Add(p);
            }
        }

        private void InitializeUtilisateur() {
            DataTable resRequete = Connexion("SELECT * FROM dbo.UTILISATEUR");
            foreach (DataRow row in resRequete.Rows) {
                Object[] rowDetails = row.ItemArray;
                ListUtilisateur.Add(new Utilisateur((String)rowDetails[0], (String)rowDetails[1], (String)rowDetails[2], (String)rowDetails[3]));
            }
        }

        private void InitializeStade() {
            DataTable resRequete = Connexion("SELECT * FROM dbo.STADE");
            foreach (DataRow row in resRequete.Rows) {
                Object[] rowDetails = row.ItemArray;
                Stade s = new Stade((String)rowDetails[1], (int)rowDetails[2], (ETypeElement)ConvertStringToElem((String)rowDetails[3]),
                          new Caracteristique((int)rowDetails[4], (int)rowDetails[5], (int)rowDetails[6], (int)rowDetails[7]));
                s.ID = (int)rowDetails[0]; //Permet d'avoir le meme id entre l'objet et la DB
                ListStade.Add(s);
            }
        }

        private void InitializeDresseur() {
            DataTable resRequete = Connexion("SELECT * FROM dbo.DRESSEUR");
            foreach (DataRow row in resRequete.Rows) {
                Object[] rowDetails = row.ItemArray;

                int a = (int)rowDetails[0];

                DataTable resPokemon = Connexion("SELECT * FROM dbo.POKEMON JOIN dbo.DRESSEUR ON dbo.POKEMON.ID="+(int)rowDetails[2] + ";");
                Object[] rowDetailPokemon = resPokemon.Rows[0].ItemArray; //Chope le premier (normal) pokemon de la liste
                Pokemon p = new Pokemon((String)rowDetailPokemon[1], (ETypeElement)ConvertStringToElem((String)rowDetailPokemon[2]),
                                new Caracteristique((int)rowDetailPokemon[3], (int)rowDetailPokemon[4], (int)rowDetailPokemon[5], (int)rowDetailPokemon[6]));
                p.ID = (int)rowDetailPokemon[0];
                Dresseur d = new Dresseur((String)rowDetails[1], p);
                d.ID = (int)rowDetails[0]; //Permet d'avoir le meme id entre l'objet et la DB
                ListDresseur.Add(d);                
            }
        }

        private void InitializeMatch() {
            DataTable resRequete = Connexion("SELECT * FROM dbo.MATCH");
            foreach (DataRow row in resRequete.Rows) {
                Object[] rowDetails = row.ItemArray;
                ListMatch.Add(new Match());
            }
        }

        public Utilisateur GetUtilisateurByLogin(String login) {
            return ListUtilisateur.Where(x => x.Login.ToLower() == login.ToLower()).FirstOrDefault();
        }
    }
}
