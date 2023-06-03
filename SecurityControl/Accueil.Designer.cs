namespace SecurityControl
{
    partial class SecurityControl
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityControl));
            this.button_tech = new System.Windows.Forms.Button();
            this.button_chantier = new System.Windows.Forms.Button();
            this.button_poste = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_tech
            // 
            this.button_tech.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button_tech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tech.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tech.ForeColor = System.Drawing.Color.White;
            this.button_tech.Location = new System.Drawing.Point(528, 347);
            this.button_tech.Margin = new System.Windows.Forms.Padding(4);
            this.button_tech.Name = "button_tech";
            this.button_tech.Size = new System.Drawing.Size(248, 110);
            this.button_tech.TabIndex = 11;
            this.button_tech.Text = "Technicien";
            this.button_tech.UseVisualStyleBackColor = true;
            this.button_tech.Click += new System.EventHandler(this.button_tech_Click);
            // 
            // button_chantier
            // 
            this.button_chantier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button_chantier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chantier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chantier.ForeColor = System.Drawing.Color.White;
            this.button_chantier.Location = new System.Drawing.Point(272, 347);
            this.button_chantier.Margin = new System.Windows.Forms.Padding(4);
            this.button_chantier.Name = "button_chantier";
            this.button_chantier.Size = new System.Drawing.Size(248, 110);
            this.button_chantier.TabIndex = 12;
            this.button_chantier.Text = "Chef de chantier";
            this.button_chantier.UseVisualStyleBackColor = true;
            this.button_chantier.Click += new System.EventHandler(this.button_chantier_Click);
            // 
            // button_poste
            // 
            this.button_poste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button_poste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_poste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_poste.ForeColor = System.Drawing.Color.White;
            this.button_poste.Location = new System.Drawing.Point(16, 347);
            this.button_poste.Margin = new System.Windows.Forms.Padding(4);
            this.button_poste.Name = "button_poste";
            this.button_poste.Size = new System.Drawing.Size(248, 110);
            this.button_poste.TabIndex = 13;
            this.button_poste.Text = "Chef de poste";
            this.button_poste.UseVisualStyleBackColor = true;
            this.button_poste.Click += new System.EventHandler(this.button_poste_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(689, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 25);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nouveau ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "SecurityControl";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 44);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "SecurityControl";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(740, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 44);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecurityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_poste);
            this.Controls.Add(this.button_chantier);
            this.Controls.Add(this.button_tech);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SecurityControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurityControl";
            this.Load += new System.EventHandler(this.SecurityControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_tech;
        private System.Windows.Forms.Button button_chantier;
        private System.Windows.Forms.Button button_poste;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

