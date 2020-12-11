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
    /// Logique d'interaction pour Authentification.xaml
    /// </summary>
    public partial class Authentification : Window
    {
        edfEntities gst;
        public Authentification()
        {
            InitializeComponent();
            
        }

        public Authentification(edfEntities gst)
        {
            this.gst = gst;
        }

        public edfEntities Gst { get; }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Authentification auth = new Authentification(gst);
            auth.Show();
        }

        
    }
}
