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
    public partial class FormPubblicazionePost : Form
    {
        public FormPubblicazionePost()
        {
            InitializeComponent();
            this.Text = "FitnessLink - Pubblicazione post";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titolo = textBox1.Text;
            string didascalia = textBox2.Text;
            string allenamento = textBox3.Text;
            string id = textBox4.Text;
            var data = dateTimePicker1.Value;

            if (string.IsNullOrWhiteSpace(titolo)
                || string.IsNullOrWhiteSpace(didascalia)
                || string.IsNullOrWhiteSpace(allenamento)
                || string.IsNullOrWhiteSpace(id)
                )
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if (int.TryParse(id, out int id_n)
                && int.TryParse(allenamento, out int allenamento_n))
            {
                try
                {
                    INTERAZIONE i = new INTERAZIONE 
                    {
                        TipoInterazione = "Like",
                        Data = data,
                        Utente = id_n,
                    };

                    Form1.db.INTERAZIONE.InsertOnSubmit(i);
                    Form1.db.SubmitChanges();

                    POST p = new POST
                    {
                        Titolo = titolo,
                        Didascalia = didascalia,
                        AllenamentoCollegato = allenamento_n,
                        DataPubblicazione = data,
                        Autore = id_n,
                        Interazione = i.IDinterazione,
                    };

                    Form1.db.POST.InsertOnSubmit(p);
                    Form1.db.SubmitChanges();

                    MessageBox.Show("Post pubblicato con successo!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    Form1.ErrorMessage(ex.Message);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                }
            }
            else
            {
                Form1.ErrorMessage("Inserisci un numero valido");
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
