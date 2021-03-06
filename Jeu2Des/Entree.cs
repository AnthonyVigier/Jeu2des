﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Jeu2Des
{
    [Serializable]
    [DataContract]
    public class Entree : IComparable<Entree>
    {
        //Propriétés

        private string _Nom;

        [DataMember]
        public string Nom
        {
            get { return _Nom;}
            set { _Nom = value; }
        }

        private int _Score;

        [DataMember]
        public int Score
        {
            get { return _Score;}
            set { _Score = value; }
        }


        //Constructeurs

        public Entree(int score, string nom)
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
        public override string ToString()
        { 
            return "Nom : " + Nom + " Score : " + Score ;
        }

      
        public int CompareTo(Entree other)
        {
            return this.Score.CompareTo(other.Score);
        }
    }
}
