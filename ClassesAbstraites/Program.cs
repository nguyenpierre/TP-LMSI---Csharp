using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLABS;

namespace CLABS
{
   class Program
    {
        static void Main(string[] args)
        {
            // Création d'une liste de publications
            List<Publication> publications = new List<Publication>
        {
            new Livre("Le Petit Prince", 15.99m, "123456789", 96),
            new Disque("Thriller", 20.00m, "Epic Records"),
            new Video("Inception", 12.50m, 148)
        };

            // Parcours de la liste et affichage des détails de chaque publication
            foreach (var publication in publications)
            {
                publication.PublishDetails();
            }
            // Empêche la fermeture immédiate de la console
            Console.WriteLine("Appuyez sur une touche pour fermer...");
            Console.ReadLine();
        }

    }

}
