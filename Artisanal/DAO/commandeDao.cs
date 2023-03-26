using Artisanal.EF;
using Artisanal.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisanal.DAO
{
    public class commandeDao : ICommandeDao
    {
        private ContextEf context;
        public commandeDao()
        {
            context = new ContextEf();
        }

        public bool AjouterCommande(commande commande)
        {
            context.CommandeEntities.Add(commande);
            return context.SaveChanges() != 0 ? true : false;
        }

        public List<commande> GetAllCommande()
        {
            return context.CommandeEntities.ToList();
        }

        public List<commande> GetCommandeParNomClient(string nomClient)
        {
            return context.CommandeEntities
                          .Where(commande => commande.Client.NomClient.Equals(nomClient))
                          .ToList();
        }
        public commande GetCommandeParId(int Idcommande)
        {
            return context.CommandeEntities
                          .Where(commande => commande.IdCommande.Equals(Idcommande))
                          .FirstOrDefault();            
        }
        public List<commande> GetCommandeParNomProduit(string nomProduit)
        {
            return context.CommandeEntities
                       .Where(commande => commande.Produit.NomProduit.Equals(nomProduit))
                       .ToList();
        }

        public void ModifierCommande(commande commande,int QuantiteProduit)
        {
        commande.QuantiteProduit = QuantiteProduit;
        context.SaveChanges();
        }

        public bool SupprimerCommande(int idCommende)
        {
        commande commande = GetCommandeParId(idCommende);
        context.CommandeEntities.Remove(commande);
        int res = context.SaveChanges();
        return res != 0 ? true : false;
        }
    }
}
