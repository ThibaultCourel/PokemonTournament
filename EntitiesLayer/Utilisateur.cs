using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
    public class Utilisateur {
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }

        public Utilisateur(String log, String pass) {
            Nom = "SANS NOM";
            Prenom = "SANS PRENOM";
            Login = log;
            Password = pass;
        }

        public Utilisateur(String nom, String prenom, String log, String pass) {
            Nom = nom;
            Prenom = prenom;
            Login = log;
            Password = pass;
        }
    }
}
