using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpexo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'un tableau d'employés
            Employe[] tableauEmployes = new Employe[3];

            // Appel de la méthode pour remplir le tableau
            RemplirTableau(tableauEmployes);

            // Affichage des informations des employés
            Console.WriteLine("\nInformations des employés :");
            foreach (var employe in tableauEmployes)
            {
                Console.WriteLine($"{employe.Prenom} {employe.Nom}, Âge : {employe.Age}, Numéro : {employe.NumeroEmploye}, Département : {employe.Departement}");
            }

            Console.ReadLine();
        }

        // Méthode pour remplir le tableau d'employés
        static void RemplirTableau(Employe[] tableauEmployes)
        {
            for (int i = 0; i < tableauEmployes.Length; i++)
            {
                // Appel de la méthode AjoutEmploye pour saisir les informations
                Employe nouvelEmploye = Employe.AjoutEmploye();

                // Ajout de l'employé dans le tableau
                tableauEmployes[i] = nouvelEmploye;
            }
        
        }
       
    }
}
