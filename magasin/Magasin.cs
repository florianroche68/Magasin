using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    class Magasin
    {
        private int id;
        private string localite;
        private string gerant;

        //Constructeur
        public Magasin(int id, string loc, string ger)
        {
            this.id = id;
            this.localite = loc;
            this.gerant = ger;
        }

        //Accesseurs
        public int Id { get => id; set => id = value; }
        public string Localite { get => localite; set => localite = value; }
        public string Gerant { get => gerant; set => gerant = value; }

        // Méthode qui renvoie une description d'un client sous la forme
        // d'une ligne au format Magasin n° id + localite + Gérant : gerant
        public string ToLine()
        {
            string res = "Magasin n° " + this.id + "\t" + this.localite + "\tGérant : " + this.gerant;
            return res;
        }
    }
}
