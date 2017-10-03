using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu2Des
{
    public class Entree
    {
        //Propriétés

        private string _Nom;

        public string Nom
        {
            get { return _Nom;}
        }



        private int _Score;

        public int Score
        {
            get { return _Score;}
        }


        //Constructeurs

        public Entree(string nom, int score)
        {
            this._Nom = nom;
            this._Score = score;
        }


        public Entree()
        {
            this._Nom = "Toto";
            this._Score = 0;
        }
        //Méthodes
        //Redéfinition

    }
}
