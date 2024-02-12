using PROVA;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string username = textBox4.Text;

            if (string.IsNullOrWhiteSpace(titolo)
                || string.IsNullOrWhiteSpace(didascalia)
                || string.IsNullOrWhiteSpace(allenamento)
                || string.IsNullOrWhiteSpace(username)
                )
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if (int.TryParse(allenamento, out int allenamento_n))
            {
                try
                {
                    DateTime today = DateTime.Now;

                    IQueryable<int> query = from U in Form1.db.UTENTE
                                            where U.Username == username
                                            select U.IDutente;

                    POST p = new POST
                    {
                        Titolo = titolo,
                        Didascalia = didascalia,
                        Autore = query.FirstOrDefault(),
                        DataPubblicazione = today,
                        AllenamentoCollegato = allenamento_n,
                    };

                    Form1.db.POST.InsertOnSubmit(p);
                    Form1.db.SubmitChanges();

                    MessageBox.Show("Post pubblicato con successo!");
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
            else
            {
                Form1.ErrorMessage("Inserisci un numero valido");
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
