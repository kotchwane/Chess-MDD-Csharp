using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    public class Case {

        // attributs
        public int x, y;

        public Piece piece;
        public Case newCase;


        // associations

        public Case(Piece piece, int x, int y) {
            this.piece = piece;
            this.x = x;
            this.y = y;
        }


        // methodes
        public void Link(Piece newPiece) {
            this.piece = newPiece;
            newPiece.position = this;
            this.piece.joueur.partie.vue.ActualiserCase(x, y, newPiece.info);
        }

        public void Unlink(Piece p) {
            p.position = null;
        }
    }
}
