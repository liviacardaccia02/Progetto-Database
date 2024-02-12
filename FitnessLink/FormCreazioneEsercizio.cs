using PROVA;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FitnessLink
{
    public partial class FormCreazioneEsercizio : Form
    {
        public FormCreazioneEsercizio()
        {
            InitializeComponent();
            this.Text = "FitnessLink - Creazione esercizio";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string muscolo = textBox2.Text;
            string descrizione = textBox3.Text;
            string username = textBox4.Text;

            if (string.IsNullOrWhiteSpace(nome)
                || string.IsNullOrWhiteSpace(muscolo)
                || string.IsNullOrWhiteSpace(descrizione)
                || string.IsNullOrWhiteSpace(username))
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }
            try
            {
                IQueryable<int> query = from U in Form1.db.UTENTE
                                        where U.Username == username
                                        select U.IDutente;

                ESERCIZIO es = new ESERCIZIO
                {
                    Nome = nome,
                    GruppoMuscolare = muscolo,
                    Descrizione = descrizione,
                    Creatore = query.FirstOrDefault(),
                };
                Form1.db.ESERCIZIO.InsertOnSubmit(es);
                Form1.db.SubmitChanges();
                MessageBox.Show("Esercizio creato con successo!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                Form1.ErrorMessage(ex.Message);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
