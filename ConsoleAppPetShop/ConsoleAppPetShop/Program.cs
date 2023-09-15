// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using PetShopLibrary.Modele;
using System.Xml.Linq;

PetShopContext context = new PetShopContext();
//Console.WriteLine("Ajouter un client");
//context.Clients.Add(new Client { Name = "Thierry Boulanger", Panier = null });
//context.SaveChanges();

//Categorie categorie = new Categorie{ Name = "Assurance" };
//Promotion promotion = new Promotion{ pourcentage=10 };
//Produit produit = new Produit { Categorie=categorie, Name="AssurChat", Price = 15};

//if(categorie.Produits==null)
//    categorie.Produits = new List<Produit>();

//context.Produits.Add(produit);

//if (promotion.Produits == null)
//    promotion.Produits = new List<Produit>();

//context.Produits.Add(produit);
//context.Promotions.Add(promotion);

//categorie.Produits.Add(produit);
//promotion.Produits.Add(produit);



//Console.WriteLine(context.ChangeTracker.DebugView.LongView);

//try
//{
//    context.SaveChanges();

//}
//catch (Exception)
//{

//	throw;
//}

//lister les produits
//foreach (var item in context.Produits.Include(p=>p.Categorie).Include(p=>p.Promotion))
//{
//    string cat = item.Categorie==null?"inconnu":item.Categorie.Name;
//    float prom = item.Promotion==null?0:item.Promotion.pourcentage;
//    Console.WriteLine(string.Format("le produit '{0}' de la catégorie '{1}' possède une promotion de {2} %", item.Name, cat, prom));

//}

//Ajout dans le panier

//Client c = context.Clients.Include(cl=>cl.Panier).Where(x => x.Name =="Thierry Boulanger").FirstOrDefault();
//if (c != null)
//{
//    //le panierf du client
//    Panier panier = context.Paniers.Include(cl => cl.Produits).Where(x => x.ClientId == c.Id).FirstOrDefault();

//    if(panier.Produits == null)
//        panier.Produits = new List<Produit>();
//    //Un produit

//    Produit produit = context.Produits.Where(p => p.Name == "AssurChat").FirstOrDefault();


//    panier.Produits.Add(produit);

//    c.Panier = panier;




//    try
//    {
//        context.SaveChanges();

//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);

//        throw;
//    }


//}


//Voir le panier du client
Client c = context.Clients.Include(cl=>cl.Panier).Where(x => x.Name =="Thierry Boulanger").FirstOrDefault();

Panier panier = context.Paniers.Include(cl => cl.Produits).Where(x => x.ClientId == c.Id).FirstOrDefault();

Console.WriteLine("Panier de " + c.Name);

foreach (var item in panier.Produits)
{
    Produit prd = context.Produits.Include(cl => cl.Promotion).Where(x => x.Id == item.Id).FirstOrDefault();


    float p = prd.Promotion != null ? prd.Promotion.pourcentage : 0;
    Console.WriteLine(string.Format(" {0} pour un prix de  {1} bénéficie d'un promotion de {2} % ", prd.Name, prd.Price, p));
}









