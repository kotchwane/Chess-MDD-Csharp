using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    public class Echiquier {

        public Partie partie;
        public Case[,] cases;

        public Echiquier(Partie p) {
            this.partie = p;
            this.cases = new Case[8,8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    this.cases[i, j] = new Case(null, i, j);
        }
        
    }
}
