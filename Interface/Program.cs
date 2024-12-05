using INF;
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace INF { 
class Program
{
    static void Main(string[] args)
    {
        // Création d'une liste d'articles
        List<Article> articles = new List<Article>
        {
            new Livre("Le Petit Prince", 10.99m, "123456789", 120),
            new Disque("Album Rock", 15.50m, "RockLabel"),
            new Video("Film Action", 20.00m, 120)
        };

        // Parcourir les articles et calculer le coût de location pour ceux qui implémentent IRentable
        foreach (var article in articles)
        {
            Console.WriteLine($"Article : {article.Designation}");
            article.Acheter();

            if (article is IRentable rentable)
            {
                Console.WriteLine($"Coût de location : {rentable.CalculateRent():C}");
            }
            else
            {
                Console.WriteLine("Cet article n'est pas louable.");
            }

            Console.WriteLine();
        }

        // Empêche la fermeture immédiate de la console
        Console.WriteLine("Appuyez sur une touche pour fermer...");
        Console.ReadLine();
    }
}

}


