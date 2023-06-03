using System;
using System.Windows.Forms;


namespace SecurityControl
{
    // La classe SecurityControl étend la classe Form pour créer une interface graphique utilisateur.
    public partial class SecurityControl : Form
    {
        // Constructeur par défaut qui initialise les composants de l'interface graphique.
        public SecurityControl()
        {
            InitializeComponent();
        }

        // Création d'une instance de la classe MySQLConnector.
        MySQLConnector mySQLConnect = new MySQLConnector();

        // Méthode appelée lorsque la fenêtre est chargée pour la première fois.
        private void SecurityControl_Load(object sender, EventArgs e)
        {
            // Initialise et crée la base de données lors du lancement du logiciel.
            mySQLConnect.Initialize();
            mySQLConnect.CreationBDD();
        }

   
        // Méthode appelée lorsqu'on clique sur le bouton "Technicien".
        private void button_tech_Click(object sender, EventArgs e)
        {
            // Cache la fenêtre courante et affiche la fenêtre "Tech_login".
            this.Hide();
            Tech_login Tech = new Tech_login();
            Tech.Show();
            Tech.Closed += (s, args) => this.Close();
            Tech.Show();
        }

        // Méthode appelée lorsqu'on clique sur le bouton "Chantier".
        private void button_chantier_Click(object sender, EventArgs e)
        {
            // Cache la fenêtre courante et affiche la fenêtre "Superviseur_login".
            this.Hide();
            Superviseur_login Superviseur = new Superviseur_login();
            Superviseur.Show();
            Superviseur.Closed += (s, args) => this.Close();
            Superviseur.Show();
        }

        // Méthode appelée lorsqu'on clique sur le bouton "Poste".
        private void button_poste_Click(object sender, EventArgs e)
        {
            // Cache la fenêtre courante et affiche la fenêtre "Poste_login".
            this.Hide();
            Poste_login Poste = new Poste_login();
            Poste.Show();
            Poste.Closed += (s, args) => this.Close();
            Poste.Show();
        }

        // Méthode appelée lorsqu'on clique sur le lien "Nouveau".
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Cache la fenêtre courante et affiche la fenêtre "Superviseur_login".
            this.Hide();
            Superviseur_login_new Superviseur = new Superviseur_login_new();
            Superviseur.Show();
            Superviseur.Closed += (s, args) => this.Close();
            Superviseur.Show();
        }

        // Méthode appelée lorsqu'on clique sur le bouton "Quitter".
        private void button1_Click(object sender, EventArgs e)
        {
            // Ferme l'application.
            Application.Exit();
        }
    }
}
