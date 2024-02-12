using PROVA;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessLink
{
    public partial class FormPrenotazioneVisita : Form
    {
        public FormPrenotazioneVisita()
        {
            InitializeComponent();
            this.Text = "FitnessLink - Prenotazione visita";
        }

        private void FormPrenotazioneVisita_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cf = textBox1.Text;
            string username = textBox2.Text;
            var data = dateTimePicker1.Value;
            var orario = dateTimePicker1.Value.TimeOfDay;
            decimal prezzo;

            if (string.IsNullOrWhiteSpace(cf)
                || string.IsNullOrWhiteSpace(username))
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if (radioButton1.Checked)
            {
                prezzo = 50m;

            }
            else if (radioButton2.Checked)
            {
                prezzo = 70m;
            }
            else if (radioButton3.Checked)
            {
                prezzo = 100m;
            }
            else
            {
                prezzo = 50m;
            }


            try
            {
                IQueryable<int> query = from U in Form1.db.UTENTE
                                        where U.Username == username
                                        select U.IDutente;

                VISITA v = new VISITA
                {
                    DataVisita = data,
                    OraVisita = orario,
                    PrezzoVisita = prezzo,
                    Paziente = query.FirstOrDefault(),
                    Medico = cf,

                };

                Form1.db.VISITA.InsertOnSubmit(v);
                Form1.db.SubmitChanges();
                MessageBox.Show("Visita prenotata con successo!");
                textBox1.Text = "";
                textBox2.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                foreach (RadioButton radioButton in groupBox1.Controls.OfType<RadioButton>())
                {
                    radioButton.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Form1.ErrorMessage(ex.Message);
                textBox1.Text = "";
                textBox2.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                foreach (RadioButton radioButton in groupBox1.Controls.OfType<RadioButton>())
                {
                    radioButton.Checked = false;
                }
            }
        }

    }
}
