using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratoire.Classes;

namespace Laboratoire.Classes
{

    public class Parking
    {
        //Attributs
        private List<Place> listePlaces;    //  la liste des places 
        private int tailleMax;      //  le nombre maximum de places dans le parking 
        private string nom;         // le nom du parking
        // Proprietés à compléter
        public List<Place> ListePlaces
        {
            get
            {
                return this.listePlaces;
            }

            set
            {

                this.listePlaces = value;

            }
        }

        public int TailleMax
        {
            get
            {
                return this.tailleMax;
            }

            set
            {

                this.tailleMax = value;

            }
        }
        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {

                this.nom = value;

            }
        }

        //Constructeur
        public Parking(List<Place> lPlaces, int tMax, string nomParking)
        {
            this.listePlaces = lPlaces;
            this.tailleMax = tMax;
            this.nom = nomParking;

        }
        //Méthodes
        // Méthode qui renvoie true si le parking est plein sinon elle renvoie false
        public bool IsPlein()
        {
            int placesOccupe = 0;
            foreach (Place elt in listePlaces)
                if (elt.Etat == false) // Place occupée
                    placesOccupe+=1;
            if (placesOccupe == listePlaces.Count)
                return true;
            else return false;
            
        }
        // Compléter la documentation pour toutes les méthodes
        /// <summary>
        /// Retourne la place occupée par la voiture qui possède le numéro entré ou null si la voiture n'existe pas.
        /// </summary>
        /// <param name="numplaque"> Contient le numéro de plaque de la voiture recherchée</param>
        /// <returns></returns>
        public Place RechercherVoiture(string numplaque) 
        {
            foreach (Place elt in listePlaces)
                if (elt.Voiture!= null && elt.Voiture.Plaque == numplaque) 
                    return elt;
            return (null);
        }
        // Documentation à ajouter ici...
        // Cette méthode affecte une place dans le parking à la voiture
        // et retourne le numéro de cette place  si une place est disponible
        // sinon elle retourne la valeur -1.
        //Elle retourne -2 si une voiture avec le même numéro d'immatriculation est déjà dans le parking
        //Elle doit aussi mettre à jour les propriétés de la place affectée.
        
        public int EntrerVoiture(Voiture v)     {
            //Voiture avec le même numéro d'immatriculation dans le parking
            if (RechercherVoiture(v.Plaque) != null)
                return (-2);
            else
                // Ajouter la voiture au parking
                foreach (Place elt in listePlaces)
                {
                    if (elt.Etat == true) //Place disponible
                    {
                        elt.Etat = false;
                        elt.Voiture = v;
                        elt.Heure = DateTime.Now;
                        return (elt.Numero);
                    }
                }
            //Parking plein
            return (-1);
        }
         
        /// <summary>
        /// Libère la place occupée par la voiture
        /// </summary>
        /// <param name="numplaque"> Numéro de plaque de la voiture à sortir</param>
        /// <returns> La durée de présence de la voiture dans le parking ou 0 si voiture introuvable</returns>
        public TimeSpan SortirVoiture(string numplaque)
        {
            TimeSpan Duree;
            Place pl = RechercherVoiture(numplaque);
            if (pl!= null)
                {
                 pl.Etat = true;// Libérer la place
                 pl.Voiture = null;
                 Duree = DateTime.Now - pl.Heure;
                 pl.Heure = DateTime.MinValue;
                 return Duree;
                }
            Duree = DateTime.Now - DateTime.Now;
            return (Duree);
        }
        // Retourne la liste des places occupées du parking.
        public List<Place> GetPlaces()
        
        {
            List<Place> listePlaces_occ =new List<Place>();
            foreach (Place elt in listePlaces)
                if (elt.Etat == false)
                    listePlaces_occ.Add(elt);
            

         return listePlaces_occ;
        }

    }

    

}
