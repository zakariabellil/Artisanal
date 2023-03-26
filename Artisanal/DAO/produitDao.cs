using Artisanal.EF;
using Artisanal.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisanal.DAO
{
    public class produitDao
    {
        private ContextEf context;
        public produitDao()
        {
            context = new ContextEf();
        }
        public List<produit> GetProduitsParProducteur(producteur Producteur) {
            return context.ProduitEntities
                           .Where(prod => prod.Producteur.idProducteur.Equals(Producteur.idProducteur))
                           .ToList();
        }
        public produit GetProduitParNom(string nom) {
            return context.ProduitEntities
                       .Where(prod => prod.NomProduit.Equals(nom))
                       .FirstOrDefault();}
        public List<produit> GetAllProduit() {
            return context.ProduitEntities.ToList();  }
        public bool AjouterProduit(produit produit) {
          
            context.ProduitEntities.Add(produit);
            return context.SaveChanges() != 0 ? true : false;}
        public void ModifierProduit(produit produit,string prix) {
            produit.Prix = prix;
            context.SaveChanges();
        }
        public bool SupprimerProduit(String nom) {
        produit produit =  GetProduitParNom(nom);
        if (produit == null)
            {
            return false;
            }
         context.ProduitEntities.Remove(produit);
         int res = context.SaveChanges();
         return res != 0 ? true : false;
        }
    }
}


