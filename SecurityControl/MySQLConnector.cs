using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace SecurityControl
{
    internal class MySQLConnector
    {
        private MySqlConnection connection;
      
        public MySQLConnector()
        {
            Initialize();
        }

        // Initialise la connexion à la base de données MySQL
        public void Initialize()
        {
            string connectionString = "server=192.168.20.20;uid=toto;password=pass";
            //string connectionString = "server=192.168.20.20;uid=toto;password=pass;database=worldco";
            connection = new MySqlConnection(connectionString);
        }

        //Ouverture de la connexion
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }          
        }

        //Créer la base de données si elle est inexistante
        public void CreationBDD()
        {         
            string CreateDB = "CREATE DATABASE IF NOT EXISTS worldco";
            NonQuery(CreateDB);
            string useDB = "USE worldco";
            NonQuery(useDB);
            string Log = "CREATE TABLE IF NOT EXISTS Log (ID INT AUTO_INCREMENT PRIMARY KEY, Description TEXT(100), Source TEXT(100), DateHeure DATETIME DEFAULT current_timestamp())";
            NonQuery(Log);
            string createTable_Auth = "CREATE TABLE IF NOT EXISTS authentification (ID INT AUTO_INCREMENT PRIMARY KEY, Nom VARCHAR(50), Prenom VARCHAR(50), Fonction VARCHAR(50), Identifiant VARCHAR(50), Mot_de_passe VARCHAR(50))";
            NonQuery(createTable_Auth);
            string createTable_InfoMeteo = "CREATE TABLE IF NOT EXISTS info_meteo (ID INT AUTO_INCREMENT PRIMARY KEY, DateHeure DATETIME DEFAULT current_timestamp(), Temperature INT(50), Humidite FLOAT(50), CO2 INT(50))";
            NonQuery(createTable_InfoMeteo);
            string createTable_InfoMeteo1 = "CREATE TABLE IF NOT EXISTS info_meteo1 (ID INT AUTO_INCREMENT PRIMARY KEY, DateHeure DATETIME DEFAULT current_timestamp(), Temperature INT(50), Humidite FLOAT(50), CO2 INT(50))";
            NonQuery(createTable_InfoMeteo1);
            string createTable_InfoMeteo2 = "CREATE TABLE IF NOT EXISTS info_meteo2 (ID INT AUTO_INCREMENT PRIMARY KEY, DateHeure DATETIME DEFAULT current_timestamp(), Temperature INT(50), Humidite FLOAT(50), CO2 INT(50))";
            NonQuery(createTable_InfoMeteo2);
            string createTable_Vent = "CREATE TABLE IF NOT EXISTS vent (ID INT AUTO_INCREMENT PRIMARY KEY, DateHeure DATETIME DEFAULT current_timestamp(), vent FLOAT)";
            NonQuery(createTable_Vent);
            string createTable3_AlerteMeteo = "CREATE TABLE IF NOT EXISTS alertes_meteo (ID INT AUTO_INCREMENT PRIMARY KEY, DateHeure DATETIME DEFAULT current_timestamp(),NiveauAlerte VARCHAR(50),MessageAlerte VARCHAR(50), Vent FLOAT(50), Temperature FLOAT(50), Humidite FLOAT(50), CO2 FLOAT(50))";
            NonQuery(createTable3_AlerteMeteo);
            //string createTable3_AlerteMeteo = "CREATE TABLE IF NOT EXISTS alertes_meteo (ID INT AUTO_INCREMENT PRIMARY KEY, DateHeure DATETIME DEFAULT current_timestamp(),NiveauAlerte VARCHAR(50),MessageAlerte VARCHAR(50), Vent VARCHAR(50), Temperature VARCHAR(50), Humidite VARCHAR(50), CO2 INT(50))";
            //NonQuery(createTable3_AlerteMeteo);
        }
  
        //Ferme la conexion
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Exécute une requête MySQL(INSERT, UPDATE, DELETE)
        public void NonQuery(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }              
            }
        }    
    }
}
