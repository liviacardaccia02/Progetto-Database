﻿using PROVA;
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
            this.Text = "FitnessLink - Aggiunta misurazione corporea";
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
            string username = textBox6.Text;

            if (string.IsNullOrWhiteSpace(altezza)
                || string.IsNullOrWhiteSpace(peso)
                || string.IsNullOrWhiteSpace(vita)
                || string.IsNullOrWhiteSpace(braccio)
                || string.IsNullOrWhiteSpace(gamba)
                || string.IsNullOrWhiteSpace(username)
                )
            {
                Form1.ErrorMessage("Inserire tutti i valori.");
                return;
            }

            if ((int.TryParse(peso, out int peso_n)) 
                && int.TryParse(vita, out int vita_n)
                && int.TryParse(altezza, out int altezza_n)
                && int.TryParse(braccio, out int braccio_n)
                && int.TryParse(gamba, out int gamba_n))
            {
                try
                {
                    IQueryable<int> query = from U in Form1.db.UTENTE 
                                       where U.Username == username
                                       select U.IDutente;


                    MISURAZIONE_CORPOREA mc = new MISURAZIONE_CORPOREA
                    {
                        Utente = query.FirstOrDefault(),
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
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    monthCalendar1.SelectionRange = new SelectionRange();

                }
                catch (Exception ex)
                {
                    Form1.ErrorMessage(ex.Message);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    monthCalendar1.SelectionRange = new SelectionRange();
                }
            }
            else
            {
                Form1.ErrorMessage("Inserisci un numero valido");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }
    }
}
