using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDL
{
    public  class Article : Publication
    {


        public Article(string designation, decimal prix) : base(designation, prix)
        {
            
        }

        public void Acheter()
        {

        }// Méthode abstraite à implémenter dans les sous-classes
        public override void PublishDetails()
        {
            Console.WriteLine("Article "+Designation+" prix=");
        }
    }
}
