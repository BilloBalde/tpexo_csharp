using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpexo1
{
    internal class Personne
    {
            // Attributs de la classe Personne
            public string Prenom { get; set; }
            public string Nom { get; set; }
            public int Age { get; set; }

            // Constructeur de la classe Personne
            public Personne(string prenom, string nom, int age)
            {
                Prenom = prenom;
                Nom = nom;
                Age = age;
            }
        
    }
}
