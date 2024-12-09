using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

// Définition des classes et énumérations existantes
enum TypeArticle
{
    Alimentaire,
    Droguerie,
    Habillement,
    Loisir
}

class ArticleTypé
{
    public string Nom { get; set; }
    public double Prix { get; set; }
    public int Quantite { get; set; }
    public TypeArticle Type { get; set; }

    public ArticleTypé(string nom, double prix, int quantite, TypeArticle type)
    {
        Nom = nom;
        Prix = prix;
        Quantite = quantite;
        Type = type;
    }
}

static class Extensions
{
    // Méthode d'extension pour afficher tous les articles
    public static void AfficherTous(this IEnumerable<ArticleTypé> articles)
    {
        foreach (var article in articles)
        {
            Console.WriteLine($"Nom: {article.Nom}, Prix: {article.Prix:C}, Quantité: {article.Quantite}, Type: {article.Type}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Étape 1 : Chargement des données
        List<ArticleTypé> articles = new List<ArticleTypé>
        {
            new ArticleTypé("Pomme", 2.5, 50, TypeArticle.Alimentaire),
            new ArticleTypé("Savon", 3.2, 30, TypeArticle.Droguerie),
            new ArticleTypé("T-shirt", 15.0, 20, TypeArticle.Habillement)
        };

        // Étape 2.1 : Requêtes LINQ de base
        Console.WriteLine("Articles alimentaires :");
        var alimentaires = articles.Where(a => a.Type == TypeArticle.Alimentaire);
        alimentaires.AfficherTous();

        Console.WriteLine("\nArticles triés par prix décroissant :");
        var triPrix = articles.OrderByDescending(a => a.Prix);
        triPrix.AfficherTous();

        Console.WriteLine("\nStock total :");
        int stockTotal = articles.Sum(a => a.Quantite);
        Console.WriteLine(stockTotal);

        // Étape 2.2 : Filtrage avancé avec OfType
        var mixedCollection = new List<object> { new ArticleTypé("Chaise", 25.0, 10, TypeArticle.Habillement), "Texte", 42 };
        var typedArticles = mixedCollection.OfType<ArticleTypé>();
        Console.WriteLine("\nArticles typés extraits :");
        typedArticles.AfficherTous();

        // Étape 2.3 : Projection avec des types anonymes
        Console.WriteLine("\nProjection (Nom et Prix) :");
        var projection = articles.Select(a => new { a.Nom, a.Prix });
        foreach (var item in projection)
        {
            Console.WriteLine($"Nom: {item.Nom}, Prix: {item.Prix:C}");
        }

        // Étape 3.2 : Calcul avec expression lambda
        double valeurTotaleStock = articles.Sum(a => a.Prix * a.Quantite);
        Console.WriteLine($"\nValeur totale du stock : {valeurTotaleStock:C}");

        // Étape 4.1 : Export JSON
        string jsonFile = "articles.json";
        string json = JsonSerializer.Serialize(articles, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(jsonFile, json);
        Console.WriteLine($"\nDonnées exportées vers {jsonFile}");

        // Étape 4.2 : Import JSON
        Console.WriteLine("\nChargement des données depuis le fichier JSON :");
        string importedJson = File.ReadAllText(jsonFile);
        var importedArticles = JsonSerializer.Deserialize<List<ArticleTypé>>(importedJson);
        importedArticles.AfficherTous();
    }
}
