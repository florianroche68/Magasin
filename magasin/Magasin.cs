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
    }
}
