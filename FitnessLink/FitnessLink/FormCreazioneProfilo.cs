using System;
using System.Windows.Forms;

namespace FitnessLink
{
    public partial class FormCreazioneProfilo : Form
    {
        public FormCreazioneProfilo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string cognome = textBox2.Text;
            string email = textBox3.Text;
            string username = textBox4.Text;
            string numero = textBox5.Text;
            var dataRegistrazione = dateTimePicker1.Value;

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
                    DataRegistrazione = dataRegistrazione,
                    NumeroTelefono = numero,
                };

                Form1.db.UTENTE.InsertOnSubmit(u);
                Form1.db.SubmitChanges();
                MessageBox.Show("Iscrizione avvenuta con successo," +
                " benvenut* su FitnessLink!");

            } 
            catch (Exception ex) 
            {
                Form1.ErrorMessage(ex.Message);
            }

        }
    }
}
