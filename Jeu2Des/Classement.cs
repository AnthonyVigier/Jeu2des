using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu2Des
{
    public class Classement 
    {
        //Propriétés


        private List<Entree> JoueursEntres;



        //Constructeurs

        public Classement()
        {

            JoueursEntres = new List<Entree>();
            //this. _Entree = new Entree();

        }


        public Classement(Entree entree)
        {
            JoueursEntres = new List<Entree>();
            //this._Entree = entree;
        }


        //Méthodes

        public void AjouterEntree(string nom, int score)
        {
            
            JoueursEntres.Add(new Entree(score, nom));


        }

     

        public void AfficherClassement()
        {
            JoueursEntres.Sort();
            JoueursEntres.Reverse();
            foreach (Entree joueurs in JoueursEntres)
            {
                Console.WriteLine(joueurs);
            }

           
        }


        //Redéfinition

     

    }
}
