using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace SecurityControl
{
    public partial class New : Form
    {
        public New()
        {
            InitializeComponent();
        }

        public void InsertData()
        {
            string Nom = textBox_Nom.Text;
            string Prénom = textBox_Prenom.Text;
            
            MySqlConnection connection = new MySqlConnection("server=192.168.20.20;uid=toto;password=pass;database=worldco");

            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string sql = "INSERT INTO authentification (Identifiant, Mot_de_passe, Nom, Prenom, Fonction) VALUES (@Identifiant, @Mot_de_passe, @Nom, @Prenom, @Fonction)";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Nom", Nom);
                cmd.Parameters.AddWithValue("@Prenom", Prénom);
                cmd.Parameters.AddWithValue("@Identifiant", label_id.Text);
                cmd.Parameters.AddWithValue("@Mot_de_passe", label_pass.Text);
                cmd.Parameters.AddWithValue("@Fonction", comboBox_foction.Text);

                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GeneratePassword()
        {
            // Liste de caractères utilisables pour le mot de passe
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Génération d'un mot de passe aléatoire
            Random random = new Random();
            char[] password = new char[8];
            for (int i = 0; i < 8; i++)
            {
                password[i] = allowedChars[random.Next(0, allowedChars.Length)];
            }

            return new string(password);
        }

        private string GenerateID()
        {
            const string allowedChars = "123456789";

            Random random = new Random();
            char[] id = new char[8];
            for (int i = 0; i < 2; i++)
            {
                id[i] = allowedChars[random.Next(0, allowedChars.Length)];
            }

            return new string(id);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string password = GeneratePassword();
            string id = GenerateID();

            label_pass.Text = password;
            label_pass.Visible = true;

            label_id.Text = textBox_Nom.Text + "_" + textBox_Prenom.Text + id;
            label_id.Visible = true;

            if (label_pass.Visible == true)
            {
                label_txt.Visible = true;
                id_l.Visible = true;
                id_p.Visible = true;
            }

            //Executé l'événement une seule fois
            button_connect.Click -= button1_Click;

            // Enregistrement dans la base de données 
            if (comboBox_foction.Text == "Chef de chantier")
            {
                InsertData();
                ConnectButtonChefChantier();
            }
            else if (comboBox_foction.Text == "Chef de poste")
            {
                InsertData();
                ConnectButtonChefPoste();
            }
            else if (comboBox_foction.Text == "Technicien")
            {
                InsertData();
                ConnectButtonTech();
            }            
        }

        public void ConnectButtonTech()
        {
            Button Connect = new Button()
            {
                Size = new Size(138, 48),
                Location = new Point(425, 210),
                TabIndex = 0,
                Text = "SE CONNECTER",
                Name = "button_connect",
                Font = new Font("Microsoft Sans Serif", 8),
                FlatStyle = FlatStyle.Flat,
            };

            Connect.Click += new EventHandler(button_connect_Tech_Click);

            this.Controls.Add(Connect);
        }

        private void button_connect_Tech_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tech_login Tech = new Tech_login();
            Tech.Show();
            Tech.Closed += (s, args) => this.Close();
            Tech.Show();
        }

        private void button_connect_Chef_Poste_Click(object sender, EventArgs e)
        {
            this.Hide();
            Poste_login Poste = new Poste_login();
            Poste.Show();
            Poste.Closed += (s, args) => this.Close();
            Poste.Show();
        }

        public void ConnectButtonChefPoste()
        {
            Button Connect = new Button()
            {
                Size = new Size(138, 48),
                Location = new Point(425, 210),
                TabIndex = 0,
                Text = "SE CONNECTER",
                Name = "button_connect",
                Font = new Font("Microsoft Sans Serif", 8),
                FlatStyle = FlatStyle.Flat,

            };

            Connect.Click += new EventHandler(button_connect_Chef_Poste_Click);

            this.Controls.Add(Connect);
        }

        public void ConnectButtonChefChantier()
        {
            Button Connect = new Button()
            {
                Size = new Size(138, 48),
                Location = new Point(425, 210),
                TabIndex = 0,
                Text = "SE CONNECTER",
                Name = "button_connect",
                Font = new Font("Microsoft Sans Serif", 8),
                FlatStyle= FlatStyle.Flat,               

            };

            Connect.Click += new EventHandler(button_connect_Chef_Chantier_Click);

            this.Controls.Add(Connect);
        }

        private void button_connect_Chef_Chantier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Superviseur_login Superviseur = new Superviseur_login();
            Superviseur.Show();
            Superviseur.Closed += (s, args) => this.Close();
            Superviseur.Show();
        }
    

        private void retourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecurityControl Retour = new SecurityControl();
            Retour.Show();
            Retour.Closed += (s, args) => this.Close();
            Retour.Show();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            New New = new New();
            New.Show();
            New.Closed += (s, args) => this.Close();
            New.Show();
        }

        private void button_connect_Click_1(object sender, EventArgs e)
        {
            string password = GeneratePassword();
            string id = GenerateID();

            if (textBox_Nom.Text == "" || textBox_Prenom.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            label_pass.Text = password;
            label_pass.Visible = true;

            label_id.Text = textBox_Nom.Text + "_" + textBox_Prenom.Text + id;
            label_id.Visible = true;

            if (label_pass.Visible == true)
            {
                label_txt.Visible = true;
                id_l.Visible = true;
                id_p.Visible = true;
            }


            //Executé l'événement une seule fois
            button_connect.Click -= button1_Click;

            // Enregistrement dans la base de données 
            if (comboBox_foction.Text == "Chef de chantier")
            {
                InsertData();
                ConnectButtonChefChantier();
            }
            else if (comboBox_foction.Text == "Chef de poste")
            {
                InsertData();
                ConnectButtonChefPoste();
            }
            else if (comboBox_foction.Text == "Technicien")
            {
                InsertData();
                ConnectButtonTech();
            }
        }

        private void New_Load(object sender, EventArgs e)
        {
            //Non exploité
        }

        private void button_connect_KeyDown(object sender, KeyEventArgs e)
        {
            //Non exploité
        }

        private void textBox_Prenom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string password = GeneratePassword();
                string id = GenerateID();

                if (textBox_Nom.Text == "" || textBox_Prenom.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                label_pass.Text = password;
                label_pass.Visible = true;

                label_id.Text = textBox_Nom.Text + "_" + textBox_Prenom.Text + id;
                label_id.Visible = true;

                if (label_pass.Visible == true)
                {
                    label_txt.Visible = true;
                    id_l.Visible = true;
                    id_p.Visible = true;
                }


                //Executé l'événement une seule fois
                button_connect.Click -= button1_Click;

                // Enregistrement dans la base de données 
                if (comboBox_foction.Text == "Chef de chantier")
                {
                    InsertData();
                    ConnectButtonChefChantier();
                }
                else if (comboBox_foction.Text == "Chef de poste")
                {
                    InsertData();
                    ConnectButtonChefPoste();
                }
                else if (comboBox_foction.Text == "Technicien")
                {
                    InsertData();
                    ConnectButtonTech();
                }
            }
        }

        private void comboBox_foction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string password = GeneratePassword();
                string id = GenerateID();

                if (textBox_Nom.Text == "" || textBox_Prenom.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                label_pass.Text = password;
                label_pass.Visible = true;

                label_id.Text = textBox_Nom.Text + "_" + textBox_Prenom.Text + id;
                label_id.Visible = true;

                if (label_pass.Visible == true)
                {
                    label_txt.Visible = true;
                    id_l.Visible = true;
                    id_p.Visible = true;
                }


                //Executé l'événement une seule fois
                button_connect.Click -= button1_Click;

                // Enregistrement dans la base de données 
                if (comboBox_foction.Text == "Chef de chantier")
                {
                    InsertData();
                    ConnectButtonChefChantier();
                }
                else if (comboBox_foction.Text == "Chef de poste")
                {
                    InsertData();
                    ConnectButtonChefPoste();
                }
                else if (comboBox_foction.Text == "Technicien")
                {
                    InsertData();
                    ConnectButtonTech();
                }
            }
        }
    }
}
