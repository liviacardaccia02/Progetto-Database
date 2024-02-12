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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PROVA
{
    public partial class FormInterazione : Form
    {
        public FormInterazione()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string post = this.textBox1.Text;
            string username = this.textBox2.Text;
            string tipoInterazione;
            string testo;

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(post))
            {
                MessageBox.Show("Inserire tutti i valori");
            }
            else
            {
                if (int.TryParse(post, out int post_n))
                {
                    try
                    {
                        if (radioButton1.Checked)
                        {
                            tipoInterazione = radioButton1.Text;
                            testo = "";

                        }
                        else if (radioButton2.Checked)
                        {
                            tipoInterazione = radioButton2.Text;
                            testo = this.textBox3.Text;
                        }
                        else
                        {
                            tipoInterazione = "Like";
                            testo = "";
                        }

                        IQueryable<int> query = from U in Form1.db.UTENTE
                                                where U.Username == username
                                                select U.IDutente; 

                        INTERAZIONE i = new INTERAZIONE
                        {
                            TipoInterazione = tipoInterazione,
                            Testo = testo,
                            Utente = query.FirstOrDefault(),
                            Post = post_n
                        };

                        Form1.db.INTERAZIONE.InsertOnSubmit(i);
                        Form1.db.SubmitChanges();
                        MessageBox.Show("Interazione condivisa con successo!");
                        this.textBox1.Text = string.Empty;
                        this.textBox2.Text = string.Empty;
                        this.textBox3.Text = string.Empty;
                        this.radioButton1.Checked = false; 
                        this.radioButton2.Checked = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.textBox1.Text = string.Empty;
                        this.textBox2.Text = string.Empty;
                        this.textBox3.Text = string.Empty;
                        this.radioButton1.Checked = false;
                        this.radioButton2.Checked = false;
                    }
                } 
                else
                {
                    MessageBox.Show("Inserisci un ID valido.");
                }
          
            }
        }
    }
}
