using Artisanal.METIER;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Artisanal.EF
{
   public class ContextEf : DbContext
    {
        public ContextEf() : base("MaBdArtisanal") { }
        public DbSet<client> ClientEntities { get; set; }
        public DbSet<produit> ProduitEntities { get; set; }
        public DbSet<producteur> ProducteurEntities { get; set; }   
        public DbSet<commande> CommandeEntities { get; set; }
    }
}
