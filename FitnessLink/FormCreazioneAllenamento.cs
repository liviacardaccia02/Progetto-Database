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
    public partial class FormCreazioneAllenamento : Form
    {
        public FormCreazioneAllenamento()
        {
            InitializeComponent();
            this.Text = "FitnessLink - Creazione allenamento";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string titolo = textBox1.Text;
            string durata = textBox2.Text;
            string intensità = comboBox1.Text;
            string username = textBox4.Text;

            if (string.IsNullOrWhiteSpace(titolo)
                || string.IsNullOrWhiteSpace(durata)
                || string.IsNullOrWhiteSpace(username))
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if (int.TryParse(durata, out int durata_n))
            {
                try
                {
                    DateTime today = DateTime.Now;

                    IQueryable<int> query = from U in Form1.db.UTENTE
                                            where U.Username == username
                                            select U.IDutente;

                    ALLENAMENTO a = new ALLENAMENTO
                    {
                        Titolo = titolo,
                        Durata = durata_n,
                        DataAllenamento = today,
                        LivelloIntensità = intensità,
                        Utente = query.FirstOrDefault(),
                    };

                    if (string.IsNullOrWhiteSpace(intensità)) 
                    {
                        comboBox1.SelectedIndex = 2;
                        a.LivelloIntensità = comboBox1.SelectedItem.ToString();
                    }

                    Form1.db.ALLENAMENTO.InsertOnSubmit(a);
                    Form1.db.SubmitChanges();
                    MessageBox.Show("Allenamento creato con successo!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.SelectedItem = "Facile";
                    textBox4.Text = "";
                }
                catch (Exception ex)
                {
                    Form1.ErrorMessage(ex.Message);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.SelectedIndex = 0;
                    textBox4.Text = "";
                }
            }
            else
            {
                Form1.ErrorMessage("Inserisci un numero valido");
                textBox2.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
