using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magasin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> liste = CommandeDAO.GetListe();
            foreach (string s in liste)
            {
                cboCommande.Items.Add(s);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string valTxtNumero = txtNumero.Text;

            if (valTxtNumero == "")
            {
                MessageBox.Show("Veuillez entrer un numéro");
            } 
            else
            {
                int id = int.Parse(txtNumero.Text);

                Magasin m = MagasinDAO.FindById(id);

                if (m == null)
                {
                    MessageBox.Show("Ce magasin n'est pas répertorié");
                }
                else
                {
                    txtLocalite.Text = m.Localite;
                    txtGerant.Text = m.Gerant;
                }

            }
            
            

        }

        private void btnMagasin_Click(object sender, EventArgs e)
        {
            string liste = "Liste des magasins\n";
            liste = liste + "______________________\n";

            foreach (Magasin m in MagasinDAO.ReadAll())
            {
                liste = liste + m.Id + "\t" + m.Localite + "\n";
            }
            MessageBox.Show(liste);
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            string valTxtNumero = txtNumero.Text;
            string loc = txtLocalite.Text;
            string ger = txtGerant.Text;
            bool alreadyExist = false;

            if(valTxtNumero == "" || loc == "" || ger == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs (Numéro, Localité et Gérant");
            }
            else
            {
                foreach (Magasin ma in MagasinDAO.ReadAll())
                {
                    if(int.Parse(valTxtNumero) == ma.Id)
                    {
                        alreadyExist = true;
                    }
                }

                if(alreadyExist)
                {
                    MessageBox.Show("Un magasin portant ce numéro existe déjà");
                }
                else
                {
                    int id = int.Parse(txtNumero.Text);

                    Magasin m = new Magasin(id, loc, ger);
                    MagasinDAO.Create(m);
                }
                
            }

            

        }

        private void btnMaj_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs (Numéro, Localité et Gérant");
            }
            else
            {
                int id = int.Parse(txtNumero.Text);
                string loc = txtLocalite.Text;
                string ger = txtGerant.Text;

                if (id == 0 || loc == "" || ger == "")
                {
                    MessageBox.Show("Veuillez renseigner tous les champs (Numéro, Localité et Gérant");
                }

                Magasin m = new Magasin(id, loc, ger);

                bool ok = MagasinDAO.Update(m);
                if (ok)
                {
                    MessageBox.Show("Mise à jour réalisée");
                }
                else
                {
                    MessageBox.Show("Mise à jour échouée");
                }
            }
            


        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            Boolean res;
            Magasin m = new Magasin(int.Parse(txtNumero.Text), txtLocalite.Text, txtGerant.Text);

            res = MagasinDAO.Delete(m);
            if (!res)
            {
                MessageBox.Show("Erreur de suppression");
            }
            else
            {
                MessageBox.Show("Suppression effectuée");
                txtNumero.Clear();
                txtLocalite.Clear();
                txtGerant.Clear();
            }

        }

        private void cboCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temp = cboCommande.SelectedItem.ToString().Split('-');
            int id = int.Parse(temp[0]);
            Commande c = CommandeDAO.getById(id);
            MessageBox.Show(c.ToString(), "Détail de la commande n°" + id);
        }
    }
}
