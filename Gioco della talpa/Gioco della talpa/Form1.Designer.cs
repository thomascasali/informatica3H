
namespace Gioco_della_talpa
{
    partial class frmTalpa
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
            this.btnFacile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMedio = new System.Windows.Forms.Button();
            this.btnDifficile = new System.Windows.Forms.Button();
            this.tmrTalpa = new System.Windows.Forms.Timer(this.components);
            this.lblPunti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFacile
            // 
            this.btnFacile.Location = new System.Drawing.Point(47, 64);
            this.btnFacile.Name = "btnFacile";
            this.btnFacile.Size = new System.Drawing.Size(195, 39);
            this.btnFacile.TabIndex = 0;
            this.btnFacile.Text = "Inzia gioco facile";
            this.btnFacile.UseVisualStyleBackColor = true;
            this.btnFacile.Click += new System.EventHandler(this.btnFacile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schiaccia la talpa";
            // 
            // btnMedio
            // 
            this.btnMedio.Location = new System.Drawing.Point(47, 122);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(195, 39);
            this.btnMedio.TabIndex = 2;
            this.btnMedio.Text = "Inzia gioco medio";
            this.btnMedio.UseVisualStyleBackColor = true;
            this.btnMedio.Click += new System.EventHandler(this.btnMedio_Click);
            // 
            // btnDifficile
            // 
            this.btnDifficile.Location = new System.Drawing.Point(47, 179);
            this.btnDifficile.Name = "btnDifficile";
            this.btnDifficile.Size = new System.Drawing.Size(195, 39);
            this.btnDifficile.TabIndex = 3;
            this.btnDifficile.Text = "Inzia gioco difficile";
            this.btnDifficile.UseVisualStyleBackColor = true;
            this.btnDifficile.Click += new System.EventHandler(this.btnDifficile_Click);
            // 
            // tmrTalpa
            // 
            this.tmrTalpa.Interval = 1000;
            this.tmrTalpa.Tick += new System.EventHandler(this.tmrTalpa_Tick);
            // 
            // lblPunti
            // 
            this.lblPunti.AutoSize = true;
            this.lblPunti.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunti.Location = new System.Drawing.Point(13, 212);
            this.lblPunti.Name = "lblPunti";
            this.lblPunti.Size = new System.Drawing.Size(0, 27);
            this.lblPunti.TabIndex = 4;
            // 
            // frmTalpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 258);
            this.Controls.Add(this.lblPunti);
            this.Controls.Add(this.btnDifficile);
            this.Controls.Add(this.btnMedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFacile);
            this.Name = "frmTalpa";
            this.Text = "Gioco schiaccia la talpa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFacile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Button btnDifficile;
        private System.Windows.Forms.Timer tmrTalpa;
        private System.Windows.Forms.Label lblPunti;
    }
}

