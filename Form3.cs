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
    public partial class Form3 : Form
    {
        ClassiDataContext db = new ClassiDataContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FaseCollaudoUpdate_Click(object sender, EventArgs e)
        {
            var matricola = textBoxmMat.Text;
            var collaudo = textBoxColl.Text;

            var result = (from a in db.ARTICOLI
                          where a.Matricola.Equals(matricola)
                          select a).Single();

            result.FaseCollaudo = collaudo;
            db.SubmitChanges();
            dataGridView3.DataSource = from A in db.ARTICOLI
                                       where A.Matricola.Equals(matricola)
                                       select A;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AggiornaData_Click(object sender, EventArgs e)
        {
            var codRiparazione = textBoxCodiceRiparazione.Text;
            var dataFine = textBoxData.Text;
            if (comboBoxRiparazione.SelectedIndex == 0)
            {
                var result = (from r in db.RIPARAZIONI_GARANZIA
                              where r.CodRiparazioneGaranzia.Equals(codRiparazione)
                              select r).Single();
                result.DataFine = DateTime.Parse(dataFine);
                db.SubmitChanges();
                dataGridView3.DataSource = from r in db.RIPARAZIONI_GARANZIA
                                           where r.CodRiparazioneGaranzia.Equals(codRiparazione)
                                           select r;
            }
            if (comboBoxRiparazione.SelectedIndex == 1)
            {
                var result = (from r in db.RIPARAZIONI_NON_GARANZIA
                              where r.CodRiparazioneNonGaranzia.Equals(codRiparazione)
                              select r).Single();
                result.DataFine = DateTime.Parse(dataFine);
                db.SubmitChanges();
                dataGridView3.DataSource = from r in db.RIPARAZIONI_NON_GARANZIA
                                           where r.CodRiparazioneNonGaranzia.Equals(codRiparazione)
                                           select r;
            }
        }
    }
}
