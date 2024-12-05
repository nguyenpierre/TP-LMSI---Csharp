using System;
using System.Linq;
using System.Text;
using LesBases;

public class Disque : Article
{
    public string Label { get; set; }

    public void Ecouter()
    {
        Console.WriteLine($"Écoute du disque {Designation} sous le label {Label}.");
    }
}
