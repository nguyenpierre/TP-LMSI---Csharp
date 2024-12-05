using System;
using System.Linq;
using System.Text;


namespace INF
{
  public abstract class Article
    {

        private string m_Designation;
        public string Designation { get; set; }
        public decimal Prix { get; set; }

        public Article(string designation, decimal prix)
        {
            Designation = designation;
            Prix = prix;
        }

        public abstract void Acheter(); // Méthode abstraite à implémenter dans les sous-classes
    }

}
