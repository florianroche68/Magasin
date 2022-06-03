using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    class TypeClient
    {
        //Attributs privés
        private string code;
        private string libelle;

        //Constructeur
        public TypeClient(string code, string libelle)
        {
            this.code = code;
            this.libelle = libelle;
        }

        //Accesseurs
        public string Code { get => code; }
        public string Libelle { get => libelle;}
    }
}
