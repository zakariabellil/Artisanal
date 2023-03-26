using Artisanal.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisanal.DAO
{
    interface IProducteurDao
    {
    producteur GetProducteurParNom(string nom);
    List<producteur> GetAllProducteur();
    bool AjouterProducteur(producteur producteur);
    void ModifierProducteur(String nom);
    bool SupprimerProducteur(String nom);
    }
}
