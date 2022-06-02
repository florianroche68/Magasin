using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace magasin
{
    class MagasinDAO
    {
        // Mise en place du Create
        public static void Create(Magasin m)
        {
            int res;
            //Requête de type INSERT INTO
            string req = "INSERT INTO Magasin VALUES(" + m.Id + ",'" + m.Localite + "','" + m.Gerant + "')";
            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            try
            {
                //On exécute la commande
                res = com.ExecuteNonQuery();

                //Libération de la commande
                com = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Mise en place du Update
        public static Boolean Update(Magasin m)
        {
            int nbLigne = 0;
            Boolean res = false;
            //Requête de type UPDATE
            string req = "UPDATE Magasin " +
                         "SET localite = '" + m.Localite + "'," +
                         "gerant = '" + m.Gerant + "' " +
                         "WHERE id = " + m.Id;

            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            try
            {
                nbLigne = com.ExecuteNonQuery();
                if (nbLigne > 0)
                {
                    res = true;
                }

                //Libération de la commande
                com = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;
        }

        //Mise en place du Delete
        public static Boolean Delete(Magasin m)
        {
            int nbLigne = 0;
            Boolean res = false;
            //Requête de type DELETE
            string req = "DELETE FROM Magasin " +
                         "WHERE id = " + m.Id;

            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            try
            {
                //Exécution de la commande
                nbLigne = com.ExecuteNonQuery();
                if (nbLigne > 0)
                {
                    res = true;
                }

                //Libération de la commande
                com = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;
        }

        //Mise en place du FinfById
        public static Magasin FindById(int id)
        {
            SqlDataReader dr;
            Magasin res = null;

            //Requête de type SELECT
            string req = "SELECT * FROM Magasin " +
                         "WHERE id = " + id;

            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            try
            {
                //Exécution de la commande et récupération du curseur
                dr = com.ExecuteReader();

                //Si le curseur est non vide
                if (dr.Read())
                {
                    //Instanciation de l'objet Magasin
                    res = new Magasin(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString());
                }

                //Libération de la commande et du dataReader
                com = null;
                dr.Close();
                dr = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;

        }

        //Mise en place du ReadAll
        public static List<Magasin> ReadAll()
        {
            SqlDataReader dr;
            Magasin m;
            List<Magasin> res;

            //Création de la collection
            res = new List<Magasin>();

            //Requête de type SELECT *
            string req = "SELECT * FROM Magasin";

            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            try
            {
                //Exécution de la commande et récupération du curseur
                dr = com.ExecuteReader();

                //TQ qu'il y aquelque chose à lire dans le curseur
                while (dr.Read())
                {
                    //On recherche le Magasin correpondant avec FindById
                    m = FindById(int.Parse(dr[0].ToString()));

                    //On ajoute l'objet créé à la collection
                    res.Add(m);
                }

                //Libération de la commande et du dataReader
                com = null;
                dr.Close();
                dr = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;
        }
    }
}
