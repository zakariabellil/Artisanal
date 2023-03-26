using Artisanal.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Artisanal
{
    class imageCatalogue
    {


        private string nomProduit = "annaux";
        public string NomProduit 
        {
            get { return this.nomProduit; }
            set { this.nomProduit = value; }
        }

        private string prixProduit = "55";

        public string PrixProduit
        {
            get { return this.prixProduit; }
            set { this.prixProduit = value; }
        }

        private BitmapImage imageData;
        public BitmapImage ImageData
        {
            get { return this.imageData; }
            set { this.imageData = value; }
        }
    }
}
