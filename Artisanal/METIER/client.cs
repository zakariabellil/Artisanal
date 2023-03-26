using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Navigation;

namespace Artisanal.METIER
{
   public class client
    {
        #region attributs
        #endregion

        #region proprietes
        [Key]
        [Column("idClient")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClient { get; set; }
        [Column("nomClient")]
        [Required]
        [MaxLength(10)]
        public string NomClient { get; set; }
        [Column("motDePasseClient")]
        [Required]
        [MaxLength(20)]
        public string MotDePasseClient { get; set; }
        #endregion
        #region constructeurs

        public client()
        {
            this.NomClient = "sans nom";
            this.MotDePasseClient = "12345";
        }

        public client(string nomClient, string motDePasseClient) {
        this.NomClient = nomClient;
            this.MotDePasseClient = motDePasseClient;
        }

        public void Deconstruc(out string nomClient, out string motDePasseClient) {
        nomClient = this.NomClient;
        motDePasseClient = this.MotDePasseClient;
        }
        #endregion

    }
}
