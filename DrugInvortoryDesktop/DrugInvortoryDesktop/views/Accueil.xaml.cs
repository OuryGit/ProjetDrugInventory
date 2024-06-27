using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DrugInvortoryDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System.Buffers;
using System.Windows.Forms;

namespace DrugInvortoryDesktop.views
{
    /// <summary>
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : Window
    {
        // mes variables globales 
        private PlanteContext _context;
        private PlanteContext _archive;
        private HashSet<string> existingPlantIds = new HashSet<string>(); // liste qui va contenir tous les indentifants 

        private string plante_selectionne;

        public Accueil()
        {
            InitializeComponent();
            ChargerListePlantules();
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

       
        private void ChargerListePlantules()
        {
            using (PlanteContext PC = new PlanteContext())
            {
                try
                {
                    var MesPlante = PC.plantule.ToList();
                    grillesDesplantules.ItemsSource = MesPlante;

                    // Récupérer les identifiants des plantes et les ajouter à la collection
                    foreach (var plante in MesPlante)
                    {
                        existingPlantIds.Add(plante.IdPlante);
                    }
                }
                catch (Exception ex)
                {
                    // Gestion des exceptions
                }
            }
        }
        // gestion du bouton d'ajout -------------------------------------------------------------------------
        private void btn_ajouter_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si tous les TextBox sont remplis
            if (string.IsNullOrWhiteSpace(txtbxDescription.textBox.Text) ||
                string.IsNullOrWhiteSpace(txtbxProvence.textBox.Text) ||
                string.IsNullOrWhiteSpace(txtId.textBox.Text))
            {
                System.Windows.MessageBox.Show("Veuillez remplir tous les champs de texte");
                return;
            }

            // Vérifier les ComboBox
            if (cmbxEtat.SelectedIndex == -1 || cmbxEtat.SelectedIndex == 0 ||
                cmbxSatde.SelectedIndex == -1 || cmbxSatde.SelectedIndex == 0 ||
                cbxEntreposage.SelectedIndex == -1 || cbxEntreposage.SelectedIndex == 0)
            {
                System.Windows.MessageBox.Show("Veuillez sélectionner une option dans toutes les listes déroulantes");
                return;
            }

            string identifiant = txtId.textBox.Text;

            // Vérifier si l'identifiant existe déjà
            using (PlanteContext _context = new PlanteContext())
            {
                if (_context.plantule.Any(p => p.IdPlante == identifiant))
                {
                    System.Windows.MessageBox.Show("L'identifiant de la plante existe déjà. Veuillez en choisir un autre.");
                    return;
                }

                // Les variables qui vont récupérer les données des TextBox si toutes les conditions sont respectées
                string nouveau_txtDescrip = txtbxDescription.textBox.Text;
                string nouvau_txtProvence = txtbxProvence.textBox.Text;
                string nouvau_cmbxEtatSante = cmbxEtat.Text;
                string nouvau_cmbxStade = cmbxSatde.Text;
                string nouvau_cmbxEntrposage = cbxEntreposage.Text;
                DateTime dateTime = DateTime.Now;

                var nouvel_plante = new plantule
                {
                    IdPlante = identifiant,
                    Provenance = nouvau_txtProvence,
                    Description = nouveau_txtDescrip,
                    Entreposage = nouvau_cmbxEntrposage,
                    Stade = nouvau_cmbxStade,
                    EtatSante = nouvau_cmbxEtatSante,
                    DateAjout = dateTime
                };

                // Ajouter la nouvelle plante au contexte et sauvegarder les modifications
                _context.plantule.Add(nouvel_plante);
                _context.SaveChanges();
            }

            ChargerListePlantules();
        }



            static string GetCategorie(string identifiant)
        {
            string categorie = new string(identifiant.TakeWhile(char.IsLetter).ToArray());
            return categorie;
            System.Windows.MessageBox.Show(categorie);
        }
        // gestion du bouton de deconnexion -------------------------------------------------------------------------
        private void btnSedeconnecter_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PageConnexion pageConnexion = new PageConnexion();
            this.Close();
            pageConnexion.Show();
        }
        
       
        private void grillesDesplantules_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }
        // gestion du bouton d'archivage -------------------------------------------------------------------------

        private void supprimerButton_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier que la DataGrid et son SelectedItem ne sont pas nulls
            if (grillesDesplantules == null)
            {
                System.Windows.MessageBox.Show("La DataGrid n'est pas initialisée.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var selcet = grillesDesplantules.SelectedItem as plantule ;
            if (selcet != null)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show($"Êtes-vous sûr de vouloir supprimer cette plante ? " +selcet.IdPlante,
                    "Confirmation",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning);



                if (result == MessageBoxResult.Yes)
                {
                   

                    try
                    {
                      

                        _archive = new PlanteContext();
                        _archive.archive.Add(selcet);

                      // Vérifiez que le contexte de base de données est initialisé
                         _context = new PlanteContext();
                        // Suppression de l'élément de la base de données
                        _context.plantule.Remove(selcet);
                        
                        // Sauvegarder les modifications dans la base de données
                        _context.SaveChanges();

                        // Optionnel: Mise à jour de la DataGrid
                        grillesDesplantules.ItemsSource = _context.plantule.ToList();
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show($"Erreur lors de la suppression de la plante: {ex.Message}",
                            "Erreur",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

            }
            else
            {
                System.Windows.MessageBox.Show("Veuillez sélectionner une plante à supprimer.",
                    "Avertissement",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void modifierButton_Click(object sender, RoutedEventArgs e)
        {
            var plantule_select = grillesDesplantules.SelectedItem as plantule;

           // var plante_modifier = _context.plantule.FirstOrDefault(p => p.IdPlante == plantule_select.IdPlante); 
            if (plantule_select != null)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show($"Souhaitez-vous modifier la plante de  " + plantule_select.Description +" ?",
                    "Confirmation",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    txtId.textBox.Text = plantule_select.IdPlante; txtId.textBox.Focus();
                    txtbxDescription.textBox.Text= plantule_select.Description;
                    txtbxProvence.textBox.Text = plantule_select.Provenance;
                    cmbxEtat.SelectedIndex = 0;
                    cmbxSatde.SelectedIndex = 0;
                    cbxEntreposage.SelectedIndex = 0;
                    // Vérifiez que le contexte de base de données est initialisé
                    _context = new PlanteContext();
                    // Suppression de l'élément de la base de données
                    _context.plantule.Remove(plantule_select);
                    _context.SaveChanges();
                    grillesDesplantules.ItemsSource = _context.plantule.ToList();

                }

            }
        }





        // gestion du bouton d'Archivage -------------------------------------------------------------------------

    }

}
