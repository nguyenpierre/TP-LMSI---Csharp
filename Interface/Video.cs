using INF;
using System;
using System.Linq;
using System.Text;

namespace INF
{
    public class Video : Article
    {
        public int Duree { get; set; } // Durée en minutes

        public Video(string designation, decimal prix, int duree)
            : base(designation, prix)
        {
            Duree = duree;
        }

        public override void Acheter()
        {
            Console.WriteLine($"Vidéo achetée : {Designation}, Prix : {Prix:C}");
        }

        // Pas de méthode CalculateRent ici
    }

}
