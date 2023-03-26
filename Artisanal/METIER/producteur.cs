using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Artisanal.METIER
{
    [Table("producteur")]
    public class producteur
    {
        #region attributs
        #endregion

        #region proprietes
        [Key]
        [Column("idProducteur")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProducteur { get; set; }
        [Column("nomProducteur")]
        [Required]
        [MaxLength(20)]
        public string Nom { get; set; }
        [Column("telephone")]
        [Required]
        [MaxLength(20)]
        public string Telephone { get; set; }
        [Column("Adress")]
        [Required]
        [MaxLength(80)]
        public string Adress { get; set; }
        [Column("MotDePasseProducteur")]
        [Required]
        [MaxLength(20)]
        public string MotDePasseProducteur { get; set; }
        #endregion
        #region constructeurs

        public producteur()
        {
            this.Nom = "sans nom";
            this.Telephone = "000-000-0000";
            this.Adress = "pas d'adress";
            this.MotDePasseProducteur = "12345";
        }

        public producteur(string nom, string telephone, string adress, string motDePasseProducteur)
        {
        this.Nom = nom;
        this.Telephone = telephone;
        this.Adress = adress;
        this.MotDePasseProducteur = motDePasseProducteur;
        }

        public void Deconstruct(out string nom, out string telephone, out string adress, out string motDePasseProducteur)
        {
        nom = this.Nom;
        telephone = this.Telephone;
        adress = this.Adress;
        motDePasseProducteur = this.MotDePasseProducteur;
        }
        #endregion
    }
}
