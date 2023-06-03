using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace SecurityControl
{
    public partial class Superviseur_login : Form
    {
      
        public Superviseur_login()
        {
            InitializeComponent();
        }

        MySqlConnection cn = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");

        public bool Connecté = false;

        string Identifiant = "";
        string Mot_de_passe ="";
        public void connection()
        {

             Identifiant = textBox1.Text;
             Mot_de_passe =textBox2.Text;
             string Fonction = "";
             string Desc = "Connexion au compte " + Identifiant;


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
                    while(reader.Read())
                    {
                        Fonction = reader["Fonction"].ToString();
                        if (Fonction != "Chef de chantier")
                        {
                            id_incorrect.Visible = true;                      
                            return;
                        }
                    }
                }

                var result = cmd.ExecuteScalar();
                if (result == null)
                {
                    id_incorrect.Visible = true;
                    return;
                }
               
                this.Hide();
                Chef_Chantier Superviseur = new Chef_Chantier();
                Superviseur.Show();
                Superviseur.Closed += (s, args) => this.Close();
                Superviseur.Show();


                string query = "INSERT INTO Log (Description, Source ) VALUES (@Desc, @Source)";
                MySqlCommand cmd1 = new MySqlCommand(query, cn);
                cmd1.Parameters.AddWithValue("@Desc", Desc);
                cmd1.Parameters.AddWithValue("@Source", Fonction);

                cmd1.ExecuteNonQuery();

                cn.Close();
            }

        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            connection();
            this.Hide();
            Chef_Chantier Superviseur = new Chef_Chantier();
            Superviseur.Show();
            Superviseur.Closed += (s, args) => this.Close();
            Superviseur.Show();

            cn.Open();

        }

        private void Superviseur_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              this.Hide();
            SecurityControl Retour = new SecurityControl();
            Retour.Show();
            Retour.Closed += (s, args) => this.Close();
            Retour.Show();     
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
