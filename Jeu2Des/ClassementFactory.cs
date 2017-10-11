using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu2Des
{
    public static class ClassementFactory
    {
        public static IPersistance CreerPersistance(TypePersistance type)
        {

            if (type == TypePersistance.Binaire)
            {
                return new ClassementBinaire();
            }

            if (type == TypePersistance.Xml)
            {
                return new ClassementXML();
            }
                return new ClassementJSON();
            


        }
    }
}
