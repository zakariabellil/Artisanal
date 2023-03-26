using Artisanal.METIER;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisanal.EF
{
    class InitDonneeArtisanal : CreateDatabaseIfNotExists<ContextEf>
    {
        protected override void Seed(ContextEf context)
        {
            base.Seed(context);
            context.ClientEntities.Add(new client("client1", "mdpClient1"));
            context.ClientEntities.Add(new client("client2", "mdpClient2"));
            context.ClientEntities.Add(new client("client3", "mdpClient3"));
            context.ClientEntities.Add(new client("client4", "mdpClient4"));
            context.ClientEntities.Add(new client("client5", "mdpClient5"));
            context.ClientEntities.Add(new client("client6", "mdpClient6"));
            context.ClientEntities.Add(new client("client7", "mdpClient7"));
            context.SaveChanges();
            context.ProducteurEntities.Add(new producteur("producteur1", "514-222-5555", " 8005 Boul Langelier, Saint-Léonard, QC H1P 2X6", "mdpProducteur1"));
            context.ProducteurEntities.Add(new producteur("producteur2", "514-333-3333", "6565 Rue Jean-Talon Estates, Saint-Leonard, Quebec H1S 1N2", "mdpProducteur2"));
            context.ProducteurEntities.Add(new producteur("producteur3", "514-353-3553", "6565 Rue Jean-Talon Estates, Saint-Leonard, Quebec H1S 1N2", "mdpProducteur3"));
            context.ProducteurEntities.Add(new producteur("producteur4", "514-303-3003", "11200 Boul. Cavendish Place Vertu, Saint-Laurent, QC H4R 2J7", "mdpProducteur4"));
            context.ProducteurEntities.Add(new producteur("producteur5", "514-999-1113", "Boul. De, 7200 Bd de Sainte-Anne de Bellevue, Montréal, QC H4B", "mdpProducteur5"));
            context.ProducteurEntities.Add(new producteur("producteur6", "514-900-1113", "3180 Rue Wellington, Verdun, QC H4G 1T3", "mdpProducteur6"));
            context.ProducteurEntities.Add(new producteur("producteur7", "514-160-6003", " 7275 Sherbrooke St E Suite 140, Montreal, Quebec H1N 1E9", "mdpProducteur7"));
            context.SaveChanges();
        }
    }
}
