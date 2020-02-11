using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto
{
    public partial class Form2 : Form
    {
        ClassiDataContext db = new ClassiDataContext();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ComboBoxEntità.SelectedIndex == 0)
            {
                var query = from p in db.ARTICOLI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 1)
            {
                var query = from p in db.COMPONENTI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 2)
            {
                var query = from p in db.CONTRATTI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 3)
            {
                var query = from p in db.CONTRATTI_COLLABORAZIONI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 4)
            {
                var query = from p in db.COSTRUTTORI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 5)
            {
                var query = from p in db.DDT_CONSEGNE
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 6)
            {
                var query = from p in db.DDT_RIENTRI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 7)
            {
                var query = from p in db.DIPENDENTI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 8)
            {
                var query = from p in db.DISPONIBILITA
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 9)
            {
                var query = from p in db.FORNITORI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 10)
            {
                var query = from p in db.GEOLOCALIZZAZIONI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 11)
            {
                var query = from p in db.GUASTI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 12)
            {
                var query = from p in db.MAGAZZINI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 13)
            {
                var query = from p in db.MODELLI_ARTICOLI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 14)
            {
                var query = from p in db.MODELLI_COMPONENTI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 15)
            {
                var query = from p in db.PREVENTIVI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 16)
            {
                var query = from p in db.RIPARATORI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 17)
            {
                var query = from p in db.RIPARAZIONI_GARANZIA
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 18)
            {
                var query = from p in db.RIPARAZIONI_NON_GARANZIA
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 19)
            {
                var query = from p in db.SITI
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormInserisci formInserisci = new FormInserisci();
            formInserisci.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (ComboBoxEntità.SelectedIndex == 0)
            {
                int matricola = int.Parse(textBox1.Text);
                var query = from p in db.ARTICOLI
                            where p.Matricola.Equals(matricola)
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 2)
            {
                int codContratto = int.Parse(textBox1.Text);
                var query = from p in db.CONTRATTI
                            where p.CodContratto.Equals(codContratto)
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 3)
            {
                int codCollaborazione = int.Parse(textBox1.Text);
                var query = from p in db.CONTRATTI_COLLABORAZIONI
                            where p.CodCollaborazione.Equals(codCollaborazione)
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 11)
            {
                int codGuasto = int.Parse(textBox1.Text);
                var query = from p in db.GUASTI
                            where p.CodGuasto.Equals(codGuasto)
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
            if (ComboBoxEntità.SelectedIndex == 19)
            {
                var sigla = textBox1.Text;
                var query = from p in db.SITI
                            where p.Sigla.Equals(sigla)
                            select p;
                DataGridViewPrincipale.DataSource = query;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DataGridViewPrincipale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewPrincipale.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
