using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Jeu2Des
{
    public class ClassementJSON : Classement
    {
        //constructeurs
        public ClassementJSON() : base(){}

        
        //méthodes

     
        //méthodes redéfinies

        public override void SaveClassement()
        {
            Stream fichier = File.Create("sav.json");
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(JoueursEntres.GetType());
            serializer.WriteObject(fichier, JoueursEntres);
            fichier.Close();
        }


        public override void LoadClassement()
        {
            if (File.Exists("sav.json"))
            {
                Stream fichier = File.OpenRead("sav.json");
                DataContractJsonSerializer serializer =
                new DataContractJsonSerializer(typeof(List<Entree>));
                JoueursEntres = (List<Entree>)serializer.ReadObject(fichier);
                fichier.Close();
            }
        }


    }
}
