namespace Battaglia_navale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbCampo = new System.Windows.Forms.GroupBox();
            this.gbNavi = new System.Windows.Forms.GroupBox();
            this.gbAvversario = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCampo
            // 
            this.gbCampo.Location = new System.Drawing.Point(12, 12);
            this.gbCampo.Name = "gbCampo";
            this.gbCampo.Size = new System.Drawing.Size(941, 745);
            this.gbCampo.TabIndex = 1;
            this.gbCampo.TabStop = false;
            this.gbCampo.Text = "Campo";
            // 
            // gbNavi
            // 
            this.gbNavi.Location = new System.Drawing.Point(959, 12);
            this.gbNavi.Name = "gbNavi";
            this.gbNavi.Size = new System.Drawing.Size(507, 745);
            this.gbNavi.TabIndex = 2;
            this.gbNavi.TabStop = false;
            this.gbNavi.Text = "Navi";
            // 
            // gbAvversario
            // 
            this.gbAvversario.Location = new System.Drawing.Point(28, 792);
            this.gbAvversario.Name = "gbAvversario";
            this.gbAvversario.Size = new System.Drawing.Size(951, 756);
            this.gbAvversario.TabIndex = 3;
            this.gbAvversario.TabStop = false;
            this.gbAvversario.Text = "campoAvversario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(959, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 217);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1042, 916);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 384);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2740, 1783);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAvversario);
            this.Controls.Add(this.gbNavi);
            this.Controls.Add(this.gbCampo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCampo;
        private System.Windows.Forms.GroupBox gbNavi;
        private System.Windows.Forms.GroupBox gbAvversario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

