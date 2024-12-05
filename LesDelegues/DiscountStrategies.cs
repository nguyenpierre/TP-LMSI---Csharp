using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDL
{
    public class DiscountStrategies
    {
        // Remise fixe en pourcentage
        public static decimal FixedPercentageDiscount(Publication article)
        {
            return article.Prix * 0.1m; // 10% de remise
        }

        // Remise selon le type d'article
        public static decimal TypeBasedDiscount(Publication a)
        {
            if (a is Livre)
            {
                return a.Prix * 0.2m; // 20% pour les livres
            }
            else if (a is Disque)
            {
                return a.Prix * 0.15m; // 15% pour les disques
            }
            return 0; // Pas de remise pour les autres types
        }

        // Remise conditionnée par le prix
        public static decimal PriceBasedDiscount(Publication article)
        {
            return article.Prix > 50 ? 10m : 5m; // 10€ si > 50€, sinon 5€
        }
    }

}
