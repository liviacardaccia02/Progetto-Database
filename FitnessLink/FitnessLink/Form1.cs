using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FitnessLink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Utente");
            comboBox1.Items.Add("Allenamento");
            comboBox1.Items.Add("Esercizio");
            comboBox1.Items.Add("Aggiunta");
            comboBox1.Items.Add("Post");
            comboBox1.Items.Add("Misurazione_corporea");
            comboBox1.Items.Add("Amicizia");
            comboBox1.Items.Add("Interazione");
            comboBox1.Items.Add("Medico");
            comboBox1.Items.Add("Visita");
            this.Text = "FitnessLink - Home";
        }

        public static DataClasses1DataContext db = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
        }
        private void ExecuteQuery(IQueryable query)
        {
            try
            {
                dataGridView1.DataSource = query;
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }

        // bottone creazione del profilo
        private void button5_Click(object sender, EventArgs e)
        {
            FormCreazioneProfilo formCreazioneProfilo = new FormCreazioneProfilo();
            formCreazioneProfilo.Show();
        }

        // bottone creazione allenamento
        private void button1_Click(object sender, EventArgs e)
        {
            FormCreazioneAllenamento formCreazioneAllenamento = new FormCreazioneAllenamento();
            formCreazioneAllenamento.Show();
        }

        // bottone creazione esercizio
        private void button3_Click(object sender, EventArgs e)
        {
            FormCreazioneEsercizio formCreazioneEsercizio = new FormCreazioneEsercizio();   
            formCreazioneEsercizio.Show();
        }

        // bottone pubblicazione post
        private void button6_Click(object sender, EventArgs e)
        {
            FormPubblicazionePost formPubblicazionePost = new FormPubblicazionePost();      
            formPubblicazionePost.Show();
        }

        // bottone aggiunta misurazione
        private void button2_Click(object sender, EventArgs e)
        {
            FormAggiuntaMisurazione formAggiuntaMisurazione = new FormAggiuntaMisurazione();    
            formAggiuntaMisurazione.Show();
        }

        // bottone prenotazione visita
        private void button4_Click(object sender, EventArgs e)
        {
            FormPrenotazioneVisita formPrenotazioneVisita = new FormPrenotazioneVisita();
            formPrenotazioneVisita.Show();
        }

        // bottone aggiunta esercizio
        private void button8_Click(object sender, EventArgs e)
        {
            FormAggiuntaEsercizio formAggiuntaEsercizio = new FormAggiuntaEsercizio();
            formAggiuntaEsercizio.Show();
        }

        public static void ErrorMessage(String testo)
        {
            MessageBox.Show(testo, "Errore query",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string entitySelected = comboBox1.GetItemText(comboBox1.SelectedItem);
            try 
            {
                IQueryable res = null;

                switch(entitySelected) 
                {
                    case "Utente":
                        res = from U in Form1.db.UTENTE
                              select U;
                        break;
                    case "Allenamento":
                        res = from A in Form1.db.ALLENAMENTO
                              select A;
                        break;
                    case "Esercizio":
                        res = from es in Form1.db.ESERCIZIO
                                    join u in Form1.db.UTENTE
                                    on es.Creatore equals u.IDutente
                                    select new
                                    {
                                        Esercizio = es.Nome,
                                        es.GruppoMuscolare,
                                        es.Descrizione,
                                        Creatore = u.Username
                                    };

                        break;
                    case "Aggiunta":
                        res = from A in Form1.db.AGGIUNTA
                              select A;
                        break;
                    case "Post":
                        res = from p in db.POST
                                    join i in db.INTERAZIONE on p.Interazione equals i.IDinterazione
                                    join a in db.ALLENAMENTO on p.AllenamentoCollegato equals a.CodiceAllenamento
                                    join u in db.UTENTE on p.Autore equals u.IDutente
                                    select new 
                                    {
                                        IDpost = p.IDpost,
                                        TipoInterazione = i.TipoInterazione,
                                        AllenamentoCollegato = a.Titolo,
                                        DataPubblicazione = p.DataPubblicazione,
                                        Titolo = p.Titolo,
                                        Didascalia = p.Didascalia,
                                        Username = u.Username
                                    };
                        break;
                    case "Misurazione_corporea":
                        res = from M in Form1.db.MISURAZIONE_CORPOREA
                              select M;
                        break;
                    case "Amicizia":
                        res = from A in Form1.db.AMICIZIA
                              select A;
                        break;
                    case "Interazione":
                        res = from I in Form1.db.INTERAZIONE
                              select I;
                        break;
                    case "Medico":
                        res = from M in Form1.db.MEDICO
                              select M;
                        break;
                    case "Visita":
                        res = from V in Form1.db.VISITA
                              select V;
                        break;
                }

                dataGridView1.DataSource = res;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormAggiuntaMedico formAggiuntaMedico = new FormAggiuntaMedico();
            formAggiuntaMedico.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormVisualizzazioneProfilo formVisualizzazioneProfilo = new FormVisualizzazioneProfilo();
            formVisualizzazioneProfilo.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormVisualizzazioneAmicizie formVisualizzazioneAmicizie = new FormVisualizzazioneAmicizie();
            formVisualizzazioneAmicizie.Show();
        }
    }
}
