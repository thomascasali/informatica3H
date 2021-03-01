
namespace Roulette
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblScommessa = new System.Windows.Forms.Label();
            this.txtPuntata = new System.Windows.Forms.TextBox();
            this.btnPunta = new System.Windows.Forms.Button();
            this.lblSoldiPuntati = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picPallina = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnNumero = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumEstratto = new System.Windows.Forms.Label();
            this.lblPariDispari = new System.Windows.Forms.Label();
            this.btnDispari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPallina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pari";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblScommessa
            // 
            this.lblScommessa.AutoSize = true;
            this.lblScommessa.Location = new System.Drawing.Point(236, 43);
            this.lblScommessa.Name = "lblScommessa";
            this.lblScommessa.Size = new System.Drawing.Size(46, 17);
            this.lblScommessa.TabIndex = 1;
            this.lblScommessa.Text = "label1";
            // 
            // txtPuntata
            // 
            this.txtPuntata.Location = new System.Drawing.Point(239, 95);
            this.txtPuntata.Name = "txtPuntata";
            this.txtPuntata.Size = new System.Drawing.Size(100, 22);
            this.txtPuntata.TabIndex = 2;
            this.txtPuntata.TextChanged += new System.EventHandler(this.txtPuntata_TextChanged);
            // 
            // btnPunta
            // 
            this.btnPunta.Location = new System.Drawing.Point(346, 93);
            this.btnPunta.Name = "btnPunta";
            this.btnPunta.Size = new System.Drawing.Size(75, 23);
            this.btnPunta.TabIndex = 3;
            this.btnPunta.Text = "punta";
            this.btnPunta.UseVisualStyleBackColor = true;
            this.btnPunta.Click += new System.EventHandler(this.btnPunta_Click);
            // 
            // lblSoldiPuntati
            // 
            this.lblSoldiPuntati.AutoSize = true;
            this.lblSoldiPuntati.Location = new System.Drawing.Point(511, 43);
            this.lblSoldiPuntati.Name = "lblSoldiPuntati";
            this.lblSoldiPuntati.Size = new System.Drawing.Size(56, 17);
            this.lblSoldiPuntati.TabIndex = 4;
            this.lblSoldiPuntati.Text = "puntata";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(22, 153);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(73, 68);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Roulette.Properties.Resources.roulette;
            this.pictureBox2.Location = new System.Drawing.Point(40, 603);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(712, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // picPallina
            // 
            this.picPallina.BackColor = System.Drawing.Color.White;
            this.picPallina.Location = new System.Drawing.Point(240, 325);
            this.picPallina.Name = "picPallina";
            this.picPallina.Size = new System.Drawing.Size(22, 23);
            this.picPallina.TabIndex = 7;
            this.picPallina.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Roulette.Properties.Resources.istockphoto_656008950_170667a;
            this.pictureBox1.Location = new System.Drawing.Point(192, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 417);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(22, 109);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(73, 22);
            this.txtNumero.TabIndex = 9;
            // 
            // btnNumero
            // 
            this.btnNumero.Location = new System.Drawing.Point(102, 107);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(86, 23);
            this.btnNumero.TabIndex = 10;
            this.btnNumero.Text = "scommetti";
            this.btnNumero.UseVisualStyleBackColor = true;
            this.btnNumero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(79, 607);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numero estratto:";
            // 
            // lblNumEstratto
            // 
            this.lblNumEstratto.BackColor = System.Drawing.Color.White;
            this.lblNumEstratto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumEstratto.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEstratto.Location = new System.Drawing.Point(25, 285);
            this.lblNumEstratto.Name = "lblNumEstratto";
            this.lblNumEstratto.Size = new System.Drawing.Size(87, 63);
            this.lblNumEstratto.TabIndex = 13;
            // 
            // lblPariDispari
            // 
            this.lblPariDispari.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPariDispari.Location = new System.Drawing.Point(27, 359);
            this.lblPariDispari.Name = "lblPariDispari";
            this.lblPariDispari.Size = new System.Drawing.Size(136, 41);
            this.lblPariDispari.TabIndex = 14;
            // 
            // btnDispari
            // 
            this.btnDispari.Location = new System.Drawing.Point(22, 66);
            this.btnDispari.Name = "btnDispari";
            this.btnDispari.Size = new System.Drawing.Size(115, 32);
            this.btnDispari.TabIndex = 15;
            this.btnDispari.Text = "Dispari";
            this.btnDispari.UseVisualStyleBackColor = true;
            this.btnDispari.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 753);
            this.Controls.Add(this.btnDispari);
            this.Controls.Add(this.lblPariDispari);
            this.Controls.Add(this.lblNumEstratto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picPallina);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSoldiPuntati);
            this.Controls.Add(this.btnPunta);
            this.Controls.Add(this.txtPuntata);
            this.Controls.Add(this.lblScommessa);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPallina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblScommessa;
        private System.Windows.Forms.TextBox txtPuntata;
        private System.Windows.Forms.Button btnPunta;
        private System.Windows.Forms.Label lblSoldiPuntati;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox picPallina;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnNumero;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumEstratto;
        private System.Windows.Forms.Label lblPariDispari;
        private System.Windows.Forms.Button btnDispari;
    }
}

