
namespace Introduzione_alle_liste
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumeri = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbElementi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.txtElimina = new System.Windows.Forms.TextBox();
            this.lstElementi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(79, 35);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(108, 22);
            this.txtNum.TabIndex = 0;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(206, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero di elementi nella collezione:";
            // 
            // lbNumeri
            // 
            this.lbNumeri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbNumeri.Location = new System.Drawing.Point(258, 90);
            this.lbNumeri.Name = "lbNumeri";
            this.lbNumeri.Size = new System.Drawing.Size(60, 23);
            this.lbNumeri.TabIndex = 4;
            this.lbNumeri.Text = "0";
            this.lbNumeri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elementi nella collezione:";
            // 
            // lbElementi
            // 
            this.lbElementi.AutoSize = true;
            this.lbElementi.Location = new System.Drawing.Point(217, 135);
            this.lbElementi.Name = "lbElementi";
            this.lbElementi.Size = new System.Drawing.Size(28, 17);
            this.lbElementi.TabIndex = 6;
            this.lbElementi.Text = "lbE";
            this.lbElementi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "numero:";
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(620, 33);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 27);
            this.btnElimina.TabIndex = 9;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // txtElimina
            // 
            this.txtElimina.Location = new System.Drawing.Point(493, 36);
            this.txtElimina.Name = "txtElimina";
            this.txtElimina.Size = new System.Drawing.Size(108, 22);
            this.txtElimina.TabIndex = 8;
            this.txtElimina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElimina_KeyPress);
            // 
            // lstElementi
            // 
            this.lstElementi.FormattingEnabled = true;
            this.lstElementi.ItemHeight = 16;
            this.lstElementi.Location = new System.Drawing.Point(19, 183);
            this.lstElementi.Name = "lstElementi";
            this.lstElementi.Size = new System.Drawing.Size(265, 244);
            this.lstElementi.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstElementi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.txtElimina);
            this.Controls.Add(this.lbElementi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNumeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNumeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbElementi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox txtElimina;
        private System.Windows.Forms.ListBox lstElementi;
    }
}

