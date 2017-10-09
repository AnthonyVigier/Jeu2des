using Jeu2Des;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteurNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Jeu j1 = new Jeu(3);

            j1.JouerPartie("Grooth");
            j1.JouerPartie("Peter Parker");
            j1.JouerPartie("Iron man");
            j1.JouerPartie("Captain America");
            j1.JouerPartie("Thor");
            j1.JouerPartie("Dead Pool");
            j1.JouerPartie("Hulk");
            j1.JouerPartie("Ant Man");

            Console.WriteLine();
            Console.WriteLine("*******************************Classement******************************");
            Console.WriteLine();

            j1.VoirClassement();

            j1.Quitter();
            Console.ReadKey();

        }
    }
}
