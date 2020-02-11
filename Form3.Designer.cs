namespace Progetto
{
    partial class Form3
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.FaseCollaudoUpdate = new System.Windows.Forms.Button();
            this.AggiornaData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxmMat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxColl = new System.Windows.Forms.TextBox();
            this.CodRiparazione = new System.Windows.Forms.Label();
            this.DataFine = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRiparazione = new System.Windows.Forms.ComboBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxCodiceRiparazione = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 154);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(632, 96);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FaseCollaudoUpdate
            // 
            this.FaseCollaudoUpdate.Location = new System.Drawing.Point(78, 87);
            this.FaseCollaudoUpdate.Name = "FaseCollaudoUpdate";
            this.FaseCollaudoUpdate.Size = new System.Drawing.Size(75, 23);
            this.FaseCollaudoUpdate.TabIndex = 1;
            this.FaseCollaudoUpdate.Text = "AGGIORNA";
            this.FaseCollaudoUpdate.UseVisualStyleBackColor = true;
            this.FaseCollaudoUpdate.Click += new System.EventHandler(this.FaseCollaudoUpdate_Click);
            // 
            // AggiornaData
            // 
            this.AggiornaData.Location = new System.Drawing.Point(354, 87);
            this.AggiornaData.Name = "AggiornaData";
            this.AggiornaData.Size = new System.Drawing.Size(75, 23);
            this.AggiornaData.TabIndex = 2;
            this.AggiornaData.Text = "AGGIORNA";
            this.AggiornaData.UseVisualStyleBackColor = true;
            this.AggiornaData.Click += new System.EventHandler(this.AggiornaData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aggiornamento di \"FaseCollaudo\" di Articolo";
            // 
            // textBoxmMat
            // 
            this.textBoxmMat.Location = new System.Drawing.Point(141, 32);
            this.textBoxmMat.Name = "textBoxmMat";
            this.textBoxmMat.Size = new System.Drawing.Size(100, 20);
            this.textBoxmMat.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MATRICOLA ARTICOLO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "FASE COLLAUDO";
            // 
            // textBoxColl
            // 
            this.textBoxColl.Location = new System.Drawing.Point(141, 61);
            this.textBoxColl.Name = "textBoxColl";
            this.textBoxColl.Size = new System.Drawing.Size(100, 20);
            this.textBoxColl.TabIndex = 9;
            // 
            // CodRiparazione
            // 
            this.CodRiparazione.AutoSize = true;
            this.CodRiparazione.Location = new System.Drawing.Point(283, 32);
            this.CodRiparazione.Name = "CodRiparazione";
            this.CodRiparazione.Size = new System.Drawing.Size(123, 13);
            this.CodRiparazione.TabIndex = 10;
            this.CodRiparazione.Text = "CODICE RIPARAZIONE";
            this.CodRiparazione.Click += new System.EventHandler(this.label4_Click);
            // 
            // DataFine
            // 
            this.DataFine.AutoSize = true;
            this.DataFine.Location = new System.Drawing.Point(283, 64);
            this.DataFine.Name = "DataFine";
            this.DataFine.Size = new System.Drawing.Size(63, 13);
            this.DataFine.TabIndex = 11;
            this.DataFine.Text = "DATA FINE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Aggiornamento di \"DataFine\" di ";
            // 
            // comboBoxRiparazione
            // 
            this.comboBoxRiparazione.FormattingEnabled = true;
            this.comboBoxRiparazione.Items.AddRange(new object[] {
            "RIPARAZIONE GARANZIA",
            "RIPARAZIONE NON GARANZIA"});
            this.comboBoxRiparazione.Location = new System.Drawing.Point(449, 9);
            this.comboBoxRiparazione.Name = "comboBoxRiparazione";
            this.comboBoxRiparazione.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRiparazione.TabIndex = 13;
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(412, 61);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(100, 20);
            this.textBoxData.TabIndex = 14;
            // 
            // textBoxCodiceRiparazione
            // 
            this.textBoxCodiceRiparazione.Location = new System.Drawing.Point(412, 32);
            this.textBoxCodiceRiparazione.Name = "textBoxCodiceRiparazione";
            this.textBoxCodiceRiparazione.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodiceRiparazione.TabIndex = 15;
            this.textBoxCodiceRiparazione.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 262);
            this.Controls.Add(this.textBoxCodiceRiparazione);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.comboBoxRiparazione);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataFine);
            this.Controls.Add(this.CodRiparazione);
            this.Controls.Add(this.textBoxColl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxmMat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AggiornaData);
            this.Controls.Add(this.FaseCollaudoUpdate);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Form3";
            this.Text = "ALTRE ISTRUZIONI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button FaseCollaudoUpdate;
        private System.Windows.Forms.Button AggiornaData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxmMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxColl;
        private System.Windows.Forms.Label CodRiparazione;
        private System.Windows.Forms.Label DataFine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRiparazione;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxCodiceRiparazione;
    }
}