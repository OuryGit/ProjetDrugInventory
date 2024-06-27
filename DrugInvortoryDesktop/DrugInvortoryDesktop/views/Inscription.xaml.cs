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

namespace DrugInvortoryDesktop.views
{
    /// <summary>
    /// Logique d'interaction pour Inscription.xaml
    /// </summary>
    public partial class Inscription : Window
    {
        public Inscription()
        {
            InitializeComponent();
        }
        // Cette méthode est déclenchée lorsqu'un bouton de la souris est enfoncé sur le bord de la fenêtre.
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Vérifie si le bouton gauche de la souris a été enfoncé.
            if (e.ChangedButton == MouseButton.Left)
            {
                // Déplace la fenêtre en fonction du mouvement de la souris.
                this.DragMove();
            }
        }

        // Variable pour suivre l'état de maximisation de la fenêtre.
        private bool IsMaximized = false;

        // Cette méthode est déclenchée lorsqu'un bouton gauche de la souris est enfoncé deux fois sur le bord de la fenêtre.
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Vérifie si un double-clic (deux clics successifs) a été effectué.
            if (e.ClickCount == 2)
            {
                // Si la fenêtre est déjà maximisée, la redimensionner à sa taille normale.
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal; // Change l'état de la fenêtre à normal.
                    this.Width = 1080;  // Définit la largeur de la fenêtre à 1080 pixels.
                    this.Height = 720;  // Définit la hauteur de la fenêtre à 720 pixels.

                    IsMaximized = false;  // Met à jour l'état pour indiquer que la fenêtre n'est plus maximisée.
                }
                // Si la fenêtre n'est pas maximisée, la maximiser.
                else
                {
                    this.WindowState = WindowState.Maximized; // Change l'état de la fenêtre à maximisé.
                    IsMaximized = true;  // Met à jour l'état pour indiquer que la fenêtre est maximisée.
                }
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageConnexion pageConnexion = new PageConnexion();
            pageConnexion.Show();
        }
    }
}
