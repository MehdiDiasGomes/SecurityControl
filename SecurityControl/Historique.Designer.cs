namespace SecurityControl
{
    partial class Historique
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historique));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.comboBox_meteo = new System.Windows.Forms.ComboBox();
            this.dataGrid_meteo = new System.Windows.Forms.DataGridView();
            this.dataGridView_alerte = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_histor1 = new System.Windows.Forms.Timer(this.components);
            this.timer_hisotr2 = new System.Windows.Forms.Timer(this.components);
            this.timer_histor3 = new System.Windows.Forms.Timer(this.components);
            this.timer_historAlerte = new System.Windows.Forms.Timer(this.components);
            this.button_refresh = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_meteo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alerte)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button_refresh);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.dataGrid_meteo);
            this.groupBox3.Controls.Add(this.dataGridView_alerte);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(16, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1280, 754);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historique";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Controls.Add(this.comboBox_meteo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1036, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 155);
            this.groupBox1.TabIndex = 143;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix centrale";
            // 
            // button_connect
            // 
            this.button_connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connect.ForeColor = System.Drawing.Color.White;
            this.button_connect.Location = new System.Drawing.Point(21, 70);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(195, 62);
            this.button_connect.TabIndex = 142;
            this.button_connect.Text = "CONNECTER";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // comboBox_meteo
            // 
            this.comboBox_meteo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_meteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_meteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_meteo.ForeColor = System.Drawing.Color.White;
            this.comboBox_meteo.FormattingEnabled = true;
            this.comboBox_meteo.Items.AddRange(new object[] {
            "Centrale 1",
            "Centrale 2",
            "Centrale 3"});
            this.comboBox_meteo.Location = new System.Drawing.Point(21, 31);
            this.comboBox_meteo.Name = "comboBox_meteo";
            this.comboBox_meteo.Size = new System.Drawing.Size(195, 33);
            this.comboBox_meteo.TabIndex = 140;
            this.comboBox_meteo.Text = "Centrale 1";
            this.comboBox_meteo.SelectedIndexChanged += new System.EventHandler(this.comboBox_meteo_SelectedIndexChanged);
            // 
            // dataGrid_meteo
            // 
            this.dataGrid_meteo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_meteo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_meteo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_meteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_meteo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_meteo.Location = new System.Drawing.Point(12, 42);
            this.dataGrid_meteo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_meteo.Name = "dataGrid_meteo";
            this.dataGrid_meteo.RowHeadersWidth = 51;
            this.dataGrid_meteo.Size = new System.Drawing.Size(1015, 331);
            this.dataGrid_meteo.TabIndex = 141;
            // 
            // dataGridView_alerte
            // 
            this.dataGridView_alerte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_alerte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_alerte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_alerte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_alerte.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_alerte.Location = new System.Drawing.Point(12, 409);
            this.dataGridView_alerte.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_alerte.Name = "dataGridView_alerte";
            this.dataGridView_alerte.RowHeadersWidth = 51;
            this.dataGridView_alerte.Size = new System.Drawing.Size(1015, 331);
            this.dataGridView_alerte.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 106;
            this.label5.Text = "Historique météo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Historique des alertes";
            // 
            // timer_histor1
            // 
            this.timer_histor1.Interval = 5000;
            this.timer_histor1.Tick += new System.EventHandler(this.timer_histor_Tick);
            // 
            // timer_hisotr2
            // 
            this.timer_hisotr2.Interval = 5000;
            this.timer_hisotr2.Tick += new System.EventHandler(this.timer_hisotr2_Tick);
            // 
            // timer_histor3
            // 
            this.timer_histor3.Interval = 5000;
            this.timer_histor3.Tick += new System.EventHandler(this.timer_histor3_Tick);
            // 
            // timer_historAlerte
            // 
            this.timer_historAlerte.Interval = 5000;
            this.timer_historAlerte.Tick += new System.EventHandler(this.timer_historAlerte_Tick);
            // 
            // button_refresh
            // 
            this.button_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(1057, 246);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(195, 62);
            this.button_refresh.TabIndex = 143;
            this.button_refresh.Text = "ACTUALISER";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1312, 779);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Historique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique";
            this.Load += new System.EventHandler(this.Historique_Load);
            this.Shown += new System.EventHandler(this.Historique_Shown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_meteo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alerte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_histor1;
        private System.Windows.Forms.DataGridView dataGridView_alerte;
        private System.Windows.Forms.ComboBox comboBox_meteo;
        private System.Windows.Forms.DataGridView dataGrid_meteo;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer_hisotr2;
        private System.Windows.Forms.Timer timer_histor3;
        private System.Windows.Forms.Timer timer_historAlerte;
        private System.Windows.Forms.Button button_refresh;
    }
}