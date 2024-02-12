using PROVA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessLink
{
    public partial class FormVisualizzazioneProfilo : Form
    {
        public FormVisualizzazioneProfilo()
        {
            InitializeComponent();
            this.Text = "FitnessLink - Users";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                Form1.ErrorMessage("Inserire uno username corretto.");
                return;
            }
            else
            {
                try
                {
                    var query = from u in Form1.db.UTENTE
                                where u.Username == username
                                join p in Form1.db.POST
                                on u.IDutente equals p.Autore into postJoin
                                from post in postJoin.DefaultIfEmpty()
                                select new
                                {
                                    u.Nome,
                                    u.Cognome,
                                    u.Username,
                                    PostPubblicato = post != null ? post.Titolo : null,
                                    DataDiPubblicazione = post != null ?
                                    (DateTime?)post.DataPubblicazione : null,
                                };
                    dataGridView1.DataSource = query;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.textBox1.Text = "";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                Form1.ErrorMessage("Inserire uno username corretto.");
                return;
            }
            else
            {
                try
                {
                    var amiciQuery = from u1 in Form1.db.UTENTE
                                     join a in Form1.db.AMICIZIA on u1.IDutente equals a.Ricevente
                                     join u2 in Form1.db.UTENTE on a.Richiedente equals u2.IDutente
                                     where u1.Username == username && a.StatoAmicizia == "Accettata"
                                     select new
                                     {
                                         Amici = u2.Username
                                     };

                    dataGridView1.DataSource = amiciQuery.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.textBox1.Text = "";
                }
            }
        }
    }
}
