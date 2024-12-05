using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLABS
{
    public abstract class Publication
    {
        // Propriétés communes à toutes les publications
        public string Designation { get; set; }
        public decimal Prix { get; set; }

        // Constructeur pour initialiser les propriétés communes
        protected Publication(string designation, decimal prix)
        {
            Designation = designation;
            Prix = prix;
        }

        // Méthode abstraite à implémenter dans les classes dérivées
        public abstract void PublishDetails();
    }

}
