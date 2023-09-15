using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.Modele
{
    public class Produit
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public float Price { get; set; }

        public Panier? Panier { get; set; }
        public int? PanierId { get; set; }

        public Promotion? Promotion { get; set; }
        public int? PromotionID { get; set; }

        public Categorie? Categorie { get; set; }
        public int? CategorieID { get; set; }
    }
}
