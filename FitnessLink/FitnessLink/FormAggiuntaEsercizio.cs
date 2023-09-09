using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessLink
{
    public partial class FormAggiuntaEsercizio : Form
    {
        public FormAggiuntaEsercizio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQueryable res = from E in Form1.db.ESERCIZIO
                             select E;
            dataGridView1.DataSource = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string muscolo = textBox2.Text;
            string allenamento = textBox3.Text;

            if (string.IsNullOrWhiteSpace(nome)
                || string.IsNullOrWhiteSpace(muscolo)
                || string.IsNullOrWhiteSpace(allenamento))
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if (int.TryParse(allenamento, out int codice_n))
            {
                try
                {
                    AGGIUNTA a = new AGGIUNTA
                    {
                        NomeEsercizio = nome,
                        GruppoMuscolareEsercizio = muscolo,
                        CodiceAllenamento = codice_n,
                    };

                    Form1.db.AGGIUNTA.InsertOnSubmit(a);
                    Form1.db.SubmitChanges();
                    MessageBox.Show("Esercizio aggiunto con successo!");

                }
                catch (Exception ex)
                {
                    Form1.ErrorMessage(ex.Message);
                }
            }
            else
            {
                Form1.ErrorMessage("Inserisci un numero valido");
            }
        }
    }
}
