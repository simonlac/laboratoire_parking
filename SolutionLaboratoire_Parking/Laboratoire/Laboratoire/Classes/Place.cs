using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire.Classes
{
        //Classe Place
        public class Place
        {
        // Attributs
            private int numero;     // le numéro de la place
            private bool etat;      // true pour libre et false pour occupée
            private DateTime heure; // représente la date et l'heure d'entrée de la voiture		
            private Voiture voiture;    // la voiture qui l'occupe

        
            // Proprietés
            public int  Numero
            {
                get
                {
                    return this.numero;
                }

                set
                {

                    this.numero = value;

                }
            }

            public bool Etat
            {
                get
                {
                    return this.etat;
                }

                set
                {

                    this.etat = value;

                }
            }

            public DateTime Heure
            {
                get
                {
                    return this.heure;
                }

                set
                {

                    this.heure = value;

                }
            }

            public Voiture Voiture
            {
                get
                {
                    return this.voiture;
                }

                set
                {

                    this.voiture = value;

                }
            }

            // Constructeurs
            public Place(int  num, bool et, DateTime heur, Voiture voit)
            {
                this.numero = num;
                this.etat =et;
                this.heure = heur;
                this.voiture = voit;
            }
            // La méthode ToString
            public override string ToString()
            {
                return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t", this.numero, this.etat, this.heure, this.voiture.Plaque, this.voiture.Marque,this.voiture.Modele,this.voiture.Couleur);
            }
        }


    }


