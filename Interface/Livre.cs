using INF;
using System;
using System.Linq;
using System.Text;

namespace INF
{
    public class Livre : Article, IRentable
    {
        public string Isbn { get; set; }
        public int NbPages { get; set; }

        public Livre(string designation, decimal prix, string isbn, int nbPages)
            : base(designation, prix)
        {
            this.Isbn = isbn;
            this.NbPages = nbPages;
        }

        public override void Acheter()
        {
            Console.WriteLine($"Livre acheté : {Designation}, Prix : {Prix:C}");
        }

        public decimal CalculateRent()
        {
            return NbPages * 0.05m; // Coût de location basé sur le nombre de pages
        }
    }

}
