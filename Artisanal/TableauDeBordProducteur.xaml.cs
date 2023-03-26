using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
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
using Artisanal.EF;
using Artisanal.DAO;
using Artisanal.METIER;

namespace Artisanal
{
    /// <summary>
    /// Logique d'interaction pour TableauDeBordProducteur.xaml
    /// </summary>
    public partial class TableauDeBordProducteur : Window
    {
       private produitDao produitDao;
       private producteurDao producteurDao;
       private producteur producteurUser;

        public TableauDeBordProducteur(producteur ProducteurUser)
        {
            producteurDao = new producteurDao();
            produitDao = new produitDao();
            producteurUser = ProducteurUser;
            InitializeComponent();
        }
        public TableauDeBordProducteur()
        {
            producteurDao = new producteurDao();
            produitDao = new produitDao();
            InitializeComponent();
        }

        private void ajoutImage(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.produitAAjoutertxt.Text)) {
                produitAAjoutertxt.Focus();
                MessageBox.Show("Svp ajouter le nom du produit avant l'image");
            }
            else if(string.IsNullOrEmpty(this.prixProduitAAjouter.Text)) {
                prixProduitAAjouter.Focus();
                MessageBox.Show("Svp ajouter le prix du produit avant l'image");
            }
            else{
                string nom = this.produitAAjoutertxt.Text;
                string prix = this.prixProduitAAjouter.Text;

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
                byte[] data;
                if (openFileDialog.ShowDialog() == true)
                {

                    // Get the selected file path
                    string imagePath = openFileDialog.FileName;

                    using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        data = new byte[stream.Length];
                        stream.Read(data, 0, data.Length);
                    }

                    
                    
                    produit produit = new produit(producteurUser, nom, prix, data);

                    produitDao produitDao = new produitDao();
                    produitDao.AjouterProduit(produit);

                    this.image.Source = LoadImage(data);
                    MessageBox.Show("Ajout avec succes");
                }
            }
        }

        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.ProduitASupprimerTxt.Text)) {
                ProduitASupprimerTxt.Focus();
                MessageBox.Show("Svp ajouter le nom du produit avant de le supprimer");
            }
            else {
              
                
                if (!produitDao.SupprimerProduit(this.ProduitASupprimerTxt.Text)) { 
                    MessageBox.Show("Le produit n'a pas pu etre supprimer. Svp verifier si le nom est bon"); }
            }
        }

        private void nomProduitASupprimerTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void modifierBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.nomProdAModifierTxt.Text)) {
                nomProdAModifierTxt.Focus();
                MessageBox.Show("Svp ajouter le nom du produit avant de le modifier");
            }
            else if (string.IsNullOrEmpty(this.nouveauPrix.Text)) {
                nouveauPrix.Focus();
                MessageBox.Show("Svp ajouter le prix avant de le modifier");
            }
            else {
                List<produit> produits= produitDao.GetProduitsParProducteur(producteurUser);

                foreach (produit produit in produits)
                {
                if (this.nomProdAModifierTxt.Text == produit.NomProduit)
                    {
                        produitDao.ModifierProduit(produit, this.nouveauPrix.Text);
                        MessageBox.Show("produit modifie!");
                    }

                }
                
            
            }
            
        }
    }
}
