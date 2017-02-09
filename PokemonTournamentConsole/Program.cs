using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer;
using EntitiesLayer;

namespace PokemonTournamentConsole
{
    class Program {
        static void Main(string[] args) {
            BusinessManager BManager = new BusinessManager();
            foreach (Pokemon p in BManager.getPokemonByElem(ETypeElement.Terre)) {
                Console.WriteLine(p);
            }
            foreach (Pokemon p in BManager.getPokemonByElem(ETypeElement.Plante)) {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
