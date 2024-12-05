using System;
using System.Linq;
using System.Text;
using LesBases;

public class Video : Article
{
    public TimeSpan Duree { get; set; }

    public void Afficher()
    {
        Console.WriteLine($"Affichage de la vidéo {Designation} d'une durée de {Duree}.");
    }
}
