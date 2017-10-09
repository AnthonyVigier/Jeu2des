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
    public class ClassementBinaire : Classement
    {
        //Properties
        //constructeurs

        public ClassementBinaire() : base()
        {

        }
        //méthodes
        //méthodes redéfinies

        public override void SaveClassement()
        {
            Stream fichier = File.Create("savClassement.txt");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fichier, JoueursEntres);
            fichier.Close();
        }

        public override void LoadClassement()
        {
            if (File.Exists("savClassement.txt"))
            {
                Stream fichierLoad = File.OpenRead("savClassement.txt");
                BinaryFormatter serialLoad = new BinaryFormatter();
                Object obj = serialLoad.Deserialize(fichierLoad);
                JoueursEntres = (List<Entree>)obj;
                fichierLoad.Close();
            }
        }
    }
}
