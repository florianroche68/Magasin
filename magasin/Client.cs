using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirADO
{
    class Client
    {
        //Attributs privés
        private int id;
        private string nom;
        private string prenom;
        private string mail;
        private string pays;
        private string localite;
        private float ca;
        private string codeTypeClient;

         //Constructeur
        public Client(int id, string nom, string prenom, string mail, string pays, string localite, float ca, string codeTypeClient)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.pays = pays;
            this.localite = localite;
            this.ca = ca;
            this.codeTypeClient = codeTypeClient;
        }

        //Accesseurs
        public int Id { get => id;}
        public string Nom { get => nom; }
        public string Prenom { get => prenom;  }
        public string Mail { get => mail;  }
        public string Pays { get => pays;  }
        public string Localite { get => localite;  }
        public float Ca { get => ca;  }
        public string CodeTypeClient { get => codeTypeClient; }

        //Méthode qui renvoie une description d'un client sous la forme
        // d'une ligne au format   Client n° id + nom + localite + (libelle type client)
        public string ToLine()
        {
            string description = "";
            TypeClient leType = TypeClientDAO.getByCode(codeTypeClient);

            description += "Client n°" + this.id + "\t" + this.nom + " " + this.localite + " " + leType.Libelle;

            return description;
        }
    }
}
