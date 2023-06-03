using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace SecurityControl
{
    public partial class Superviseur_login_new : Form
    {
      
        public Superviseur_login_new()
        {
            InitializeComponent();
        }

        public bool Connecté = false;
        public void connection()
        {

            string Identifiant = textBox1.Text;
            string Mot_de_passe =textBox2.Text;

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
                    while(reader.Read())
                    {
                        string Fonction = reader["Fonction"].ToString();
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
                New Nouveau = new New();
                Nouveau.Show();
                Nouveau.Closed += (s, args) => this.Close();
                Nouveau.Show();
                cn.Close();
            }

        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            //connection();
            this.Hide();
            New Nouveau = new New();
            Nouveau.Show();
            Nouveau.Closed += (s, args) => this.Close();
            Nouveau.Show();
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
