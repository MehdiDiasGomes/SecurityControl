using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SecurityControl
{
    public partial class Historique : Form
    {
        public Historique()
        {
            InitializeComponent();
        }


        string Temperature_data = "";
        string humidite_data = "";
        string CO2 = "";
        string Time = "";

        public void ImportDonnes(string temp, string hum, string co2)
        {
            Temperature_data = temp;
            humidite_data = hum;
            CO2 = co2;
        }

        private void Histor1()
        {
            
            // Connexion à la base de données           
            MySqlConnection conn = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");

            conn.Open();

            // Création d'un adaptateur de données pour exécuter la requête SQL et remplir un DataSet
            string sql = "SELECT DateHeure, Temperature, Humidite, CO2 FROM info_meteo1";

            // Création d'un adaptateur de données pour exécuter la requête SQL et remplir un DataSet
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "info_meteo1");

            // Affichage des données dans un DataGridView
            dataGrid_meteo.DataSource = dataset.Tables["info_meteo"];

            // Fermeture de la connexion à la base de données
            conn.Close();

        }

        private void Histor2()
        {

            // Connexion à la base de données
            MySqlConnection conn = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");

            conn.Open();

            // Requête SQL pour récupérer les données de la table "info_meteo"
            string sql = "SELECT DateHeure, Temperature, Humidite, CO2 FROM info_meteo1";

            // Création d'un adaptateur de données pour exécuter la requête SQL et remplir un DataSet
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "info_meteo1");

            // Affichage des données dans un DataGridView
            dataGrid_meteo.DataSource = dataset.Tables["info_meteo1"];

            // Fermeture de la connexion à la base de données
            conn.Close();
        }

        private void Histor3()
        {

            // Connexion à la base de données

            MySqlConnection conn = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");

            conn.Open();

            // Requête SQL pour récupérer les données de la table "info_meteo"
            string sql = "SELECT DateHeure, Temperature, Humidite, CO2 FROM info_meteo2";

            // Création d'un adaptateur de données pour exécuter la requête SQL et remplir un DataSet
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "info_meteo2");

            // Affichage des données dans un DataGridView
            dataGrid_meteo.DataSource = dataset.Tables["info_meteo2"];

            // Fermeture de la connexion à la base de données
            conn.Close();
        }

        private void HistorAlerte()
        {

            // Connexion à la base de données

            MySqlConnection conn = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");

            conn.Open();

            // Requête SQL pour récupérer les données de la table "info_meteo"
            string sql = "SELECT DateHeure, NiveauAlerte, Temperature, Humidite, CO2 FROM alertes_meteo";

            // Création d'un adaptateur de données pour exécuter la requête SQL et remplir un DataSet
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "alertes_meteo");

            // Affichage des données dans un DataGridView
            dataGridView_alerte.DataSource = dataset.Tables["alertes_meteo"];

            // Fermeture de la connexion à la base de données
            conn.Close();

        }

        private void Historique_Shown(object sender, EventArgs e)
        {
           //Non exploité               
        }

        private void Historique_Load(object sender, EventArgs e)
        {
            //Non exploité
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");

            conn.Open();

            if (comboBox_meteo.Text == "Centrale 1")
            {
                // Requête SQL pour récupérer les données de la table "info_meteo"
                string sql = "SELECT DateHeure, Temperature, Humidite, CO2 FROM info_meteo";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "info_meteo");

                // Affichage des données dans un DataGridView
                dataGrid_meteo.DataSource = dataset.Tables["info_meteo"];

                // Fermeture de la connexion à la base de données
                conn.Close();
            }

            if (comboBox_meteo.Text == "Centrale 2")
            {
                // Requête SQL pour récupérer les données de la table "info_meteo1"
                string sql = "SELECT DateHeure, Temperature, Humidite, CO2 FROM info_meteo1";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "info_meteo1");

                // Affichage des données dans un DataGridView
                dataGrid_meteo.DataSource = dataset.Tables["info_meteo1"];

                // Fermeture de la connexion à la base de données
                conn.Close();
            }

            if (comboBox_meteo.Text == "Centrale 3")
            {
                // Requête SQL pour récupérer les données de la table "info_meteo2"
                string sql = "SELECT DateHeure, Temperature, Humidite, CO2 FROM info_meteo2";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "info_meteo2");

                // Affichage des données dans un DataGridView
                dataGrid_meteo.DataSource = dataset.Tables["info_meteo2"];

                // Fermeture de la connexion à la base de données
                conn.Close();
            }
            else
            {
                return;
            }
        }

        private void comboBox_meteo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Non exploité
        }

        private void timer_histor_Tick(object sender, EventArgs e)
        {
            Histor1();     
        }

        private void timer_hisotr2_Tick(object sender, EventArgs e)
        {
            Histor2();
        }

        private void timer_histor3_Tick(object sender, EventArgs e)
        {
            Histor3();
        }

        private void timer_historAlerte_Tick(object sender, EventArgs e)
        {
            HistorAlerte();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");

            conn.Open();

            if (comboBox_meteo.Text == "Centrale 3")
            {
                // Requête SQL pour récupérer les données de la table "info_meteo2"
                string sql = "SELECT DateHeure, Temperature, Humidite, CO2 FROM info_meteo2";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "info_meteo2");

                // Affichage des données dans un DataGridView
                dataGrid_meteo.DataSource = dataset.Tables["info_meteo2"];

                // Fermeture de la connexion à la base de données
                conn.Close();
            }
            else
            {
                return;
            }
        }
    }
}
