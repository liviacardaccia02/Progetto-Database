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
    public partial class FormVisualizzazioneProfilo : Form
    {
        public FormVisualizzazioneProfilo()
        {
            InitializeComponent();
            this.Text = "FitnessLink - Users";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;

            if(string.IsNullOrWhiteSpace(id)) 
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if (int.TryParse(id, out int id_n)) 
            {
                var query = from u in Form1.db.UTENTE
                            where u.IDutente == id_n
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
            else 
            {
                Form1.ErrorMessage("Inserisci un id valido");
                textBox1.Text = string.Empty;
            }

        }
    }
}
