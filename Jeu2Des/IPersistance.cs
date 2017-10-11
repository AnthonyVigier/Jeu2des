using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2Des
{
    public interface IPersistance
    {
        void SaveClassement(Object obj);
        object LoadClassement(Type type);

        
    }
}
