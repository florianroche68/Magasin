using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    class TypeClientDAO
    {
        //Méthode qui permet de créer un objet TypeClient avec son code
        public static TypeClient getByCode(string code)
        {
            string req = "SELECT * FROM TypeClient WHERE code = '" + code + "'";
            SqlCommand cmd = new SqlCommand(req, Connexion.getInstance());
            SqlDataReader dr = null;
            TypeClient tc = null;

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tc = new TypeClient(dr[0].ToString(), dr[1].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return tc;
        }
    }
}
