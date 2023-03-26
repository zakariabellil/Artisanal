using Artisanal.DAO;
using Artisanal.METIER;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Artisanal
{
    /// <summary>
    /// Logique d'interaction pour ClientCatalogue.xaml
    /// </summary>
    public partial class ClientCatalogue : Window
    {
      private client client;
      private produitDao produitDao;
      private List<imageCatalogue> imageCatalogues = new List<imageCatalogue>();

        public ClientCatalogue()
        {
            InitializeComponent();

            this.listeCatalogue.ItemsSource = new imageCatalogue[]
            {
            new imageCatalogue{ImageData = LoadImage("1.jpg")},
            new imageCatalogue{ImageData = LoadImage("6.jpg")},
            new imageCatalogue{ImageData = LoadImage("1.jpg")},
            new imageCatalogue{ImageData = LoadImage("12.jpg")},
            new imageCatalogue{ImageData = LoadImage("7.jpg")},
            new imageCatalogue{ImageData = LoadImage("6.jpg")}
            };
        }
        public ClientCatalogue(client Client)
        {
            client = Client;
            produitDao = new produitDao();
            List<produit> produits = produitDao.GetAllProduit();
            
            if (produits != null){
    
                foreach (produit produit in produits)
                {
                    imageCatalogue imageCatalogue = new imageCatalogue();
                    imageCatalogue.NomProduit = produit.NomProduit;
                    imageCatalogue.PrixProduit = produit.Prix;

                    MemoryStream memoryStream = new MemoryStream(produit.Image);
                    Bitmap bitmap = new Bitmap(memoryStream);
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = new MemoryStream(ImageToByteArray(bitmap));
                    bitmapImage.EndInit();
                    imageCatalogue.ImageData = bitmapImage;
                    imageCatalogues.Add(imageCatalogue);
                }
            }

            InitializeComponent();
            this.listeCatalogue.ItemsSource = imageCatalogues;
        }

        private BitmapImage LoadImage(string filename)
        {
        return new BitmapImage(new Uri("/ressource/"+ filename, UriKind.Relative));
        }
        private byte[] ImageToByteArray(Bitmap bitmap)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }

    }
}
