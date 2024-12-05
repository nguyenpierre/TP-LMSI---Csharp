using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDL
{
    public class Disque : Article
    {
        public string Label { get; set; }

        public Disque(string designation, decimal prix, string label)
            : base(designation, prix)
        {
            Label = label;
        }

        // Implémentation de la méthode PublishDetails
        public override void PublishDetails()
        {
            Console.WriteLine($"Disque : {Designation}, Prix : {Prix:C}, Label : {Label}");
        }
    }

}
