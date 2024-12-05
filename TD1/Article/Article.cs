using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Article
{
    public struct Article
    {
        public string Nom { get; private set; }
        public decimal Prix { get; private set; }
        public int Quantite { get; private set; }

        // Constructeur prenant les informations nécessaires
        public Article(string nom, decimal prix, int quantite)
        {
            if (prix < 0) throw new ArgumentException("Le prix ne peut pas être négatif.");
            if (quantite < 0) throw new ArgumentException("La quantité ne peut pas être négative.");

            Nom = nom;
            Prix = prix;
            Quantite = quantite;
        }

        // Méthode pour afficher les informations de l'article
        public void Afficher()
        {
            Console.WriteLine($"Article: {Nom}, Prix: {Prix:C}, Quantité: {Quantite}");
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

