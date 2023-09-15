using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.Modele
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Panier? Panier { get; set; }


    }
}
