using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire.Classes
{
    //Classe voiture
    public class Voiture
    {
        // Attributs
        private string numPlaque;
        private string marque;
        private string modele;
        private string couleur;

        // Proprietés
        public string Plaque
        {
            get
            {
                return this.numPlaque;
            }

            set
            {
                
               this.numPlaque = value;
                
            }
        }

        public string Marque
        {
            get
            {
                return this.marque;
            }

            set
            {

                this.marque = value;

            }
        }

        public string Modele
        {
            get
            {
                return this.modele;
            }

            set
            {

                this.modele = value;

            }
        }

        public string Couleur
        {
            get
            {
                return this.couleur;
            }

            set
            {

                this.couleur = value;

            }
        }

        // Constructeurs
        public Voiture(string Plaq, string Marq, string Model, string coul)
        {
            this.numPlaque = Plaq;
            this.marque= Marq;
            this.modele = Model;
            this.couleur = coul;
        }
        // La méthode ToString
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t",this.numPlaque,this.marque,this.modele,this.couleur);
        }
    }

    
}
