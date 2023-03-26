using Artisanal.DAO;
using Artisanal.METIER;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;

namespace Artisanal
{
    /// <summary>
    /// Logique d'interaction pour connexion.xaml
    /// </summary>
    public partial class connexion : Window
    {
        private producteurDao producteurDao;
        private clientDao clientDao;
        public connexion()
        {
            producteurDao = new producteurDao();
            clientDao = new clientDao();
            InitializeComponent();
        }

        private void connectionBtn_Click(object sender, RoutedEventArgs e)
        {

             if (string.IsNullOrEmpty(this.nomUtilisateurTxt.Text))
            {
                nomUtilisateurTxt.Focus();
                MessageBox.Show("Svp ajouter le nom d'utilisateur avant de vous connecter");
            }
            else if (string.IsNullOrEmpty(this.mdpTxt.Password)) {
                mdpTxt.Focus();
                MessageBox.Show("Svp ajouter un mot de passe avant de vous connecter");
            }
      
            else if (this.clientRdBtn.IsChecked == false  && this.producteurRadBtn.IsChecked == false) {
                this.typeUtilisateurLab.Focus();
                MessageBox.Show("Svp choisir un type d'utilisateur avant de vous connecter");
            }
            else if (this.clientRdBtn.IsChecked == true)
            {
            client client = clientDao.GetClientParNom(this.nomUtilisateurTxt.Text);
            if (client == null) {
                    MessageBox.Show("nom ou mot de passe incorrect");               
                }
            else {
               
                    ClientCatalogue window = new ClientCatalogue(client);
                    window.Show();
                    this.Close();

                }
            }
            else if(this.producteurRadBtn.IsChecked == true)
            {
            producteur producteur = producteurDao.GetProducteurParNom(this.nomUtilisateurTxt.Text);
            if (producteur == null) {
               MessageBox.Show("nom ou mot de passe incorrect");}
            else {
                    TableauDeBordProducteur window = new TableauDeBordProducteur(producteur);
                    window.Show();
                    this.Close();
                }
            }
        }
    }
}
