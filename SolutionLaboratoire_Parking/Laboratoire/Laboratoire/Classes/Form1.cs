using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratoire.Classes;

namespace Laboratoire
{

    public partial class Formulaire : Form
    {
        Parking p;
        Voiture v;
        List<Place> listplaces = new List<Place>();
        
        public Formulaire()
        {

            InitializeComponent();

        }
        // Effacer les textBox
        private void Effacer_TextBoxs()
        {
            textBoxNumeroPlaque.Clear();
            textBoxMarque.Clear();
            textBoxModele.Clear();
            textBoxCouleur.Clear();
        }
        private void btn_CreerParking_Click(object sender, EventArgs e)
        {
            //Créer la liste de places selon le nombre de places
            //que prend le parking
            for (int i = 1; i <= Convert.ToInt32(textBoxTaille.Text); i++)
            {
                Place pl = new Place(i, true, DateTime.Now, null);
                listplaces.Add(pl);
            }
            //Créer l'instance de la classe Parking
            p = new Parking(listplaces, Convert.ToInt32(textBoxTaille.Text), textBoxNomParking.Text);
            //Activer les boutons Afficher parking et Entrer voiture
            btnAfficherParking.Enabled = true;
            btnEntrerVoiture.Enabled = true;
            // Désactiver le bouton qui permet de créer un parking
            btnCreerParking.Enabled = false;
            // Effacer et désactiver les textBox
            textBoxNomParking.Clear();
            textBoxNomParking.Enabled = false;
            textBoxTaille.Clear();
            textBoxTaille.Enabled = false;
        }

        
        private void btnAfficherParking_Click(object sender, EventArgs e)
        {
            
            string s = "Nom du parking: " + p.Nom + "\n"
                + "Nombre de places: " + p.TailleMax + "\n";
            bool vide = true;
            foreach (Place p in listplaces)
            {
                if (p.Etat == false)
                {
                    s += "Matricule : " + p.Voiture + " Place : " + p.Numero + "\n";
                    vide = false;
                }
            }
            if (vide == true)
                s += "Le Parking est vide";
            MessageBox.Show(s, "Info Parking ");
        }

        private void btnEntrerVoiture_Click(object sender, EventArgs e)
        {
            v = new Voiture(textBoxNumeroPlaque.Text, textBoxMarque.Text, textBoxModele.Text, textBoxCouleur.Text);
            int num = p.EntrerVoiture(v);
            if (num == -1)
            {
                MessageBox.Show("Le parking est plein!", "Info Parking");
                btnEntrerVoiture.Enabled = false;
            }
            else if (num == -2)
                MessageBox.Show("Erreur dans le numéro de plaque", "Info Parking");
            else
            {
                string s = "Numéro de plaque : " + v.Plaque + "\n";
                s += "Numéro de place : " + num;
                MessageBox.Show(s, "Info Parking");
                btnSortirVoiture.Enabled = true;
            }
            Effacer_TextBoxs();
        }

        private void SortirVoiture_Click(object sender, EventArgs e)
        {
            if (p.RechercherVoiture(textBoxNumeroPlaque.Text) != null)
            {
                TimeSpan t = p.SortirVoiture(textBoxNumeroPlaque.Text);
                string s = "";
                s += "La durée du séjour de la voiture " + v.Plaque + " : " + t.Hours + " h " + t.Minutes + " min " + t.Seconds + " s"
                ;
                MessageBox.Show(s, "Durée");
                // Activer le bouton btnEntrerVoiture
                btnEntrerVoiture.Enabled = true;
                // Si le parking est vide, afficher un messagee t désactiver btnSortirVoiture
                int i = 0;
                foreach (Place elt in listplaces)
                    if (elt.Etat == true) i++;
                if (i == listplaces.Count)
                {
                    MessageBox.Show("Le parking est vide!", "Message");
                    
                    btnSortirVoiture.Enabled = false;
                }
            }
            else MessageBox.Show("Cette voiture n'est pas dans le parking.", "Durée");
            Effacer_TextBoxs();
        }

        
    }

}    