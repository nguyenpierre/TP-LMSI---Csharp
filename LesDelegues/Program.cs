using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LDL;
using static LDL.Program;

namespace LDL{
    class Program
    {// Déclaration du délégué
            public delegate decimal discount(Publication article);//je cree un type de pointeur de fonction
        // Instances de délégués pointant vers des stratégies
           static discount fixe = DiscountStrategies.FixedPercentageDiscount;//je cree le pointeur

            static discount typed = DiscountStrategies.TypeBasedDiscount;
            static discount priced = DiscountStrategies.PriceBasedDiscount;
        static void Main(string[] args)
        {

            //Publication p = new Livre("Le Petit Prince", 20m, "123456789", 96);
            //p.m_designation = "truc";
            // Liste d'articles
            List<Publication> publications = new List<Publication> {
                new Livre("Le Petit Prince", 20m, "123456789", 96),
                new Disque("Thriller", 60m, "Epic Records"),
                new Video("Inception", 35m, 148)
            };
      
        // Application des remises
            foreach (var publication in publications)
            {
                Console.WriteLine($"Article : {publication.Designation}, Prix initial : {publication.Prix:C}");

                // Appliquer différentes stratégies
                Console.WriteLine($"Remise (10%) : {fixe(publication):C}");
                Console.WriteLine($"Remise par type : {typed(publication):C}");
                Console.WriteLine($"Remise par prix : {priced(publication):C}");
                Console.WriteLine($"Prix final (avec remise 10%) : {(publication.Prix - fixe(publication)):C}");



            }
            // Empêche la fermeture immédiate de la console
            Console.WriteLine("Appuyez sur une touche pour fermer...");
            Console.ReadLine();

        }
           
      
    }


}
