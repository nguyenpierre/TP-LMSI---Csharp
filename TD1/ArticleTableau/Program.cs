using System;
using System.Linq;
using System.Text;



namespace AT
{
   
        class Program
        {
            static void Main(string[] args)
            {
                // Création d'un tableau de 3 articles typés
                ArticleType[] articles = new ArticleType[3];

                // Initialisation des articles
                articles[0] = new ArticleType("Pomme", 1.20m, 50, TypeArticle.Alimentaire);
                articles[1] = new ArticleType("Savon", 2.50m, 20, TypeArticle.Droguerie);
                articles[2] = new ArticleType("T-shirt", 15.99m, 10, TypeArticle.Habillement);

                // Affichage des articles initialisés
                Console.WriteLine("Articles initiaux :");
                foreach (var article in articles)
                {
                    article.Afficher();
                }

                // Manipulation du tableau : Ajout et retrait de quantités
                Console.WriteLine("\nModification des quantités...");
                articles[0].Ajouter(10); // Ajouter 10 à l'article "Pomme"
                articles[1].Retirer(5);  // Retirer 5 à l'article "Savon"
                articles[2].Ajouter(3);  // Ajouter 3 à l'article "T-shirt"

                // Affichage des articles après modification
                Console.WriteLine("\nArticles après modification :");
                foreach (var article in articles)
                {
                    article.Afficher();
                }

                // Ajout d'un nouvel article par l'utilisateur
                Console.WriteLine("\nAjout d'un nouvel article par l'utilisateur :");
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

                // Ajouter cet article dans un tableau agrandi
                Array.Resize(ref articles, articles.Length + 1);
                articles[1] = new ArticleType(nom, prix, quantite, type);

                // Affichage de tous les articles
                Console.WriteLine("\nListe complète des articles :");
                foreach (var article in articles)
                {
                    article.Afficher();
                }

                // Empêche la fermeture immédiate de la console
                Console.WriteLine("\nAppuyez sur une touche pour fermer...");
                Console.ReadLine();
            }
        }
 }


