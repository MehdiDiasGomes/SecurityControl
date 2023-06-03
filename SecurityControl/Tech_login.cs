using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SecurityControl
{
    public partial class Tech_login : Form
    {
        public Tech_login()
        {
            InitializeComponent();
        }

        public bool Connecté = false;
        public void connection()
        {
            string Identifiant = textBox_id.Text;
            string Mot_de_passe = textBox_mdp.Text;
          
            string Fonction = "";
            string Desc = "Connexion au compte " + Identifiant;

            MySqlConnection cn = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");

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

            if (Connecté == true)
            {
                string requete = "SELECT * FROM authentification WHERE Identifiant='" + Identifiant + "' AND Mot_de_passe='" + Mot_de_passe + "';";
                MySqlCommand cmd = new MySqlCommand(requete, cn);
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fonction = reader["Fonction"].ToString();
                        if (Fonction != "Technicien")
                        {
                            //MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            id_incorrect.Visible = true;
                            return;
                        }
                    }
                }

                var result = cmd.ExecuteScalar();
                if (result == null)
                {
                    //MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    id_incorrect.Visible = true;
                    return;
                }

              

                    this.Hide();
                    Technicien Tec = new Technicien();
                    Tec.Show();
                    Tec.Closed += (s, args) => this.Close();
                    Tec.Show();


                string query = "INSERT INTO Log (Description, Source ) VALUES (@Desc, @Source)";
                MySqlCommand cmd1 = new MySqlCommand(query, cn);
                cmd1.Parameters.AddWithValue("@Desc", Desc);
                cmd1.Parameters.AddWithValue("@Source", Fonction);

                cmd1.ExecuteNonQuery();
                cn.Close();
            }

        }

        private void button_connect_Click_1(object sender, EventArgs e)
        {
            connection();
            //this.Hide();
            //Technicien Tec = new Technicien();
            //Tec.Show();
            //Tec.Closed += (s, args) => this.Close();
            //Tec.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecurityControl Retour = new SecurityControl();
            Retour.Show();
            Retour.Closed += (s, args) => this.Close();
            Retour.Show();
        }
    }
}
