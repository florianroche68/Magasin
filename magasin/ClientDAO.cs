using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DevoirADO
{
    class ClientDAO
    {
        //Méthode qui permet de créer un objet Client à partir de son id
        public static Client getById(int id) 
        {
            string req = "SELECT * FROM Client WHERE id = " + id;
            SqlCommand cmd = new SqlCommand(req, Connexion.getInstance());
            SqlDataReader dr = null;
            Client c = null;

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = new Client(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), float.Parse(dr[6].ToString()), dr[7].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return c;
        }
    }
}
