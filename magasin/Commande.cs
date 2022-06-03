using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    class Commande
    {
        //Attributs privés
        private int id;
        private string dateC;
        private int idClient;
        private int idMagasin;

        // Constructeur
        public Commande(int id, string dateC, int idClient, int idMagasin)
        {
            this.id = id;
            this.dateC = dateC;
            this.idClient = idClient;
            this.idMagasin = idMagasin;
        }

        //Accesseurs
        public int Id { get => id;}
        public string DateC { get => dateC; }
        public int IdClient { get => idClient;}
        public int IdMagasin { get => idMagasin; }

        // Méthode qui renvoie une description d'une commande sous la forme
        // d'une ligne au format Commande n° id + du date
        public string ToLine()
        {
            string res = "Commande n° " + this.id + "\t\t" + "du " + this.dateC;
            return res;
        }


        // Méthode qui renvoie une chaine qui décrit une commande
        // au format attendu dans le sujet...
        override
        public string ToString()
        {
            string descriptionCommande = "";
            Client leClient = ClientDAO.getById(idClient);
            Magasin leMagasin = MagasinDAO.getById(IdMagasin);
            List<LigneCmd> listLigneCmd = LigneCmdDAO.ReadAllByCommande(id);
            float total = 0;
            Console.WriteLine("id commande :" + id + " -- listLigneCmd.Count.ToString() :" + listLigneCmd.Count.ToString());

            descriptionCommande += "-------------------------------------------------------------------------------------------\n" +
                this.ToLine() + "\n" +
                leClient.ToLine() + "\n" +
                leMagasin.ToLine() + "\n" +
                "-------------------------------------------------------------------------------------------\n" +
                "N° article\t Libellé \t\t Quantité  Prix Unitaire \t Total ligne \n" +
                "-------------------------------------------------------------------------------------------\n";
            foreach (LigneCmd l in listLigneCmd)
            {
                descriptionCommande += l.ToLine() + "\n";
                Console.WriteLine(l.ToLine());
                total += l.GetTotal();
            }
            descriptionCommande += "-------------------------------------------------------------------------------------------\n" + 
                "\t\t\t\t\t\t Total " + total + "€\n" +
                "-------------------------------------------------------------------------------------------";

            return descriptionCommande;
        }
    }
}
