using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    class LigneCmdDAO
    {
        //Méthode qui permet d'avoir la collection des LigneCmd d'une
        //commande dont l'id est fourni
        public static List<LigneCmd> ReadAllByCommande(int id)
        {
            List<LigneCmd> res = new List<LigneCmd>();

            string req = "SELECT * FROM LigneCmd WHERE idCommande = " + id;
            SqlCommand cmd = new SqlCommand(req, Connexion.getInstance());
            SqlDataReader dr = null;
            LigneCmd lc = null;

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lc = new LigneCmd(int.Parse(dr[0].ToString()), int.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), float.Parse(dr[3].ToString()), int.Parse(dr[4].ToString()));
                    res.Add(lc);
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
