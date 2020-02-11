namespace Progetto
{
    partial class Form2
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
            this.DataGridViewPrincipale = new System.Windows.Forms.DataGridView();
            this.VISUALIZZA = new System.Windows.Forms.Button();
            this.INSERISCI = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CERCA = new System.Windows.Forms.Button();
            this.Ricerca = new System.Windows.Forms.Label();
            this.ComboBoxEntità = new System.Windows.Forms.ComboBox();
            this.altro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPrincipale)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewPrincipale
            // 
            this.DataGridViewPrincipale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPrincipale.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGridViewPrincipale.Location = new System.Drawing.Point(25, 87);
            this.DataGridViewPrincipale.Name = "DataGridViewPrincipale";
            this.DataGridViewPrincipale.Size = new System.Drawing.Size(688, 249);
            this.DataGridViewPrincipale.TabIndex = 0;
            this.DataGridViewPrincipale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPrincipale_CellContentClick);
            // 
            // VISUALIZZA
            // 
            this.VISUALIZZA.Location = new System.Drawing.Point(187, 23);
            this.VISUALIZZA.Name = "VISUALIZZA";
            this.VISUALIZZA.Size = new System.Drawing.Size(81, 26);
            this.VISUALIZZA.TabIndex = 1;
            this.VISUALIZZA.Text = "VISUALIZZA";
            this.VISUALIZZA.UseVisualStyleBackColor = false;
            this.VISUALIZZA.Click += new System.EventHandler(this.button1_Click);
            // 
            // INSERISCI
            // 
            this.INSERISCI.Location = new System.Drawing.Point(274, 23);
            this.INSERISCI.Name = "INSERISCI";
            this.INSERISCI.Size = new System.Drawing.Size(75, 23);
            this.INSERISCI.TabIndex = 2;
            this.INSERISCI.Text = "INSERISCI";
            this.INSERISCI.UseVisualStyleBackColor = true;
            this.INSERISCI.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CERCA
            // 
            this.CERCA.Location = new System.Drawing.Point(364, 22);
            this.CERCA.Name = "CERCA";
            this.CERCA.Size = new System.Drawing.Size(75, 23);
            this.CERCA.TabIndex = 4;
            this.CERCA.Text = "CERCA";
            this.CERCA.UseVisualStyleBackColor = true;
            this.CERCA.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Ricerca
            // 
            this.Ricerca.AutoSize = true;
            this.Ricerca.Location = new System.Drawing.Point(470, 9);
            this.Ricerca.Name = "Ricerca";
            this.Ricerca.Size = new System.Drawing.Size(233, 13);
            this.Ricerca.TabIndex = 5;
            this.Ricerca.Text = "Per la ricerca inserire qui sotto la chiave primaria";
            this.Ricerca.Click += new System.EventHandler(this.label1_Click);
            // 
            // ComboBoxEntità
            // 
            this.ComboBoxEntità.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ComboBoxEntità.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxEntità.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ComboBoxEntità.FormattingEnabled = true;
            this.ComboBoxEntità.Items.AddRange(new object[] {
            "ARTICOLI",
            "COMPONENTI",
            "CONTRATTI",
            "CONTRATTI_COLLABORAZIONI",
            "COSTRUTTORI",
            "DDT_CONSEGNE",
            "DDT_RIENTRI",
            "DIPENDENTI",
            "DISPONIBILITA",
            "FORNITORI",
            "GEOLOCALIZZAZIONI",
            "GUASTI",
            "MAGAZZINI",
            "MODELLI_ARTICOLI",
            "MODELLI_COMPONENTI",
            "PREVENTIVI",
            "RIPARATORI",
            "RIPARAZIONI_GARANZIA",
            "RIPARAZIONI_NON_GARANZIA",
            "SITI"});
            this.ComboBoxEntità.Location = new System.Drawing.Point(12, 23);
            this.ComboBoxEntità.Name = "ComboBoxEntità";
            this.ComboBoxEntità.Size = new System.Drawing.Size(151, 21);
            this.ComboBoxEntità.TabIndex = 6;
            this.ComboBoxEntità.Text = "SELEZIONA UN\'ENTITA\'";
            this.ComboBoxEntità.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // altro
            // 
            this.altro.Location = new System.Drawing.Point(319, 359);
            this.altro.Name = "altro";
            this.altro.Size = new System.Drawing.Size(75, 23);
            this.altro.TabIndex = 7;
            this.altro.Text = "ALTRO";
            this.altro.UseVisualStyleBackColor = true;
            this.altro.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 394);
            this.Controls.Add(this.altro);
            this.Controls.Add(this.ComboBoxEntità);
            this.Controls.Add(this.Ricerca);
            this.Controls.Add(this.CERCA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.INSERISCI);
            this.Controls.Add(this.VISUALIZZA);
            this.Controls.Add(this.DataGridViewPrincipale);
            this.Name = "Form2";
            this.Text = "PAGINA PRINCIPALE";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPrincipale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewPrincipale;
        private System.Windows.Forms.Button VISUALIZZA;
        private System.Windows.Forms.Button INSERISCI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CERCA;
        private System.Windows.Forms.Label Ricerca;
        private System.Windows.Forms.ComboBox ComboBoxEntità;
        private System.Windows.Forms.Button altro;
    }
}