
namespace Memory
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
            this.pic00 = new System.Windows.Forms.PictureBox();
            this.pic01 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pan = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rdoDifficile = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.btnScambia = new System.Windows.Forms.Button();
            this.pic03 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).BeginInit();
            this.pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic03)).BeginInit();
            this.SuspendLayout();
            // 
            // pic00
            // 
            this.pic00.Location = new System.Drawing.Point(97, 83);
            this.pic00.Name = "pic00";
            this.pic00.Size = new System.Drawing.Size(146, 142);
            this.pic00.TabIndex = 0;
            this.pic00.TabStop = false;
            // 
            // pic01
            // 
            this.pic01.Location = new System.Drawing.Point(268, 83);
            this.pic01.Name = "pic01";
            this.pic01.Size = new System.Drawing.Size(146, 142);
            this.pic01.TabIndex = 1;
            this.pic01.TabStop = false;
            this.pic01.Click += new System.EventHandler(this.pic01_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "nascondi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "scopri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pan
            // 
            this.pan.Controls.Add(this.button3);
            this.pan.Controls.Add(this.radioButton2);
            this.pan.Controls.Add(this.radioButton1);
            this.pan.Location = new System.Drawing.Point(461, 83);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(230, 162);
            this.pan.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "START!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "medio";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "facile";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(436, 326);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 21);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(436, 353);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 21);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rdoDifficile
            // 
            this.rdoDifficile.AutoSize = true;
            this.rdoDifficile.Location = new System.Drawing.Point(473, 13);
            this.rdoDifficile.Name = "rdoDifficile";
            this.rdoDifficile.Size = new System.Drawing.Size(95, 21);
            this.rdoDifficile.TabIndex = 9;
            this.rdoDifficile.TabStop = true;
            this.rdoDifficile.Text = "rdoDifficile";
            this.rdoDifficile.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(473, 40);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(110, 21);
            this.radioButton6.TabIndex = 10;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // btnScambia
            // 
            this.btnScambia.Location = new System.Drawing.Point(96, 368);
            this.btnScambia.Name = "btnScambia";
            this.btnScambia.Size = new System.Drawing.Size(164, 47);
            this.btnScambia.TabIndex = 11;
            this.btnScambia.Text = "Scambia";
            this.btnScambia.UseVisualStyleBackColor = true;
            this.btnScambia.Click += new System.EventHandler(this.btnScambia_Click);
            // 
            // pic03
            // 
            this.pic03.Location = new System.Drawing.Point(268, 257);
            this.pic03.Name = "pic03";
            this.pic03.Size = new System.Drawing.Size(146, 142);
            this.pic03.TabIndex = 12;
            this.pic03.TabStop = false;
            this.pic03.Click += new System.EventHandler(this.pic03_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(436, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "controlla";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 2000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // tmrTempo
            // 
            this.tmrTempo.Enabled = true;
            this.tmrTempo.Interval = 1000;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(683, 289);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(34, 37);
            this.lblTempo.TabIndex = 14;
            this.lblTempo.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pic03);
            this.Controls.Add(this.btnScambia);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.rdoDifficile);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.pan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic01);
            this.Controls.Add(this.pic00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).EndInit();
            this.pan.ResumeLayout(false);
            this.pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic00;
        private System.Windows.Forms.PictureBox pic01;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rdoDifficile;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Button btnScambia;
        private System.Windows.Forms.PictureBox pic03;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.Label lblTempo;
    }
}

