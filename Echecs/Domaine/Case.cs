using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    public class Case
    {
        // attributs
        

        // associations
        

        // methodes
        public void Link(Piece newPiece) {
            // 1. Deconnecter newPiece de l'ancienne case
            // 2. Connecter newPiece à cette case
            newPiece.position = this;
        }

        public void Unlink(Piece p) {
            p.position = null;
        }
    }
}
