using System;
using System.Linq;
using System.Text;


namespace AT
{
    // Définition de l'énumération pour les types d'articles
    public enum TypeArticle
    {
        Alimentaire,
        Droguerie,
        Habillement,
        Loisir
    }

    public struct ArticleType
    {
        public string Nom { get; private set; }
        public decimal Prix { get; private set; }
        public int Quantite { get; private set; }
        public TypeArticle Type { get; private set; }

        // Constructeur avec type d'article
        public ArticleType(string nom, decimal prix, int quantite, TypeArticle type)
        {
            if (prix < 0) throw new ArgumentException("Le prix ne peut pas être négatif.");
            if (quantite < 0) throw new ArgumentException("La quantité ne peut pas être négative.");

            Nom = nom;
            Prix = prix;
            Quantite = quantite;
            Type = type;
        }

        // Méthode pour afficher les informations de l'article
        public void Afficher()
        {
            Console.WriteLine($"Article: {Nom}, Type: {Type}, Prix: {Prix:C}, Quantité: {Quantite}");
        }

        // Méthode pour ajouter à la quantité
        public void Ajouter(int quantiteAAjouter)
        {
            if (quantiteAAjouter <= 0) throw new ArgumentException("La quantité à ajouter doit être positive.");
            Quantite += quantiteAAjouter;
        }

        // Méthode pour retirer de la quantité
        public void Retirer(int quantiteARetirer)
        {
            if (quantiteARetirer <= 0) throw new ArgumentException("La quantité à retirer doit être positive.");
            if (Quantite < quantiteARetirer) throw new InvalidOperationException("Quantité insuffisante pour retirer.");

            Quantite -= quantiteARetirer;
        }
    }
}

