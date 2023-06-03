using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SecurityControl
{
    public partial class Technicien : Form
    {
        public Technicien()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Voulez-vous vraiment quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Hide();
                SecurityControl Retour = new SecurityControl();
                Retour.Show();
                Retour.Closed += (s, args) => this.Close();
                Retour.Show();
            }
            else
            {
                return;
            }
        }

        private void Technicien_Load(object sender, EventArgs e)
        {
            RecupDonnes_vent();
            Central1();
        }

        private void RecupDonnes_vent()
        {
            string connectionString = "server=192.168.20.20;uid=toto;password=pass;database=worldco";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                string query = "SELECT vent FROM vent;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    vent_data = reader["vent"].ToString();
                }

                label_vent.Text = vent_data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        string Temperature_data = "";
        string humidite_data = "";
        string CO2 = "";
        string vent_data = "";

        private void button_c1_Click(object sender, EventArgs e)
        {
            Central1();
        }

        private void Central1()
        {
            conn.Open();

            label_centrale.Text = "Centrale n°1";
            label_centrale.Visible = true;

            //Requête SQL permettant de lire les valeurs stockées dans les champs
            string query = "SELECT Temperature, Humidite, CO2 FROM info_meteo;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            //Lire dans la base de données 
            while (reader.Read())
            {
                Temperature_data = reader["Temperature"].ToString();
                humidite_data = reader["Humidite"].ToString();
                CO2 = reader["CO2"].ToString();
            }

            //Assignation des valeurs lues dans les labels dédiés
            label_temp.Text = Temperature_data.ToString() + "°C";
            label_hum.Text = humidite_data.ToString() + "%";
            label_co2.Text = CO2.ToString() + "ppm";

            // Fermeture de la connexion à la base de données
            conn.Close();
        }

        private void button_c2_Click(object sender, EventArgs e)
        {
            conn.Open();
            label_centrale.Text = "Centrale n°2";
            label_centrale.Visible = true;

            //Requête SQL permettant de lire les valeurs stockées dans les champs
            string query = "SELECT Temperature, Humidite, CO2 FROM info_meteo1;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            //Lire dans la base de données 
            while (reader.Read())
            {
                Temperature_data = reader["Temperature"].ToString();
                humidite_data = reader["Humidite"].ToString();
                CO2 = reader["CO2"].ToString();
            }

            //Assignation des valeurs lues dans les labels dédiés
            label_temp.Text = Temperature_data.ToString() + "°C";
            label_hum.Text = humidite_data.ToString() + "%";
            label_co2.Text = CO2.ToString() + "ppm";

            // Fermeture de la connexion à la base de données
            conn.Close();
        }

        private void button_c3_Click(object sender, EventArgs e)
        {
            conn.Open();

            label_centrale.Text = "Centrale n°3";
            label_centrale.Visible = true;

            //Requête SQL permettant de lire les valeurs stockées dans les champs
            string query = "SELECT Temperature, Humidite, CO2 FROM info_meteo2;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            //Lire dans la base de données 
            while (reader.Read())
            {
                Temperature_data = reader["Temperature"].ToString();
                humidite_data = reader["Humidite"].ToString();
                CO2 = reader["CO2"].ToString();
            }

            //Assignation des valeurs lues dans les labels dédiés
            label_temp.Text = Temperature_data.ToString() + "°C";
            label_hum.Text = humidite_data.ToString() + "%";
            label_co2.Text = CO2.ToString() + "ppm";

            // Fermeture de la connexion à la base de données
            conn.Close();
        }

        private int x = 0;

        private void timer_graph_Tick(object sender, EventArgs e)
        {

            string x = "2";            ;
            string temperature = Temperature_data;
            string co2 = CO2;
            string hum = humidite_data;
            string vent = vent_data;

            chart_temp.Series[0].Points.AddXY(x, temperature); // Ajouter un point au graphique avec les valeurs x et y
            chart_hum.Series[0].Points.AddXY(x, hum); // Ajouter un point au graphique avec les valeurs x et y
            chart_vitesse.Series[0].Points.AddXY(x, vent); // Ajouter un point au graphique avec les valeurs x et y
            chart_co2.Series[0].Points.AddXY(x, co2); // Ajouter un point au graphique avec les valeurs x et y

            // Actualiser le graphique
            chart_temp.Update();
          
        }      
    }
}
