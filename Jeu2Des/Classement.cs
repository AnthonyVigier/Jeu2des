using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;

namespace Jeu2Des
{   
   [Serializable]
    public class Classement

    {
        //Propriétés
        private List<Entree> _JoueursEntres;

        public List<Entree> JoueursEntres
            {
                get { return _JoueursEntres; }
                set { _JoueursEntres = value; }
            }

        //Constructeurs

        public Classement()
        {
            _JoueursEntres = new List<Entree>();          
        }


        //Méthodes

        public void AjouterEntree(string nom, int score)
        {
            _JoueursEntres.Add(new Entree(score, nom));
        }

     
        public void AfficherClassement()
        {
            _JoueursEntres.Sort();
            _JoueursEntres.Reverse();

            foreach (Entree joueurs in _JoueursEntres)
            {
                Console.WriteLine(joueurs);
            }
        }

       
        public void AfficherClassement(int n)
        {
            Console.WriteLine("\n***********************************Top 3**************************************");
            Console.WriteLine();
            _JoueursEntres.Sort();
            _JoueursEntres.Reverse();
          


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1 +" "+ _JoueursEntres[i].Nom + " " + _JoueursEntres[i].Score);
            }
        }

        //Redéfinition
       


    }
}
