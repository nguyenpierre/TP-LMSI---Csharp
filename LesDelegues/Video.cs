using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDL
{
    public class Video : Article
    {
        public int Duree { get; set; } // Durée en minutes

        public Video(string designation, decimal prix, int duree)
            : base(designation, prix)
        {
            Duree = duree;
        }

        // Implémentation de la méthode PublishDetails
        public override void PublishDetails()
        {
            Console.WriteLine($"Vidéo : {Designation}, Prix : {Prix:C}, Durée : {Duree} minutes");
        }
    }
}
