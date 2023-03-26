using Artisanal.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisanal.DAO
{
    interface ICommandeDao
    {
    List<commande> GetCommandeParNomClient(string nomClient);
    List<commande> GetCommandeParNomProduit(string nomProduit);
    List<commande> GetAllCommande();
    commande GetCommandeParId(int Idcommande);
    bool AjouterCommande(commande commande);
    void ModifierCommande(commande commande, int QuantiteProduit);
    bool SupprimerCommande(int idCommende);

    }
}
