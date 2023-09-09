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
    public partial class FormCreazioneAllenamento : Form
    {
        public FormCreazioneAllenamento()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string titolo = textBox1.Text;
            string durata = textBox2.Text;
            string intensità = textBox3.Text;
            string id = textBox4.Text;
            var data = monthCalendar1.SelectionStart;

            if (string.IsNullOrWhiteSpace(titolo)
                || string.IsNullOrWhiteSpace(durata)
                || string.IsNullOrWhiteSpace(intensità)
                || string.IsNullOrWhiteSpace(id))
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if (int.TryParse(id, out int id_n)
                && int.TryParse(durata, out int durata_n))
            {
                try
                {
                    ALLENAMENTO a = new ALLENAMENTO
                    {
                        Titolo = titolo,
                        DataAllenamento = data,
                        DurataMinuti = durata_n,
                        LivelloIntensità = intensità,
                        Utente = id_n,
                    };

                    Form1.db.ALLENAMENTO.InsertOnSubmit(a);
                    Form1.db.SubmitChanges();
                    MessageBox.Show("Allenamento creato con successo!");

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
