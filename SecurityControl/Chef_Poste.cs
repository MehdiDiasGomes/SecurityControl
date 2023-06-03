using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace SecurityControl
{
    public partial class Chef_Poste : Form
    {

        public Chef_Poste()
        {
            InitializeComponent();          
        }

        MySQLConnector mySQL = new MySQLConnector();

        MySqlConnection conn = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");


        private void Affichage()
        {
            richTextBox_Affichage.Text = comboBox_texte.Text;
        }

         private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Voulez-vous vraiment quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                this.Hide();
                SecurityControl Quitter = new SecurityControl();
                Quitter.Show();
                Quitter.Closed += (s, args) => this.Close();
                Quitter.Show();
            }   
            else
            {
                return;
            }

        }

        private void b_afficher_Click_1(object sender, EventArgs e)
        {
            Affichage();
        }

        private void Chef_Chantier_Load(object sender, EventArgs e)
        {
            RecupDonnes_vent();
            RecupDonnes_C1();
            RecupDonnes_C2();
            RecupDonnes_C3();
        }

        //Fonction de récupération des données
        private void RecupDonnes_C1()
        {
            //Paramètre de connexion à la base de données
            string connectionString = "server=192.168.20.20;uid=toto;password=pass;database=worldco";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //Connexion à la base de données établi
            try
            {
                conn.Open();

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

            }

            //Connexion à la base de données échoué
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Fermeture de la conexion
            conn.Close();

        }

        public void RecupDonnes_C2()
        {
            //Paramètre de connexion à la base de données
            string connectionString = "server=192.168.20.20;uid=toto;password=pass;database=worldco";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //Connexion à la base de données établi
            try
            {
                conn.Open();

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

            }

            //Connexion à la base de données échoué
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Fermeture de la conexion
            conn.Close();
        }

        public void RecupDonnes_C3()
        {
            //Paramètre de connexion à la base de données
            string connectionString = "server=192.168.20.20;uid=toto;password=pass;database=worldco";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //Connexion à la base de données établi
            try
            {
                conn.Open();

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

            }

            //Connexion à la base de données échoué
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Fermeture de la conexion
            conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Non exploité
        }

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historique Histor = new Historique();
            Histor.ImportDonnes(Temperature_data, humidite_data, CO2);
            Histor.ShowDialog();
        }

        private void Graphique_Enter(object sender, EventArgs e)
        {
            //Non exploité
        }

        private void label_hum_Click(object sender, EventArgs e)
        {
            //Non exploité
        }

        private void b_alertes_Click(object sender, EventArgs e)
        {
            FixerAlerte();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            richTextBox_Affichage.Clear();
        }

        private void FixerAlerte()
        {
            string temp = label_temp.Text;
            string hum = label_hum.Text;
            string co2 = label_co2.Text;
            MySqlConnection connection = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");           
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string sql = "INSERT INTO alertes_meteo (NiveauAlerte, Temperature, Humidite, CO2, MessageAlerte) VALUES (@NiveauAlerte, @Temperature, @Humidite, @CO2, @AlerteMessage)";
                MySqlCommand cmd = new MySqlCommand(sql, connection);               
                cmd.Parameters.AddWithValue("@Temperature", temp);
                cmd.Parameters.AddWithValue("@Humidite", hum);
                cmd.Parameters.AddWithValue("@CO2", co2);
                cmd.Parameters.AddWithValue("@AlerteMessage", richTextBox_Affichage.Text);

                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        string Temperature_data = "";
        string humidite_data = "";
        string CO2 = "";
        string vent_data = "";


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

        private void timer_bdd_Tick(object sender, EventArgs e)
        {
            RecupDonnes_vent();
            //RecupDonnes_C1();
            //RecupDonnes_C2();
            //RecupDonnes_C3(); 
        }

        public void ImportDonnes(string temp, string hum, string co2)
        {
            Temperature_data = temp;
            CO2 = co2;
            humidite_data = hum;
        }

        private void timer_graph_Tick(object sender, EventArgs e)
        {
            string x = "2"; ;
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

        private void button_c1_Click(object sender, EventArgs e)
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
    }
}
