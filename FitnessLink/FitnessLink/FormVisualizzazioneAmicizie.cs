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
    public partial class FormVisualizzazioneAmicizie : Form
    {
        public FormVisualizzazioneAmicizie()
        {
            InitializeComponent();
            this.Text = "FitnessLink - Amicizie";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if (int.TryParse(id, out int id_n))
            {
                var query = from u1 in Form1.db.UTENTE
                                join a in Form1.db.AMICIZIA on u1.IDutente equals a.Ricevente into AmicizieRicevente
                                from amicizia in AmicizieRicevente.DefaultIfEmpty()
                                join u2 in Form1.db.UTENTE on amicizia.Richiedente equals u2.IDutente into UtentiRichiedenti
                                from utenteRichiedente in UtentiRichiedenti.DefaultIfEmpty()
                                where u1.IDutente == id_n
                                select new
                                {
                                    Username = u1.Username,
                                    Follower = utenteRichiedente != null ? utenteRichiedente.Username : "Nessun follower",
                                    StatoAmicizia = amicizia != null ? amicizia.StatoAmicizia : "Nessuna amicizia"
                                };
                dataGridView1.DataSource = query;
            }
            else
            {
                Form1.ErrorMessage("Inserisci un id valido");
                textBox1.Text = string.Empty;
            }

        }
    }
}
