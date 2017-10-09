using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Jeu2Des
{
    [Serializable]
    public class ClassementXML : Classement
    {
        //Properties
        //constructeurs

        public ClassementXML() : base(){}
        //méthodes

      
        //méthodes redéfinies 

        public override void SaveClassement()
        {
            Stream fichier = File.Create("sav.xml");
            XmlSerializer serializer = new XmlSerializer(JoueursEntres.GetType());
            serializer.Serialize(fichier, JoueursEntres);
            fichier.Close();
        }

        public override void LoadClassement()
        {
            if (File.Exists("sav.xml"))
            {
                Stream fichier = File.OpenRead("sav.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(List<Entree>));
                Object obj = serializer.Deserialize(fichier);
                JoueursEntres = (List<Entree>)obj;
                fichier.Close();
            }
        }
    }
}

