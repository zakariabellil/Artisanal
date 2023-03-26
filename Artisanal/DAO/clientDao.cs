using Artisanal.EF;
using Artisanal.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisanal.DAO
{
    public class clientDao: IClientDao
    {
        private ContextEf context;
        public clientDao()
        {
        context = new ContextEf();
        }

        public client GetClientParNom(string nomClient)
        {
        return context.ClientEntities
                      .Where(client => client.NomClient.Equals(nomClient))
                      .FirstOrDefault();
        }

        public List<client> GetAllClient()
        {
            return context.ClientEntities.ToList();
        }

        public bool AjouterClient(client client)
        {
            context.ClientEntities.Add(client);
             return context.SaveChanges() != 0 ? true : false;
        }

        public void ModifierNomClient(client client, string nom)
        {
          client.NomClient = nom;
          context.SaveChanges();
        }

        public bool SupprimerClient(string nom)
        {
            client client = GetClientParNom(nom);
            context.ClientEntities.Remove(client);
            int res = context.SaveChanges();
            return res != 0 ? true : false;
        }
    }
}
