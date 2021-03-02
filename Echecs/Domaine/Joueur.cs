﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    public class Joueur
    {
        // attributs
        public CouleurCamp couleur;

        // associations
        public Partie partie;
        public List<Piece> pieces = new List<Piece>();

        // methodes
        public Joueur(Partie partie, CouleurCamp couleur)
        {
            this.couleur = couleur;
            this.partie = partie;

            // TODO : creation des pieces du joueur
            pieces.Add( new Dame(this) );
        }

        public void PlacerPieces(Echiquier echiquier) {
            if (couleur == CouleurCamp.Noire) {
                echiquier.cases[3, 0].Link(pieces[0]);
            } else {
                echiquier.cases[3, 7].Link(pieces[0]);
            }
        }
    }
}
