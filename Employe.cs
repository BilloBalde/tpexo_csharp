using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpexo1
{
    internal class Employe : Personne
    {
        // Attributs spécifiques à la classe Employe
        public int NumeroEmploye { get; set; }
        public string Departement { get; set; }

        // Constructeur de la classe Employe
        public Employe(string prenom, string nom, int age, int numeroEmploye, string departement)
            : base(prenom, nom, age)
        {
            NumeroEmploye = numeroEmploye;
            Departement = departement;
        }

        // Méthode pour saisir les informations d'un employé
        public static Employe AjoutEmploye()
        {
            Console.WriteLine("Saisir les informations de l'employé :");

            Console.Write("Prénom : ");
            string prenom = Console.ReadLine();

            Console.Write("Nom : ");
            string nom = Console.ReadLine();

            Console.Write("Âge : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Numéro de l'employé : ");
            int numeroEmploye = int.Parse(Console.ReadLine());

            Console.Write("Département : ");
            string departement = Console.ReadLine();

            return new Employe(prenom, nom, age, numeroEmploye, departement);
        }
    }
}
