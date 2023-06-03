using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityControl
{
    internal class Authentification
    {

        public bool Connecté = false;

        public string VerifId(string Id)
        {
            string Identifiant = "";

        MySqlConnection cn = new MySqlConnection("database=worldco; port=3306; server=192.168.20.20; user id=toto; pwd=;");

            try
            {
                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                Connecté = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connecté = false;
            }

            if (Connecté)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM authentification WHERE Identifiant=@id AND Mot_de_passe=@mdp;", cn);
                cmd.Parameters.AddWithValue("@id", Identifiant);

                cmd.ExecuteNonQuery();
                cn.Close();

               
            }
            return Identifiant;
           
        }

        public string VerifMdp(string Mdp)
        {
            string Mot_de_passe = "";

            MySqlConnection cn = new MySqlConnection("database=worldco; port=3306; server=192.168.20.20; user id=toto; pwd=;");

            try
            {
                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                Connecté = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connecté = false;
            }

            if (Connecté)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM authentification WHERE Identifiant=@id AND Mot_de_passe=@mdp;", cn);
                cmd.Parameters.AddWithValue("@mdp", Mot_de_passe);                                                                                                                                                        

                cmd.ExecuteNonQuery();
                cn.Close();


            }
            
            return Mot_de_passe;
        }


    }
}
