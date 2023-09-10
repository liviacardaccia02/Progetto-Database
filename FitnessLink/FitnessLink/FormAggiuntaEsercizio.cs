using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitnessLink
{
    public partial class FormAggiuntaEsercizio : Form
    {
        public FormAggiuntaEsercizio()
        {
            InitializeComponent();
            this.Text = "FitnessLink - Aggiunta esercizio";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQueryable res = from E in Form1.db.ESERCIZIO
                             join U in Form1.db.UTENTE
                             on E.Creatore equals U.IDutente
                             select new
                             {
                                 E.Nome,
                                 E.GruppoMuscolare,
                                 E.Descrizione,
                                 Creatore = U.Username,
                             };
            dataGridView1.DataSource = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text;
            string muscolo = textBox3.Text;
            string allenamento = textBox1.Text;

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
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";

                }
                catch (Exception ex)
                {
                    Form1.ErrorMessage(ex.Message);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
            else
            {
                Form1.ErrorMessage("Inserisci un numero valido");
                textBox1.Text = "";
            }
        }
    }
}
