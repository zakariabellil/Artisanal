using Artisanal.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisanal.DAO
{
    interface IClientDao
    {
        client GetClientParNom(string nomClient);
        List<client> GetAllClient();
        bool AjouterClient(client client);
        void ModifierNomClient(client client,string nom);
        bool SupprimerClient(string nom);

    }
}
