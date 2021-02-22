
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDue = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 172);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(389, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(211, 39);
            this.lblDisplay.TabIndex = 2;
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(392, 60);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(54, 57);
            this.btnUno.TabIndex = 3;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDue
            // 
            this.btnDue.Location = new System.Drawing.Point(452, 60);
            this.btnDue.Name = "btnDue";
            this.btnDue.Size = new System.Drawing.Size(54, 57);
            this.btnDue.TabIndex = 4;
            this.btnDue.Text = "2";
            this.btnDue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDue);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBottone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBottone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDue;
    }
}

