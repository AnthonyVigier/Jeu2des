using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Jeu2Des
{
    [Serializable]
    public class ClassementXML : IPersistance
    {
        //Properties
        //constructeurs

     
        //méthodes

      
        //méthodes redéfinies 

        public  void SaveClassement(Object objetsauve)
        {

            Stream fichier = File.Create("sav.xml");
            XmlSerializer serializer = new XmlSerializer(objetsauve.GetType());
            serializer.Serialize(fichier,objetsauve);
            fichier.Close();
        }

        public Object LoadClassement(Type type)
        {
            Object obj = null;
            if (File.Exists("sav.xml"))
            {
                Stream fichier = File.OpenRead("sav.xml");
                XmlSerializer serializer = new XmlSerializer(type);
                obj = serializer.Deserialize(fichier);
                fichier.Close();
            }
            return obj;

        }
    }
}

