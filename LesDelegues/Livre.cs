using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDL
{
    public class Livre : Article
    {
        public string Isbn { get; set; }
        public int NbPages { get; set; }

        public Livre(string designation, decimal prix, string isbn, int nbPages)
            : base(designation, prix)
        {
            Isbn = isbn;
            NbPages = nbPages;
        }

        // Implémentation de la méthode PublishDetails
        public override void PublishDetails()
        {
            Console.WriteLine($"Livre : {Designation}, Prix : {Prix:C}, ISBN : {Isbn}, Pages : {NbPages}");
        }
    }
}
