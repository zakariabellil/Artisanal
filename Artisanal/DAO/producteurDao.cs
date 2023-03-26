using Artisanal.EF;
using Artisanal.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisanal.DAO
{
    public class producteurDao
    {
        private ContextEf context;
        public producteurDao()
        {
        context = new ContextEf();
        }

       public producteur GetProducteurParNom(string nom) {
            return context.ProducteurEntities
                               .Where(prod => prod.Nom.Equals(nom))
                               .FirstOrDefault();
        }
        List<producteur> GetAllProducteur() {
            return context.ProducteurEntities.ToList();}
        public bool AjouterProducteur(producteur producteur) {
            context.ProducteurEntities.Add(producteur);
            return context.SaveChanges() != 0 ? true : false;
        }
        public void ModifierNomProducteur(producteur producteur, String nom)
        {
        producteur.Nom = nom;
        context.SaveChanges();
        }
        public bool SupprimerProducteur(String nom)
        {
        producteur producteur = GetProducteurParNom(nom);

        context.ProducteurEntities.Remove(producteur);
        int res = context.SaveChanges();
        return res != 0 ? true : false;
        }
    }
}

