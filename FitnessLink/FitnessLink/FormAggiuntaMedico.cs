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
    public partial class FormAggiuntaMedico : Form
    {
        public FormAggiuntaMedico()
        {
            InitializeComponent();
            this.Text = "FitnessLink - Medici";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string cognome = textBox2.Text;
            string cf = textBox3.Text;
            string email = textBox4.Text;
            string numero = textBox5.Text;
            string specializzazione;

            if (string.IsNullOrWhiteSpace(nome)
                || string.IsNullOrWhiteSpace(cognome)
                || string.IsNullOrWhiteSpace(cf)
                || string.IsNullOrWhiteSpace(numero))
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if (radioButton1.Checked)
            {
                specializzazione = "Fisioterapista";

            }
            else if (radioButton2.Checked)
            {
                specializzazione = "Nutrizionista";
            }
            else if (radioButton3.Checked)
            {
                specializzazione = "Medico sportivo";
            }
            else
            {
                specializzazione = "Medico sportivo";
            }

            try 
            {
                MEDICO m = new MEDICO
                { 
                    CF = cf,
                    Nome = nome,
                    Cognome = cognome,  
                    NumeroTelefono = numero,
                    Email = email,
                    Specializzazione = specializzazione,
                };
                Form1.db.MEDICO.InsertOnSubmit(m);
                Form1.db.SubmitChanges();
                MessageBox.Show("Ti sei iscritto con successo, buon lavoro!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex) 
            {
                Form1.ErrorMessage(ex.Message);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }

        }
    }
}
