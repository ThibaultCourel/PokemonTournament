using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
    public class Caracteristique {
        public int Vie { get; set; }
        public int Force { get; set; }
        public int Agilite { get; set; }
        public int Intelligence { get; set; }

        public Caracteristique() {
            Vie = 0;
            Force = 0;
            Agilite = 0;
            Intelligence = 0;
        }

        public Caracteristique(int vie, int force, int agilite, int intelligence) {
            Vie = vie;
            Force = force;
            Agilite = agilite;
            Intelligence = intelligence;
        }

        public override string ToString() {
            return "Vie : " + Vie + " | Force : " + Force + " | Agilite : " + Agilite + " | Intelligence : " + Intelligence;
        }
    }
}
