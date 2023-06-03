namespace SecurityControl
{
    partial class Chef_Chantier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chef_Chantier));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_Affichage = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nv_Danger = new System.Windows.Forms.RadioButton();
            this.nv_Vigilance = new System.Windows.Forms.RadioButton();
            this.nv_OK = new System.Windows.Forms.RadioButton();
            this.b_alertes = new System.Windows.Forms.Button();
            this.comboBox_texte = new System.Windows.Forms.ComboBox();
            this.groupbox5 = new System.Windows.Forms.GroupBox();
            this.label_centrale = new System.Windows.Forms.Label();
            this.label_co2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_vent = new System.Windows.Forms.Label();
            this.label_hum = new System.Windows.Forms.Label();
            this.label_temp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Graphique = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_c3 = new System.Windows.Forms.Button();
            this.button_c2 = new System.Windows.Forms.Button();
            this.button_c1 = new System.Windows.Forms.Button();
            this.chart_co2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_vitesse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_hum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_temp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox_alerte = new System.Windows.Forms.RichTextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.timer_bdd = new System.Windows.Forms.Timer(this.components);
            this.timer_c1 = new System.Windows.Forms.Timer(this.components);
            this.timer_graph = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupbox5.SuspendLayout();
            this.Graphique.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_co2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_vitesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_hum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.historiqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1698, 28);
            this.menuStrip1.TabIndex = 103;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.historiqueToolStripMenuItem.Text = "Historique";
            this.historiqueToolStripMenuItem.Click += new System.EventHandler(this.historiqueToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(837, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Texte à afficher";
            // 
            // richTextBox_Affichage
            // 
            this.richTextBox_Affichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Affichage.Location = new System.Drawing.Point(841, 345);
            this.richTextBox_Affichage.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_Affichage.Name = "richTextBox_Affichage";
            this.richTextBox_Affichage.ReadOnly = true;
            this.richTextBox_Affichage.Size = new System.Drawing.Size(428, 155);
            this.richTextBox_Affichage.TabIndex = 72;
            this.richTextBox_Affichage.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.nv_Danger);
            this.groupBox6.Controls.Add(this.nv_Vigilance);
            this.groupBox6.Controls.Add(this.nv_OK);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(1279, 297);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(197, 204);
            this.groupBox6.TabIndex = 100;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Choix des alertes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Niveau";
            // 
            // nv_Danger
            // 
            this.nv_Danger.AutoSize = true;
            this.nv_Danger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nv_Danger.ForeColor = System.Drawing.Color.Red;
            this.nv_Danger.Location = new System.Drawing.Point(20, 139);
            this.nv_Danger.Margin = new System.Windows.Forms.Padding(4);
            this.nv_Danger.Name = "nv_Danger";
            this.nv_Danger.Size = new System.Drawing.Size(122, 29);
            this.nv_Danger.TabIndex = 2;
            this.nv_Danger.Text = "DANGER";
            this.nv_Danger.UseVisualStyleBackColor = true;
            // 
            // nv_Vigilance
            // 
            this.nv_Vigilance.AutoSize = true;
            this.nv_Vigilance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nv_Vigilance.ForeColor = System.Drawing.Color.DarkOrange;
            this.nv_Vigilance.Location = new System.Drawing.Point(20, 111);
            this.nv_Vigilance.Margin = new System.Windows.Forms.Padding(4);
            this.nv_Vigilance.Name = "nv_Vigilance";
            this.nv_Vigilance.Size = new System.Drawing.Size(148, 29);
            this.nv_Vigilance.TabIndex = 1;
            this.nv_Vigilance.Text = "VIGILANCE";
            this.nv_Vigilance.UseVisualStyleBackColor = true;
            // 
            // nv_OK
            // 
            this.nv_OK.AutoSize = true;
            this.nv_OK.Checked = true;
            this.nv_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nv_OK.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nv_OK.Location = new System.Drawing.Point(20, 85);
            this.nv_OK.Margin = new System.Windows.Forms.Padding(4);
            this.nv_OK.Name = "nv_OK";
            this.nv_OK.Size = new System.Drawing.Size(65, 29);
            this.nv_OK.TabIndex = 0;
            this.nv_OK.TabStop = true;
            this.nv_OK.Text = "OK";
            this.nv_OK.UseVisualStyleBackColor = true;
            // 
            // b_alertes
            // 
            this.b_alertes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.b_alertes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_alertes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_alertes.ForeColor = System.Drawing.Color.White;
            this.b_alertes.Location = new System.Drawing.Point(1279, 508);
            this.b_alertes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_alertes.Name = "b_alertes";
            this.b_alertes.Size = new System.Drawing.Size(197, 57);
            this.b_alertes.TabIndex = 12;
            this.b_alertes.Text = "FIXER";
            this.b_alertes.UseVisualStyleBackColor = true;
            this.b_alertes.Click += new System.EventHandler(this.b_alertes_Click);
            // 
            // comboBox_texte
            // 
            this.comboBox_texte.FormattingEnabled = true;
            this.comboBox_texte.Items.AddRange(new object[] {
            "VENT VIOLENT",
            "A L\'ABRI"});
            this.comboBox_texte.Location = new System.Drawing.Point(841, 308);
            this.comboBox_texte.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_texte.Name = "comboBox_texte";
            this.comboBox_texte.Size = new System.Drawing.Size(428, 28);
            this.comboBox_texte.TabIndex = 105;
            // 
            // groupbox5
            // 
            this.groupbox5.BackColor = System.Drawing.Color.Transparent;
            this.groupbox5.Controls.Add(this.label_centrale);
            this.groupbox5.Controls.Add(this.label_co2);
            this.groupbox5.Controls.Add(this.label8);
            this.groupbox5.Controls.Add(this.label_vent);
            this.groupbox5.Controls.Add(this.label_hum);
            this.groupbox5.Controls.Add(this.label_temp);
            this.groupbox5.Controls.Add(this.label4);
            this.groupbox5.Controls.Add(this.label3);
            this.groupbox5.Controls.Add(this.label2);
            this.groupbox5.ForeColor = System.Drawing.Color.White;
            this.groupbox5.Location = new System.Drawing.Point(841, 578);
            this.groupbox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox5.Name = "groupbox5";
            this.groupbox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox5.Size = new System.Drawing.Size(827, 262);
            this.groupbox5.TabIndex = 99;
            this.groupbox5.TabStop = false;
            this.groupbox5.Text = "Information météo";
            this.groupbox5.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_centrale
            // 
            this.label_centrale.AutoSize = true;
            this.label_centrale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_centrale.ForeColor = System.Drawing.Color.Red;
            this.label_centrale.Location = new System.Drawing.Point(337, 21);
            this.label_centrale.Name = "label_centrale";
            this.label_centrale.Size = new System.Drawing.Size(180, 36);
            this.label_centrale.TabIndex = 78;
            this.label_centrale.Text = "Centrale n°1";
            this.label_centrale.Visible = false;
            // 
            // label_co2
            // 
            this.label_co2.AutoSize = true;
            this.label_co2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_co2.Location = new System.Drawing.Point(699, 69);
            this.label_co2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_co2.Name = "label_co2";
            this.label_co2.Size = new System.Drawing.Size(31, 29);
            this.label_co2.TabIndex = 77;
            this.label_co2.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(554, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 29);
            this.label8.TabIndex = 76;
            this.label8.Text = "Co2 (ppm) :";
            // 
            // label_vent
            // 
            this.label_vent.AutoSize = true;
            this.label_vent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vent.Location = new System.Drawing.Point(292, 218);
            this.label_vent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_vent.Name = "label_vent";
            this.label_vent.Size = new System.Drawing.Size(31, 29);
            this.label_vent.TabIndex = 74;
            this.label_vent.Text = "...";
            // 
            // label_hum
            // 
            this.label_hum.AutoSize = true;
            this.label_hum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hum.Location = new System.Drawing.Point(198, 145);
            this.label_hum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hum.Name = "label_hum";
            this.label_hum.Size = new System.Drawing.Size(31, 29);
            this.label_hum.TabIndex = 73;
            this.label_hum.Text = "...";
            this.label_hum.Click += new System.EventHandler(this.label_hum_Click);
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temp.Location = new System.Drawing.Point(248, 70);
            this.label_temp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(31, 29);
            this.label_temp.TabIndex = 72;
            this.label_temp.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 29);
            this.label4.TabIndex = 69;
            this.label4.Text = "Vitesse du vent (Km/h) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 69;
            this.label3.Text = "Humidité (%) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 29);
            this.label2.TabIndex = 69;
            this.label2.Text = "Température (°C) :";
            // 
            // Graphique
            // 
            this.Graphique.Controls.Add(this.button1);
            this.Graphique.Controls.Add(this.groupBox2);
            this.Graphique.Controls.Add(this.chart_co2);
            this.Graphique.Controls.Add(this.chart_vitesse);
            this.Graphique.Controls.Add(this.chart_hum);
            this.Graphique.Controls.Add(this.chart_temp);
            this.Graphique.Controls.Add(this.richTextBox_alerte);
            this.Graphique.Controls.Add(this.b_alertes);
            this.Graphique.Controls.Add(this.button_delete);
            this.Graphique.Controls.Add(this.groupbox5);
            this.Graphique.Controls.Add(this.comboBox_texte);
            this.Graphique.Controls.Add(this.groupBox6);
            this.Graphique.Controls.Add(this.richTextBox_Affichage);
            this.Graphique.Controls.Add(this.label6);
            this.Graphique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graphique.ForeColor = System.Drawing.Color.White;
            this.Graphique.Location = new System.Drawing.Point(16, 33);
            this.Graphique.Margin = new System.Windows.Forms.Padding(4);
            this.Graphique.Name = "Graphique";
            this.Graphique.Padding = new System.Windows.Forms.Padding(4);
            this.Graphique.Size = new System.Drawing.Size(1678, 846);
            this.Graphique.TabIndex = 104;
            this.Graphique.TabStop = false;
            this.Graphique.Text = "Graphique";
            this.Graphique.Enter += new System.EventHandler(this.Graphique_Enter);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(989, 508);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 57);
            this.button1.TabIndex = 141;
            this.button1.Text = "AFFICHER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button_c3);
            this.groupBox2.Controls.Add(this.button_c2);
            this.groupBox2.Controls.Add(this.button_c1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1483, 297);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(185, 268);
            this.groupBox2.TabIndex = 119;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choix centrale";
            // 
            // button_c3
            // 
            this.button_c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_c3.ForeColor = System.Drawing.Color.Black;
            this.button_c3.Location = new System.Drawing.Point(6, 188);
            this.button_c3.Name = "button_c3";
            this.button_c3.Size = new System.Drawing.Size(173, 72);
            this.button_c3.TabIndex = 114;
            this.button_c3.Text = "Centrale 3";
            this.button_c3.UseVisualStyleBackColor = true;
            this.button_c3.Click += new System.EventHandler(this.button_c3_Click);
            // 
            // button_c2
            // 
            this.button_c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_c2.ForeColor = System.Drawing.Color.Black;
            this.button_c2.Location = new System.Drawing.Point(6, 110);
            this.button_c2.Name = "button_c2";
            this.button_c2.Size = new System.Drawing.Size(173, 72);
            this.button_c2.TabIndex = 113;
            this.button_c2.Text = "Centrale 2";
            this.button_c2.UseVisualStyleBackColor = true;
            this.button_c2.Click += new System.EventHandler(this.button_c2_Click);
            // 
            // button_c1
            // 
            this.button_c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_c1.ForeColor = System.Drawing.Color.Black;
            this.button_c1.Location = new System.Drawing.Point(6, 32);
            this.button_c1.Name = "button_c1";
            this.button_c1.Size = new System.Drawing.Size(173, 72);
            this.button_c1.TabIndex = 112;
            this.button_c1.Text = "Centrale 1";
            this.button_c1.UseVisualStyleBackColor = true;
            this.button_c1.Click += new System.EventHandler(this.button_c1_Click);
            // 
            // chart_co2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_co2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_co2.Legends.Add(legend1);
            this.chart_co2.Location = new System.Drawing.Point(841, 27);
            this.chart_co2.Margin = new System.Windows.Forms.Padding(4);
            this.chart_co2.Name = "chart_co2";
            this.chart_co2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Co2(ppm)";
            this.chart_co2.Series.Add(series1);
            this.chart_co2.Size = new System.Drawing.Size(822, 251);
            this.chart_co2.TabIndex = 140;
            this.chart_co2.Text = "chart4";
            // 
            // chart_vitesse
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_vitesse.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_vitesse.Legends.Add(legend2);
            this.chart_vitesse.Location = new System.Drawing.Point(10, 545);
            this.chart_vitesse.Margin = new System.Windows.Forms.Padding(4);
            this.chart_vitesse.Name = "chart_vitesse";
            this.chart_vitesse.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Vitesse (km/h)";
            this.chart_vitesse.Series.Add(series2);
            this.chart_vitesse.Size = new System.Drawing.Size(822, 295);
            this.chart_vitesse.TabIndex = 139;
            this.chart_vitesse.Text = "chart3";
            // 
            // chart_hum
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_hum.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_hum.Legends.Add(legend3);
            this.chart_hum.Location = new System.Drawing.Point(8, 286);
            this.chart_hum.Margin = new System.Windows.Forms.Padding(4);
            this.chart_hum.Name = "chart_hum";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Humidité (%)";
            this.chart_hum.Series.Add(series3);
            this.chart_hum.Size = new System.Drawing.Size(822, 251);
            this.chart_hum.TabIndex = 138;
            this.chart_hum.Text = "chart2";
            // 
            // chart_temp
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_temp.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_temp.Legends.Add(legend4);
            this.chart_temp.Location = new System.Drawing.Point(8, 27);
            this.chart_temp.Margin = new System.Windows.Forms.Padding(4);
            this.chart_temp.Name = "chart_temp";
            this.chart_temp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Température (°)";
            series4.YValuesPerPoint = 2;
            this.chart_temp.Series.Add(series4);
            this.chart_temp.Size = new System.Drawing.Size(822, 251);
            this.chart_temp.TabIndex = 137;
            this.chart_temp.Text = "chart1";
            // 
            // richTextBox_alerte
            // 
            this.richTextBox_alerte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_alerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_alerte.Location = new System.Drawing.Point(1064, 447);
            this.richTextBox_alerte.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_alerte.Name = "richTextBox_alerte";
            this.richTextBox_alerte.ReadOnly = true;
            this.richTextBox_alerte.Size = new System.Drawing.Size(205, 53);
            this.richTextBox_alerte.TabIndex = 136;
            this.richTextBox_alerte.Text = "";
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(841, 508);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(141, 57);
            this.button_delete.TabIndex = 135;
            this.button_delete.Text = "RAZ";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // timer_bdd
            // 
            this.timer_bdd.Enabled = true;
            this.timer_bdd.Interval = 2000;
            this.timer_bdd.Tick += new System.EventHandler(this.timer_bdd_Tick);
            // 
            // timer_c1
            // 
            this.timer_c1.Enabled = true;
            // 
            // timer_graph
            // 
            this.timer_graph.Enabled = true;
            this.timer_graph.Interval = 1000;
            this.timer_graph.Tick += new System.EventHandler(this.timer_graph_Tick);
            // 
            // Chef_Chantier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1698, 880);
            this.Controls.Add(this.Graphique);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chef_Chantier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurityControl - Chef de chantier";
            this.Load += new System.EventHandler(this.Chef_Chantier_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupbox5.ResumeLayout(false);
            this.groupbox5.PerformLayout();
            this.Graphique.ResumeLayout(false);
            this.Graphique.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_co2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_vitesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_hum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox_Affichage;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button b_alertes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton nv_Danger;
        private System.Windows.Forms.RadioButton nv_Vigilance;
        private System.Windows.Forms.RadioButton nv_OK;
        private System.Windows.Forms.ComboBox comboBox_texte;
        private System.Windows.Forms.GroupBox groupbox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Graphique;
        private System.Windows.Forms.Label label_vent;
        private System.Windows.Forms.Label label_hum;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Timer timer_bdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label co2;
        private System.Windows.Forms.Label label_co2;
        private System.Windows.Forms.Timer timer_c1;
        private System.Windows.Forms.RichTextBox richTextBox_alerte;
        private System.Windows.Forms.Timer timer_graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_co2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_vitesse;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_hum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_temp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_c3;
        private System.Windows.Forms.Button button_c2;
        private System.Windows.Forms.Button button_c1;
        private System.Windows.Forms.Label label_centrale;
        private System.Windows.Forms.Button button1;
    }
}