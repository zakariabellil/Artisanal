using Artisanal.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisanal.DAO
{
    interface IProduitDao
    {

       List<produit> GetProduitsParProducteur(producteur Producteur);  
        bool AjouterProduit(produit Produit);
       void ModifierProduit(produit produit, String nom);
       bool SupprimerProduit(string nom);


    }
}
