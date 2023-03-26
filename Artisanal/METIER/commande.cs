using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Artisanal.METIER
{
    public class commande
    {
        #region attributs
        #endregion
        #region proprietes
        [Key]
        [Column("idCommande")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCommande { get; set; }
        [ForeignKey("Client")]
        public int IdClient { get; set; }
        public client Client { get; set; }
        [ForeignKey("Produit")]
        public int IdProduit { get; set; }
        public produit Produit { get; set; }
        [Column("dateCommande")]
        [Required]
        [DataType("Date")]
        public DateTime DateCommande { get; set; }
        [Column("quantiteProduit")]
        [Required]
        public int QuantiteProduit { get; set; }
        #endregion
        #region constructeurs
        public commande(client client, produit produit) {
            this.IdClient = client.IdClient;
            this.IdProduit = produit.idProduit;
            this.DateCommande = DateTime.Now;}

        public void Deconstruct(out client client,out produit produit) {
            client = this.Client;
            produit = this.Produit;}
        #endregion
    }
}
