using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessLink
{
    public partial class FormAggiuntaMisurazione : Form
    {
        public FormAggiuntaMisurazione()
        {
            InitializeComponent();
        }

        private void FormAggiuntaMisurazione_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string altezza = textBox1.Text;
            string peso = textBox2.Text;
            string vita = textBox3.Text;
            string braccio = textBox4.Text;
            string gamba = textBox5.Text;
            var data = monthCalendar1.SelectionStart;
            string id = textBox6.Text;

            if (string.IsNullOrWhiteSpace(altezza)
                || string.IsNullOrWhiteSpace(peso)
                || string.IsNullOrWhiteSpace(vita)
                || string.IsNullOrWhiteSpace(braccio)
                || string.IsNullOrWhiteSpace(gamba)
                || string.IsNullOrWhiteSpace(id)
                )
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if ((int.TryParse(peso, out int peso_n)) 
                && int.TryParse(vita, out int vita_n)
                && int.TryParse(altezza, out int altezza_n)
                && int.TryParse(braccio, out int braccio_n)
                && int.TryParse(gamba, out int gamba_n)
                && int.TryParse(id, out int id_n))

            {
                try
                {
                    MISURAZIONE_CORPOREA mc = new MISURAZIONE_CORPOREA
                    {
                        Utente = id_n,
                        DataMisurazione = data,
                        Peso = peso_n,
                        Altezza = altezza_n,
                        CirconferenzaVita = vita_n,
                        CirconferenzaBraccia = braccio_n,
                        CirconferenzaGambe = gamba_n,
                    };

                    Form1.db.MISURAZIONE_CORPOREA.InsertOnSubmit(mc);
                    Form1.db.SubmitChanges();
                    MessageBox.Show("Misurazione inserita con successo!");

                }
                catch (Exception ex)
                {
                    Form1.ErrorMessage(ex.Message);
                }
            }
            else
            {
                Form1.ErrorMessage("Inserisci un numero valido");
            }
        }
    }
}
