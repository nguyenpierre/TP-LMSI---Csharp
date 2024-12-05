using System;
using System.Linq;
using System.Text;

namespace Article
{
     class Program
        {
            static void Main(string[] args)
            {
                // Création de quelques articles
                Article article1 = new Article("Stylo", 1.50m, 10);
                Article article2 = new Article("Cahier", 2.75m, 20);
                Article article3 = new Article("Gomme", 0.80m, 30);

                // Affichage des articles
                Console.WriteLine("Articles initiaux :");
                article1.Afficher();
                article2.Afficher();
                article3.Afficher();

                // Modification des quantités
                Console.WriteLine("\nModification des quantités...");
                article1.Ajouter(5);
                article2.Retirer(5);

                // Affichage des articles après modification
                Console.WriteLine("\nArticles après modification :");
                article1.Afficher();
                article2.Afficher();
                article3.Afficher();

                // Création d'un nouvel article via saisie utilisateur
                Console.WriteLine("\nCréation d'un nouvel article par l'utilisateur :");
                Console.Write("Entrez le nom de l'article : ");
                string nom = Console.ReadLine();

                Console.Write("Entrez le prix de l'article : ");
                decimal prix = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Entrez la quantité de l'article : ");
                int quantite = int.Parse(Console.ReadLine());

                Article nouvelArticle = new Article(nom, prix, quantite);

                // Affichage du nouvel article
                Console.WriteLine("\nNouvel article créé :");
                nouvelArticle.Afficher();

                // Empêche la fermeture immédiate de la console
                Console.WriteLine("\nAppuyez sur une touche pour fermer...");
                Console.ReadLine();
            }
        }
 }


