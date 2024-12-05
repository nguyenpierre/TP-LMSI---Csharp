using System;
using System.Linq;
using System.Text;
using LesBases;

namespace LesBases
{
    public class Article
    {
        public string Designation { get; set; }
        public decimal Prix { get; set; }

        public int Quantite { get; private set; }

        public virtual void Acheter()
        {
            Console.WriteLine($"Article {Designation} acheté pour {Prix:C}.");
        }


    }

   
}
