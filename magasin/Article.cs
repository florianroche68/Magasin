using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirADO
{
    class Article
    {
        //Attributs privés //Constructeur //Accesseurs
        private int id;
        private string libelle;
        private float poids;
        private string couleur;
        private int stock;
        private float prixAchat;
        private float prixVente;
        private int idFournisseur;

        //Constructeur
        public Article(int id, string libelle, float poids, string couleur, int stock, float prixAchat, float prixVente, int idFournisseur)
        {
            this.id = id;
            this.libelle = libelle;
            this.poids = poids;
            this.stock = stock;
            this.couleur = couleur;
            this.prixAchat = prixAchat;
            this.prixVente = prixVente;
            this.idFournisseur = idFournisseur;
        }

        //Accesseurs
        public int Id { get => id; }
        public string Libelle { get => libelle; }
        public float Poids { get => poids; }
        public string Couleur { get => couleur; }
        public float PrixAchat { get => prixAchat; }
        public float PrixVente { get => prixVente; }


    }
}
