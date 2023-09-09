namespace FitnessLink
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.socialNetworkPalestraDataSet = new FitnessLink.SocialNetworkPalestraDataSet();
            this.aGGIUNTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aGGIUNTATableAdapter = new FitnessLink.SocialNetworkPalestraDataSetTableAdapters.AGGIUNTATableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.socialNetworkPalestraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGGIUNTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // socialNetworkPalestraDataSet
            // 
            this.socialNetworkPalestraDataSet.DataSetName = "SocialNetworkPalestraDataSet";
            this.socialNetworkPalestraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aGGIUNTABindingSource
            // 
            this.aGGIUNTABindingSource.DataMember = "AGGIUNTA";
            this.aGGIUNTABindingSource.DataSource = this.socialNetworkPalestraDataSet;
            // 
            // aGGIUNTATableAdapter
            // 
            this.aGGIUNTATableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crea un allenamento\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Aggiungi una misurazione";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Crea un esercizio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "Prenota una visita";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 45);
            this.button5.TabIndex = 7;
            this.button5.Text = "Crea il tuo profilo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 63);
            this.label1.TabIndex = 8;
            this.label1.Text = "FitnessLink";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(26, 329);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 45);
            this.button6.TabIndex = 9;
            this.button6.Text = "Pubblica un post";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(463, 231);
            this.dataGridView1.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(557, 92);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(153, 45);
            this.button7.TabIndex = 12;
            this.button7.Text = "Visualizza tutti";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(26, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(224, 45);
            this.button8.TabIndex = 13;
            this.button8.Text = "Aggiungi un esercizio";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(333, 393);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 83);
            this.button9.TabIndex = 14;
            this.button9.Text = "Sei un medico? Iscriviti";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(490, 393);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 83);
            this.button10.TabIndex = 15;
            this.button10.Text = "Visualizza il profilo di un utente";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(646, 393);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(150, 83);
            this.button11.TabIndex = 16;
            this.button11.Text = "Visualizza le amicizie di un utente";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 514);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.socialNetworkPalestraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGGIUNTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SocialNetworkPalestraDataSet socialNetworkPalestraDataSet;
        private System.Windows.Forms.BindingSource aGGIUNTABindingSource;
        private SocialNetworkPalestraDataSetTableAdapters.AGGIUNTATableAdapter aGGIUNTATableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

