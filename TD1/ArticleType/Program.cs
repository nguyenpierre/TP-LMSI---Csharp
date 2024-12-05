using System;
using System.Linq;
using System.Text;


namespace AT
{ 
        class Program
        {
            static void Main(string[] args)
            {
                // Création de quelques articles typés
                ArticleType article1 = new ArticleType("Pomme", 1.20m, 50, TypeArticle.Alimentaire);
                ArticleType article2 = new ArticleType("Savon", 2.50m, 20, TypeArticle.Droguerie);
                ArticleType article3 = new ArticleType("T-shirt", 15.99m, 10, TypeArticle.Habillement);

                // Affichage des articles
                Console.WriteLine("Articles initiaux :");
                article1.Afficher();
                article2.Afficher();
                article3.Afficher();

                // Modification des quantités
                Console.WriteLine("\nModification des quantités...");
                article1.Ajouter(10);
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

                Console.WriteLine("Entrez le type de l'article (Alimentaire, Droguerie, Habillement, Loisir) : ");
                string typeInput = Console.ReadLine();

                // Conversion de la chaîne saisie en valeur d'énumération
                TypeArticle type = (TypeArticle)Enum.Parse(typeof(TypeArticle), typeInput, true);

                ArticleType nouvelArticle = new ArticleType(nom, prix, quantite, type);

                // Affichage du nouvel article
                Console.WriteLine("\nNouvel article créé :");
                nouvelArticle.Afficher();

                // Empêche la fermeture immédiate de la console
                Console.WriteLine("\nAppuyez sur une touche pour fermer...");
                Console.ReadLine();
            }
        }
 }


