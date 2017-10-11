using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Jeu2Des
{
   [Serializable]
    public class ClassementBinaire : IPersistance
    {
        //Properties
        //constructeurs

        public ClassementBinaire() : base()
        {

        }
        //méthodes
        //méthodes redéfinies

       
        public void SaveClassement(Object objetsauve)
        {
            Stream fichier = File.Create("savClassement.txt");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fichier, objetsauve);
            fichier.Close();
        }

        public Object LoadClassement(Type type)
        {

            Object obj = null;
            if (File.Exists("savClassement.txt"))
            {
                Stream fichierLoad = File.OpenRead("savClassement.txt");
                BinaryFormatter serialLoad = new BinaryFormatter();
                obj = serialLoad.Deserialize(fichierLoad);
                fichierLoad.Close();
            }

            return obj;
            
        }
    }
}
