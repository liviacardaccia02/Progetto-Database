using FitnessLink;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static DataClasses1DataContext db;

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
        }

        public static void ErrorMessage(String text)
        {
            MessageBox.Show(text, "Errore query",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreazioneProfilo formCreazioneProfilo = new FormCreazioneProfilo();
            formCreazioneProfilo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCreazioneAllenamento formCreazioneAllenamento = new FormCreazioneAllenamento();
            formCreazioneAllenamento.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCreazioneEsercizio formCreazioneEsercizio = new FormCreazioneEsercizio();
            formCreazioneEsercizio.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAggiuntaMisurazione formAggiuntaMisurazione = new FormAggiuntaMisurazione();
            formAggiuntaMisurazione.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPubblicazionePost formPubblicazionePost = new FormPubblicazionePost();
            formPubblicazionePost.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormAggiuntaEsercizio formAggiuntaEsercizio = new FormAggiuntaEsercizio();
            formAggiuntaEsercizio.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormPrenotazioneVisita formPrenotazioneVisita = new FormPrenotazioneVisita();   
            formPrenotazioneVisita.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            string entitySelected = comboBox1.GetItemText(comboBox1.SelectedItem);
            try
            {
                IQueryable res = null;

                switch (entitySelected)
                {
                    case "Utenti":
                        res = from U in Form1.db.UTENTE
                              select U;
                        break;
                    case "Allenamenti":
                        res = from A in Form1.db.ALLENAMENTO
                              join U in Form1.db.UTENTE
                              on A.Utente equals U.IDutente
                              select new
                              {
                                  A.CodiceAllenamento,
                                  A.Titolo,
                                  A.DataAllenamento,
                                  A.Durata,
                                  A.LivelloIntensità,
                                  Creatore = U.Username
                              };
                        break;
                    case "Esercizi":
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
                    case "Esercizi aggiunti":
                        res = from A in Form1.db.AGGIUNTA
                              join al in Form1.db.ALLENAMENTO
                              on A.CodiceAllenamento equals al.CodiceAllenamento
                              select new
                              {
                                  Esercizio = A.NomeEsercizio,
                                  MuscoloCoinvolto = A.GruppoMuscolareEsercizio,
                                  Allenamento = al.Titolo,
                              };
                        break;
                    case "Elenco Post":
                        res = from p in Form1.db.POST
                              join a in Form1.db.ALLENAMENTO on p.AllenamentoCollegato equals a.CodiceAllenamento
                              join u in Form1.db.UTENTE on p.Autore equals u.IDutente
                              join i in Form1.db.INTERAZIONE on p.IDpost equals i.Post into grp
                              select new
                              {
                                  Username = u.Username,
                                  AllenamentoCollegato = a.Titolo,
                                  DataPubblicazione = p.DataPubblicazione,
                                  Titolo = p.Titolo,
                                  Didascalia = p.Didascalia,
                                  Like = grp.Count(i => i.TipoInterazione == "Like"),
                                  Commenti = grp.Count(i => i.TipoInterazione == "Commenti")
                              };
                        break;
                    case "Misurazioni Corporee":
                        res = from M in Form1.db.MISURAZIONE_CORPOREA
                              join U in Form1.db.UTENTE
                              on M.Utente equals U.IDutente
                              select new
                              {
                                  Utente = U.Username,
                                  M.DataMisurazione,
                                  M.Peso,
                                  M.Altezza,
                                  M.CirconferenzaVita,
                                  M.CirconferenzaBraccia,
                                  M.CirconferenzaGambe,
                              };
                        break;
                    case "Medici":
                        res = from M in Form1.db.MEDICO
                              select M;
                        break;
                    case "Visite ":
                        res = from V in Form1.db.VISITA
                              join U in Form1.db.UTENTE
                              on V.Paziente equals U.IDutente
                              join M in Form1.db.MEDICO
                              on V.Medico equals M.CF
                              select new
                              {
                                  V.DataVisita,
                                  V.OraVisita,
                                  PrezzoVisita = ((int)V.PrezzoVisita),
                                  Paziente = U.Cognome,
                                  Medico = M.Cognome,
                              };
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
            FormRichiestaAmicizia formRichiestaAmicizia = new FormRichiestaAmicizia();
            formRichiestaAmicizia.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormGestioneAmicizia formGestioneAmicizia = new FormGestioneAmicizia();
            formGestioneAmicizia.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormInterazione formInterazione = new FormInterazione();
            formInterazione.Show();
        }
    }
}
