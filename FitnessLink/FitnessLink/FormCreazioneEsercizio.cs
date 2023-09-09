using System;
using System.Windows.Forms;

namespace FitnessLink
{
    public partial class FormCreazioneEsercizio : Form
    {
        public FormCreazioneEsercizio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string muscolo = textBox2.Text;
            string descrizione = textBox3.Text;
            string id = textBox4.Text;

            if (string.IsNullOrWhiteSpace(nome)
                || string.IsNullOrWhiteSpace(muscolo)
                || string.IsNullOrWhiteSpace(descrizione)
                || string.IsNullOrWhiteSpace(id))
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if (int.TryParse(id, out int id_n)) 
            {
                try
                {
                    ESERCIZIO es = new ESERCIZIO
                    {
                        Nome = nome,
                        GruppoMuscolare = muscolo,
                        Descrizione = descrizione,
                        Creatore = id_n,
                    };
                    Form1.db.ESERCIZIO.InsertOnSubmit(es);
                    Form1.db.SubmitChanges();
                    MessageBox.Show("Esercizio creato con successo!");
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
