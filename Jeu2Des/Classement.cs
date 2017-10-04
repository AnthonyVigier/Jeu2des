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

        }


        //public Classement(Entree entree)
        //{
        //    JoueursEntres = new List<Entree>();           
        //}


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

       
        public void AfficherClassement(int n)
        {
            int cpt = 0;

            Console.WriteLine("\n***********************************Top 3**************************************");
            Console.WriteLine();
            JoueursEntres.Sort();
            JoueursEntres.Reverse();
          

            foreach (Entree joueurs in JoueursEntres)
            {
                if (cpt == n)
                {
                    break;
                }

                Console.WriteLine(joueurs);
                cpt++;
            }
        }

        //Redéfinition
        public override string ToString()
        {
            return base.ToString() + JoueursEntres;
        }


    }
}
