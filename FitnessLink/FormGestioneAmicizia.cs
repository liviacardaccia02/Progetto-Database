using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PROVA
{
    public partial class FormGestioneAmicizia : Form
    {
        public FormGestioneAmicizia()
        {
            InitializeComponent();
        }

        //visualizza richieste
        private void button1_Click(object sender, EventArgs e)
        {
            string usernameRicevente = textBox1.Text;

            if (string.IsNullOrWhiteSpace(usernameRicevente))
            {
                Form1.ErrorMessage("Inserire uno username corretto.");
                return;
            }

            try
            {
                var amiciQuery = from u1 in Form1.db.UTENTE
                                 join a in Form1.db.AMICIZIA on u1.IDutente equals a.Ricevente
                                 join u2 in Form1.db.UTENTE on a.Richiedente equals u2.IDutente
                                 where u1.Username == usernameRicevente && a.StatoAmicizia == "In attesa"
                                 select new
                                 {
                                     RichiesteAmicizia = u2.Username
                                 };

                dataGridView1.DataSource = amiciQuery.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = string.Empty;
            }
        }

        //accetta
        private void button2_Click(object sender, EventArgs e)
        {
            string usernameRicevente = textBox1.Text;
            string usernameRichiedente = textBox2.Text;

            if (string.IsNullOrWhiteSpace(usernameRichiedente)
                || string.IsNullOrWhiteSpace(usernameRicevente))
            {
                Form1.ErrorMessage("Inserire degli username corretti.");
                return;
            }

            IQueryable<int> query1 = from U in Form1.db.UTENTE
                                     where U.Username == usernameRicevente
                                     select U.IDutente;

            IQueryable<int> query2 = from U in Form1.db.UTENTE
                                     where U.Username == usernameRichiedente
                                     select U.IDutente;
            try
            {
                int riceventeId = query1.First();
                int richiedenteId = query2.First();

                var amiciziaDaAggiornare = from a in Form1.db.AMICIZIA
                                           where a.Richiedente == richiedenteId && a.Ricevente == riceventeId
                                           select a;

                if (amiciziaDaAggiornare != null)
                {
                    amiciziaDaAggiornare.First().StatoAmicizia = "Accettata";
                    Form1.db.SubmitChanges();
                    MessageBox.Show("Richiesta Accettata");
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Amicizia non trovata");
                    dataGridView1.ClearSelection();
                }

            }
            catch (Exception ex)
            {
                Form1.ErrorMessage(ex.Message);
            }
        }

        //rifiuta
        private void button3_Click(object sender, EventArgs e)
        {
            string usernameRicevente = textBox1.Text;
            string usernameRichiedente = textBox2.Text;

            if (string.IsNullOrWhiteSpace(usernameRichiedente)
                || string.IsNullOrWhiteSpace(usernameRicevente))
            {
                Form1.ErrorMessage("Inserire degli username corretti.");
                return;
            }

            IQueryable<int> query1 = from U in Form1.db.UTENTE
                                     where U.Username == usernameRicevente
                                     select U.IDutente;

            IQueryable<int> query2 = from U in Form1.db.UTENTE
                                     where U.Username == usernameRichiedente
                                     select U.IDutente;
            try
            {
                int riceventeId = query1.First();
                int richiedenteId = query2.First();

                var amiciziaDaAggiornare = from a in Form1.db.AMICIZIA
                                           where a.Richiedente == richiedenteId && a.Ricevente == riceventeId
                                           select a;

                if (amiciziaDaAggiornare != null)
                {
                    amiciziaDaAggiornare.First().StatoAmicizia = "Rifiutata";
                    Form1.db.SubmitChanges();
                    MessageBox.Show("Richiesta Rifiutata");
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Amicizia non trovata");
                    dataGridView1.ClearSelection();
                }

            }
            catch (Exception ex)
            {
                Form1.ErrorMessage(ex.Message);
            }
        }
    }
}
