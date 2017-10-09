using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu2Des
{
    public static class ClassementFactory
    {
        public static Classement CreateClassement(int choix)
        {

            if (choix == 1)
            {
                return new ClassementBinaire();
            }

            else if (choix == 2)
            {
                return new ClassementXML();
            }

            else 
            {
                return  new ClassementJSON();
            }

            
        }
    }
}
