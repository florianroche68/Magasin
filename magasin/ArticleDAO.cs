using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirADO
{
    class ArticleDAO
    {
        //Méthode qui permet de créer un objet Article à partir de son id
        public static Article getById(int id)
        {
            string req = "SELECT * FROM Article WHERE id = " + id;
            SqlCommand cmd = new SqlCommand(req, Connexion.getInstance());
            SqlDataReader dr = null;
            Article a = null;

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    a = new Article(int.Parse(dr[0].ToString()), dr[1].ToString(), float.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString()), float.Parse(dr[5].ToString()), float.Parse(dr[6].ToString()), int.Parse(dr[7].ToString()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return a;
        }
    }
}
