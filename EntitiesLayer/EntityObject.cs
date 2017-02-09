using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
   abstract public class EntityObject {
        public int ID { get; set; }
        private static int compteur = 0;

        public EntityObject() {
            this.ID = compteur++;
        }
    }
}
