using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LDL
{
    public abstract class Publication
    { protected string m_designation;      //Attribut


        // Propriétés communes à toutes les publications
        public string Designation {
            get
            {
                return m_designation;
            }
            set
            {
                m_designation= value;
            }
        }
        protected decimal m_prix;
        public decimal Prix
        {
            get
            {
                return m_prix;
            }
            set
            {
                m_prix = value;
            }
        }


        // Constructeur pour initialiser les propriétés communes
        public Publication(string d, decimal prix)
        {
            m_designation = d;//Designation = d; dans ce constructeur la classe reconnaisse les propriétés et les attributs qu'ils soient public ou private
            m_prix = prix;
        }

        // Méthode abstraite à implémenter dans les classes dérivées
        public abstract void PublishDetails();
    }
}
