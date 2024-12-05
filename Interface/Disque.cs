using INF;
using System;
using System.Linq;
using System.Text;


namespace INF
{
    public class Disque : Article, IRentable
    {
        public string Label { get; set; }

        public Disque(string designation, decimal prix, string label)
            : base(designation, prix)
        {
            Label = label;
        }

        public override void Acheter()
        {
            Console.WriteLine($"Disque acheté : {Designation}, Prix : {Prix:C}");
        }

        public decimal CalculateRent()
        {
            return 5.00m; // Coût fixe de location pour un disque
        }
    }

}
