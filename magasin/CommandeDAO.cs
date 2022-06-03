using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirADO
{
    class CommandeDAO
    {
        //Méthode qui permet de créer un objet Commande à partir de son id
        public static Commande getById(int id)
        {
            string req = "SELECT * FROM Commande WHERE id = " + id;
            SqlCommand cmd = new SqlCommand(req, Connexion.getInstance());
            SqlDataReader dr = null;
            Commande c = null;

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = new Commande(int.Parse(dr[0].ToString()), dr[1].ToString(), int.Parse(dr[2].ToString()), int.Parse(dr[3].ToString()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return c;
        }

        //Méthode qui permet d'avoir la liste des commandes sous la forme d'une liste
        // de string au format id-dateC
        // La liste est triée par date de commande croissante
        public static List<string> GetListe() 
        {
            List<string> res = new List<string>();

            string req = "SELECT * FROM Commande ORDER BY dateC";
            SqlCommand cmd = new SqlCommand(req, Connexion.getInstance());
            SqlDataReader dr = null;
            Commande c = null;

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    c = new Commande(int.Parse(dr[0].ToString()), dr[1].ToString(), int.Parse(dr[2].ToString()), int.Parse(dr[3].ToString()));
                    res.Add(c.Id.ToString() + "-" + c.DateC);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;

        }
    }
}
