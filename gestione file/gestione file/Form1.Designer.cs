
namespace gestione_file
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
            this.btnCrea = new System.Windows.Forms.Button();
            this.btnLeggi = new System.Windows.Forms.Button();
            this.btnLeggiA = new System.Windows.Forms.Button();
            this.lblContenuto = new System.Windows.Forms.Label();
            this.txtTesto = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnLeggiFile = new System.Windows.Forms.Button();
            this.lstTesto = new System.Windows.Forms.ListBox();
            this.btnNascondi = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(41, 37);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(136, 57);
            this.btnCrea.TabIndex = 0;
            this.btnCrea.Text = "crea file";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // btnLeggi
            // 
            this.btnLeggi.Location = new System.Drawing.Point(287, 38);
            this.btnLeggi.Name = "btnLeggi";
            this.btnLeggi.Size = new System.Drawing.Size(125, 55);
            this.btnLeggi.TabIndex = 1;
            this.btnLeggi.Text = "leggi file";
            this.btnLeggi.UseVisualStyleBackColor = true;
            this.btnLeggi.Click += new System.EventHandler(this.btnLeggi_Click);
            // 
            // btnLeggiA
            // 
            this.btnLeggiA.Location = new System.Drawing.Point(41, 165);
            this.btnLeggiA.Name = "btnLeggiA";
            this.btnLeggiA.Size = new System.Drawing.Size(136, 46);
            this.btnLeggiA.TabIndex = 2;
            this.btnLeggiA.Text = "leggi contenuto A";
            this.btnLeggiA.UseVisualStyleBackColor = true;
            this.btnLeggiA.Click += new System.EventHandler(this.btnLeggiA_Click);
            // 
            // lblContenuto
            // 
            this.lblContenuto.AutoSize = true;
            this.lblContenuto.Location = new System.Drawing.Point(207, 165);
            this.lblContenuto.Name = "lblContenuto";
            this.lblContenuto.Size = new System.Drawing.Size(87, 17);
            this.lblContenuto.TabIndex = 3;
            this.lblContenuto.Text = "lblContenuto";
            // 
            // txtTesto
            // 
            this.txtTesto.Location = new System.Drawing.Point(41, 269);
            this.txtTesto.Name = "txtTesto";
            this.txtTesto.Size = new System.Drawing.Size(371, 22);
            this.txtTesto.TabIndex = 4;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(435, 267);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 5;
            this.btnSalva.Text = "salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "nome del file da aprire:";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(44, 370);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(368, 22);
            this.txtFile.TabIndex = 7;
            // 
            // btnLeggiFile
            // 
            this.btnLeggiFile.Location = new System.Drawing.Point(435, 368);
            this.btnLeggiFile.Name = "btnLeggiFile";
            this.btnLeggiFile.Size = new System.Drawing.Size(75, 23);
            this.btnLeggiFile.TabIndex = 8;
            this.btnLeggiFile.Text = "leggi";
            this.btnLeggiFile.UseVisualStyleBackColor = true;
            this.btnLeggiFile.Click += new System.EventHandler(this.btnLeggiFile_Click);
            // 
            // lstTesto
            // 
            this.lstTesto.FormattingEnabled = true;
            this.lstTesto.ItemHeight = 16;
            this.lstTesto.Location = new System.Drawing.Point(554, 82);
            this.lstTesto.Name = "lstTesto";
            this.lstTesto.Size = new System.Drawing.Size(208, 308);
            this.lstTesto.TabIndex = 9;
            // 
            // btnNascondi
            // 
            this.btnNascondi.BackColor = System.Drawing.Color.Red;
            this.btnNascondi.Location = new System.Drawing.Point(628, 13);
            this.btnNascondi.Name = "btnNascondi";
            this.btnNascondi.Size = new System.Drawing.Size(134, 39);
            this.btnNascondi.TabIndex = 10;
            this.btnNascondi.Text = "Nascondi tutto";
            this.btnNascondi.UseVisualStyleBackColor = false;
            this.btnNascondi.Click += new System.EventHandler(this.btnNascondi_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(421, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnNascondi);
            this.Controls.Add(this.lstTesto);
            this.Controls.Add(this.btnLeggiFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtTesto);
            this.Controls.Add(this.lblContenuto);
            this.Controls.Add(this.btnLeggiA);
            this.Controls.Add(this.btnLeggi);
            this.Controls.Add(this.btnCrea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Button btnLeggi;
        private System.Windows.Forms.Button btnLeggiA;
        private System.Windows.Forms.Label lblContenuto;
        private System.Windows.Forms.TextBox txtTesto;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnLeggiFile;
        private System.Windows.Forms.ListBox lstTesto;
        private System.Windows.Forms.Button btnNascondi;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

