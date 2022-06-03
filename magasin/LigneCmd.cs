using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    class LigneCmd
    {
        //Attributs privés
        private int idCommande;
        private int idArticle;
        private int quantite;
        private float pv;
        private int quantiteLivree;
        
        // Constructeur
        public LigneCmd(int idCommande, int idArticle, int quantite, float pv, int quantiteLivree)
        {
            this.idCommande = idCommande;
            this.idArticle = idArticle;
            this.quantite = quantite;
            this.pv = pv;
            this.quantiteLivree = quantiteLivree;
        }

        //Accesseurs
        public int IdCommande { get => idCommande; }
        public int IdArticle { get => idArticle; }
        public int Quantite { get => quantite; }
        public float Pv { get => pv; }
        public int QuantiteLivree { get => quantiteLivree;}

        //Méthode qui renvoie la montant d'une ligne de commande
        public float GetTotal()
        { 
            return this.pv * this.quantite;
        }

        // Méthode qui renvoie une description d'une ligneCmd sous la forme
        // d'une ligne au format idArticle + libelleArticle + quantite + prixUnitaire + total
        public string ToLine()
        {
            Article a = ArticleDAO.getById(this.idArticle);

            string res = a.Id + "\t" + a.Libelle.PadRight(30) + this.quantite + "\t" + this.pv + "\t\t" + this.GetTotal().ToString("#0.00");
            return res;
        }
    }
}
