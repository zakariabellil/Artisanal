using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Artisanal.METIER
{
    [Table("produit")]
    public class produit
    {
        #region attributs
        #endregion

        #region proprietes
        [Key]
        [Column("idProduit")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProduit { get; set; }
        [ForeignKey("Producteur")]
        public int idProducteur { get; set; }
        public producteur Producteur { get; set; }
        [Column("nomProduit")]
        [Required]
        [MaxLength(20)]
        public string NomProduit { get; set; }
        [Column("prix")]
        [Required]
        [MaxLength(20)]
        public string Prix { get; set; }

        [Required]
        [Column(TypeName = "varbinary(MAX)")]
        public byte[] Image { get; set; }
        #endregion
        #region constructeurs
        public produit()
        {
        this.NomProduit = "sans nom";
        this.Prix = "0";         
        }

        public produit(producteur producteur, string nomProduit, string prix, byte[] image)
        {
        this.idProducteur = producteur.idProducteur;
        this.NomProduit = nomProduit;
        this.Prix = prix;
        this.Image = image;
        }

        public void Deconstruct(out producteur producteur, out string nomProduit, out string prix, out byte[] image)
        {
        producteur = this.Producteur;
        nomProduit = this.NomProduit;
        prix = this.Prix;
        image = this.Image;
        }
        #endregion
    }
}
