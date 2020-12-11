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

namespace ProjetEDF
{
    /// <summary>
    /// Logique d'interaction pour admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        edfEntities gst;
        public admin(edfEntities unControleurEntities)
        {
            InitializeComponent();
            gst = unControleurEntities;
            lstControleur.ItemsSource = gst.controleur.ToList();
        }

        private void lstControleur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            controleur leCtrl = gst.controleur.ToList().Find(ctrl => ctrl.login == null);
            if (lstControleur.SelectedItem != null)
            {
                List<controleur> allControleur = gst.controleur.ToList();
                List<client> allClient = gst.client.ToList().FindAll(i => i.idcontroleur == (lstControleur.SelectedItem as controleur).id);

                var quert = from ag in allControleur
                                       where !allControleur
                                       select new controleur
                                       {
                                           controleur = leCtrl.login,
                                                  
                                       };
            }
            

        


        }
        private void lstClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            client cli = gst.client.ToList().Find(cli => cli.login == null);
        }

        private void btninsererControlleur_Click(object sender, RoutedEventArgs e)
        {
            if(lstControleur.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un le nom du controlleur", "veuillez saisir le prenom du controleur", MessageBoxButton.OK, MessageBoxImage.Hand);
            }

        }

        private void btnInsererClient_Click(object sender, RoutedEventArgs e)
        {
            if(lstClient.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un le nom du controlleur", "veuillez saisir le prenom du controleur", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }
    }
}
