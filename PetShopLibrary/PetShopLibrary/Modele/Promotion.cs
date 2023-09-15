using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.Modele
{
    public class Promotion
    {
        public int Id { get; set; }
        public float pourcentage { get; set; }

        public ICollection<Produit> Produits { get; set; }

    }
}
