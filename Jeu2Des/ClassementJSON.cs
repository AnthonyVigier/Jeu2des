using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Jeu2Des
{
    public class ClassementJSON : IPersistance
    {
        //constructeurs
  
        //méthodes

        //méthodes redéfinies

        public void SaveClassement(Object objetSauve)
        {
            
            Stream fichier = File.Create("sav.json");
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(objetSauve.GetType());
            serializer.WriteObject(fichier,objetSauve);
            fichier.Close();
        }


        public Object LoadClassement(Type type)
        {
            Object obj = null;
            if (File.Exists("sav.json"))
            {
               
                FileStream fichier = File.OpenRead("sav.json");
                DataContractJsonSerializer serializer =
                new DataContractJsonSerializer(type);
                obj = (Classement)serializer.ReadObject(fichier);
                fichier.Close();
            }

            return obj;
        }


    }
}
