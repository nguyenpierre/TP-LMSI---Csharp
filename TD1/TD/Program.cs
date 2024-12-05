using System;
using System.Linq;
using System.Text;


namespace LesBases
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Article livre = new Poche
            {
                Designation = "Les Misérables",
                Prix = 15.99m,
                Isbn = "978-1234567890",
                NbPages = 1200,
                Categorie = "Classique"
            };

            Article disque = new Disque
            {
                Designation = "Thriller",
                Prix = 9.99m,
                Label = "Epic Records"
            };

            Article video = new Video
            {
                Designation = "Inception",
                Prix = 19.99m,
                Duree = TimeSpan.FromHours(2.5)
            };

            livre.Acheter();
            (disque as Disque)?.Ecouter();
            (video as Video)?.Afficher();
            Console.ReadLine();
        }
    }

}
