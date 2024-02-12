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

namespace PROVA
{
    public partial class FormRichiestaAmicizia : Form
    {
        public FormRichiestaAmicizia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var res = from U in Form1.db.UTENTE
                          select new
                          {
                              U.Username,
                              U.Nome,
                              U.Cognome
                          };
                dataGridView1.DataSource = res;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usernameRichiedente = textBox1.Text;
            string usernameRicevente = textBox2.Text;

            if (string.IsNullOrWhiteSpace(usernameRichiedente)
                || string.IsNullOrWhiteSpace(usernameRicevente))
            {
                Form1.ErrorMessage("Inserire degli username corretti.");
                return;
            }

            IQueryable<int> query1 = from U in Form1.db.UTENTE
                                     where U.Username == usernameRichiedente
                                     select U.IDutente;

            IQueryable<int> query2 = from U in Form1.db.UTENTE
                                     where U.Username == usernameRicevente
                                     select U.IDutente;
            try
            {
                AMICIZIA a = new AMICIZIA
                {
                    Richiedente = query1.First(),
                    Ricevente = query2.First(),
                    StatoAmicizia = "In attesa",
                };

                Form1.db.AMICIZIA.InsertOnSubmit(a);
                Form1.db.SubmitChanges();
                MessageBox.Show("Richiesta Inviata");
                dataGridView1.ClearSelection();

            }
            catch (Exception ex)
            {
                Form1.ErrorMessage(ex.Message);
                dataGridView1.ClearSelection();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
