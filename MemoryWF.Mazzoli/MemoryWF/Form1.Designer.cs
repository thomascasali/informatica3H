namespace MemoryWF
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
            this.panDifficoltà = new System.Windows.Forms.Panel();
            this.btnDifficile = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnFacile = new System.Windows.Forms.Button();
            this.lblDifficoltà = new System.Windows.Forms.Label();
            this.panDifficoltà.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDifficoltà
            // 
            this.panDifficoltà.Controls.Add(this.btnDifficile);
            this.panDifficoltà.Controls.Add(this.btnMedia);
            this.panDifficoltà.Controls.Add(this.btnFacile);
            this.panDifficoltà.Controls.Add(this.lblDifficoltà);
            this.panDifficoltà.Location = new System.Drawing.Point(12, 12);
            this.panDifficoltà.Name = "panDifficoltà";
            this.panDifficoltà.Size = new System.Drawing.Size(704, 426);
            this.panDifficoltà.TabIndex = 0;
            // 
            // btnDifficile
            // 
            this.btnDifficile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDifficile.Location = new System.Drawing.Point(237, 307);
            this.btnDifficile.Name = "btnDifficile";
            this.btnDifficile.Size = new System.Drawing.Size(259, 86);
            this.btnDifficile.TabIndex = 3;
            this.btnDifficile.Text = "Difficile";
            this.btnDifficile.UseVisualStyleBackColor = true;
            this.btnDifficile.Click += new System.EventHandler(this.btnDifficile_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.Location = new System.Drawing.Point(237, 196);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(259, 86);
            this.btnMedia.TabIndex = 2;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnFacile
            // 
            this.btnFacile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacile.Location = new System.Drawing.Point(237, 89);
            this.btnFacile.Name = "btnFacile";
            this.btnFacile.Size = new System.Drawing.Size(259, 86);
            this.btnFacile.TabIndex = 1;
            this.btnFacile.Text = "Facile";
            this.btnFacile.UseVisualStyleBackColor = true;
            this.btnFacile.Click += new System.EventHandler(this.btnFacile_Click);
            // 
            // lblDifficoltà
            // 
            this.lblDifficoltà.AutoSize = true;
            this.lblDifficoltà.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficoltà.Location = new System.Drawing.Point(168, 13);
            this.lblDifficoltà.Name = "lblDifficoltà";
            this.lblDifficoltà.Size = new System.Drawing.Size(430, 58);
            this.lblDifficoltà.TabIndex = 0;
            this.lblDifficoltà.Text = "Scegli la difficoltà";
            this.lblDifficoltà.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.panDifficoltà);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panDifficoltà.ResumeLayout(false);
            this.panDifficoltà.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panDifficoltà;
        private System.Windows.Forms.Label lblDifficoltà;
        private System.Windows.Forms.Button btnFacile;
        private System.Windows.Forms.Button btnDifficile;
        private System.Windows.Forms.Button btnMedia;
    }
}

