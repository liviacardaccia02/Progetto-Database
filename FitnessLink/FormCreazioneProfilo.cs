using PROVA;
using System;
using System.Windows.Forms;

namespace FitnessLink
{
    public partial class FormCreazioneProfilo : Form
    {
        public FormCreazioneProfilo()
        {
            InitializeComponent();
            this.Text = "FitnessLink - Creazione profilo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string cognome = textBox2.Text;
            string email = textBox3.Text;
            string username = textBox4.Text;
            string numero = textBox5.Text;

            if (string.IsNullOrWhiteSpace(nome) 
                || string.IsNullOrWhiteSpace(cognome)
                || string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(numero)
                )
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            try 
            {
                UTENTE u = new UTENTE 
                {
                    Nome = nome,
                    Cognome = cognome,
                    Email = email,  
                    Username = username,
                    NumeroTelefono = numero,
                };

                Form1.db.UTENTE.InsertOnSubmit(u);
                Form1.db.SubmitChanges();
                MessageBox.Show("Iscrizione avvenuta con successo," +
                " benvenut* su FitnessLink!");
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

        private void FormCreazioneProfilo_Load(object sender, EventArgs e)
        {

        }
    }
}
