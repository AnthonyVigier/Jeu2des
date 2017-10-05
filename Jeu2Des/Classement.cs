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
    [DataContract]
    public class Classement

    {
        //Propriétés
        private List<Entree> _JoueursEntres;

        [DataMember]
        public List<Entree> Joueursentres
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

        public void SaveClassement()
        {
            //*********************Binaire****************************
            //Stream fichier = File.Create("savClassement.txt");
            //BinaryFormatter serializer = new BinaryFormatter();
            //serializer.Serialize(fichier, JoueursEntres);
            //fichier.Close();

            //***********************XML******************************
            //Stream fichier = File.Create("sav.xml");
            //XmlSerializer serializer = new XmlSerializer(_JoueursEntres.GetType());            
            //serializer.Serialize(fichier,_JoueursEntres);
            //fichier.Close();

            //**********************JSON*****************************
            Stream fichier = File.Create("sav.json");
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(_JoueursEntres.GetType());
            serializer.WriteObject(fichier,_JoueursEntres);
            fichier.Close();
        }


        public void LoadClassement()
        {

            //*********************Binaire Load*******************************
            //if (File.Exists("savClassement.txt"))
            //   {
            //       Stream fichierLoad = File.OpenRead("savClassement.txt");
            //       BinaryFormatter serialLoad = new BinaryFormatter();
            //       Object obj = serialLoad.Deserialize(fichierLoad);
            //       _JoueursEntres = (List<Entree>)obj;
            //       fichierLoad.Close();
            //   }


            //*******************XML Load************************************
            //if (File.Exists("sav.xml"))
            //{

            //    Stream fichier = File.OpenRead("sav.xml");
            //    XmlSerializer serializer = new XmlSerializer(typeof(List<Entree>));
            //    Object obj = serializer.Deserialize(fichier);
            //    _JoueursEntres = (List<Entree>)obj;
            //    fichier.Close();
            //}

            if (File.Exists("sav.json"))
            {
                Stream fichier = File.OpenRead("sav.json");
                DataContractJsonSerializer serializer = 
                new DataContractJsonSerializer(typeof(List<Entree>));
                Joueursentres = (List<Entree>)serializer.ReadObject(fichier);

                fichier.Close();
            }

        }
        //Redéfinition
        public override string ToString()
        {
            return base.ToString() + _JoueursEntres;
        }


    }
}
