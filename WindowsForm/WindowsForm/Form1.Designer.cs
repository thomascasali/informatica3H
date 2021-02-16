
namespace WindowsForm
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
            this.btnBottone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBottone
            // 
            this.btnBottone.Location = new System.Drawing.Point(62, 54);
            this.btnBottone.Name = "btnBottone";
            this.btnBottone.Size = new System.Drawing.Size(75, 77);
            this.btnBottone.TabIndex = 0;
            this.btnBottone.Text = "spingimi!";
            this.btnBottone.UseVisualStyleBackColor = true;
            this.btnBottone.Click += new System.EventHandler(this.btnBottone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBottone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBottone;
    }
}

