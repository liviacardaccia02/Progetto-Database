using System;
using System.Windows.Forms;

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
            string id = textBox2.Text;
            var data = dateTimePicker1.Value;
            var orario = dateTimePicker1.Value.TimeOfDay;
            decimal prezzo;

            if (string.IsNullOrWhiteSpace(cf)
                || string.IsNullOrWhiteSpace(id))
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if (radioButton1.Checked)
            {
                prezzo = 50.00m;

            }
            else if (radioButton2.Checked)
            {
                prezzo = 70.00m;
            }
            else if (radioButton3.Checked)
            {
                prezzo = 100.00m;
            }
            else
            {
                prezzo = 50.00m;
            }


            if (int.TryParse(id, out int id_n))
            {
                try
                {
                    VISITA v = new VISITA
                    {
                        DataVisita = data,
                        OraVisita = orario,
                        PrezzoVisita = prezzo,
                        Paziente = id_n,
                        Medico = cf,

                    };

                    Form1.db.VISITA.InsertOnSubmit(v);
                    Form1.db.SubmitChanges();
                    MessageBox.Show("Visita prenotata con successo!");

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
